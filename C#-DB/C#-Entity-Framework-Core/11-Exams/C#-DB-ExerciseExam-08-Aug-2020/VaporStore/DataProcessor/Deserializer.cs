namespace VaporStore.DataProcessor
{
	using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.DataProcessor.Dto.Import;

    public static class Deserializer
	{
		public static string ImportGames(VaporStoreDbContext context, string jsonString)
		{			
			var games = JsonConvert.DeserializeObject<IEnumerable<ImportGamesDevsGenresTagsDTO>>(jsonString);

			var sb = new StringBuilder();

            foreach (var jsonGame in games)
            {

				if (!IsValid(jsonGame) || jsonGame.Tags.Count() == 0)
				{
					sb.AppendLine("Invalid Data");
					continue;
				}

				var genre = context.Genres.FirstOrDefault(x => x.Name == jsonGame.Genre)
					?? new Genre { Name = jsonGame.Genre };

				var developer = context.Developers.FirstOrDefault(x => x.Name == jsonGame.Developer)
					?? new Developer { Name = jsonGame.Developer };

				//var developer = context.Developers.FirstOrDefault(x => x.Name == jsonGame.Developer);
                //if (developer == null)
                //{
				//	developer = new Developer { Name = jsonGame.Developer };
                //}

				var game = new Game
				{
					Name = jsonGame.Name,
					Price = jsonGame.Price,
					ReleaseDate = jsonGame.ReleaseDate.Value,
					Developer = developer,
					Genre = genre
				};

				foreach (var jsonTag in jsonGame.Tags)
				{
					var tag = context.Tags.FirstOrDefault(x => x.Name == jsonTag)
						?? new Tag { Name = jsonTag };
					game.GameTags.Add(new GameTag { Tag = tag });
				}

				context.Games.Add(game);

				context.SaveChanges();

				sb.AppendLine($"Added {jsonGame.Name} ({jsonGame.Genre}) with {jsonGame.Tags.Count()} tags");						
			}
		
			return sb.ToString().TrimEnd();						
		}

		public static string ImportUsers(VaporStoreDbContext context, string jsonString)
		{
			
			var sb = new StringBuilder();

			List<User> usersToAdd = new List<User>();

			ImportUsersCardDTO[] userDtos = JsonConvert
				.DeserializeObject<ImportUsersCardDTO[]>(jsonString);

            foreach (var userDto in userDtos)
            {
                if (!IsValid(userDto))
                {
					sb.AppendLine("Invalid Data");
					continue;
                }


                foreach (var card in userDto.Cards)
                {
                    if (!IsValid(card))
                    {
						continue;
					}

                    if (card.Type.ToString() != "Debit" || card.Type.ToString() != "Credit")
                    {
						continue;
					}
                }

				User user = new User()
				{
					FullName = userDto.FullName,
					Username = userDto.Username,
					Email = userDto.Email,
					Age = userDto.Age,
				};

                foreach (var card in userDto.Cards)
                {
					user.Cards.Add(new Card
					{
						Number = card.Number,
						Cvc = card.Cvc,
						Type = card.Type
					});
                }

				usersToAdd.Add(user);

				sb.AppendLine($"Imported {user.Username} with {user.Cards.Count} cards");

			}

			context.Users.AddRange(usersToAdd);

			context.SaveChanges();

			return sb.ToString().TrimEnd();
		}
		
		public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
		{
			
			var sb = new StringBuilder();

			List<Purchase> purchasesToAdd = new List<Purchase>();

			var serializer = new XmlSerializer(typeof(ImportPurchasesDTO[]), new XmlRootAttribute("Purchases"));


			using(StringReader reader = new StringReader(xmlString))
            {
				var purchaseDtos = (ImportPurchasesDTO[])serializer.Deserialize(reader);

                foreach (var purchaseDto in purchaseDtos)
                {

                    if (!IsValid(purchaseDto))
                    {
						sb.AppendLine("Invalid Data");
						continue;
                    }

					bool parseDate = DateTime.TryParseExact(purchaseDto.Date, "dd/MM/yyyy HH:mm",
						CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);

                    if (!parseDate)
                    {
						sb.AppendLine("Invalid Data");
						continue;
                    }

					Purchase purchase = new Purchase()
					{
						Type = purchaseDto.Type.Value,
						ProductKey = purchaseDto.Key,
						Date = date						
					};

				    purchase.Card = context.Cards.FirstOrDefault(x => x.Number == purchaseDto.Card);
				    purchase.Game = context.Games.FirstOrDefault(x => x.Name == purchaseDto.Title);

					var userName = context.Users.Where(x => x.Id == purchase.Card.UserId)
						.Select(n => n.Username).FirstOrDefault();

					purchasesToAdd.Add(purchase);

					sb.AppendLine($"Imported {purchaseDto.Title} for {userName}");		
				}							
			}

			context.Purchases.AddRange(purchasesToAdd);

			context.SaveChanges();

			return sb.ToString().TrimEnd();		
		}



		private static bool IsValid(object dto)
		{
			var validationContext = new ValidationContext(dto);
			var validationResult = new List<ValidationResult>();

			return Validator.TryValidateObject(dto, validationContext, validationResult, true);
		}
	}
}