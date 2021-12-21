namespace VaporStore.DataProcessor
{
	using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.DataProcessor.Dto.Export;

    public static class Serializer
	{
		public static string ExportGamesByGenres(VaporStoreDbContext context, string[] genreNames)
		{
			var games = context.Genres.ToList().Where(x => genreNames.Contains(x.Name))
				.Select(x => new
			{
				Id = x.Id,
				Genre = x.Name,
				Games = x.Games.Select(g => new
				{
					Id = g.Id,
					Title = g.Name,
					Developer = g.Developer.Name,
					Tags = string.Join(", ", g.GameTags.Select(gt => gt.Tag.Name)),
					Players = g.Purchases.Count()
				}).Where(x => x.Players > 0)
				  .OrderByDescending(x => x.Players)
				  .ThenBy(x => x.Id),
				TotalPlayers = x.Games.Sum(g => g.Purchases.Count)
			})
				.OrderByDescending(x => x.TotalPlayers)
				.ThenBy(x => x.Id);


			string jsonResult = JsonConvert.SerializeObject(games, Formatting.Indented);

			return jsonResult;
		}

		public static string ExportUserPurchasesByType(VaporStoreDbContext context, string storeType)
		{
			var users = context.Users.ToArray()
				.Where(x => x.Cards.Any(p => p.Purchases.Any(t => 
				t.Type.ToString() == storeType)))
				.Select(x => new ExportUserPurchasesDTO()
				{
					Username = x.Username,
					TotalSpent = x.Cards.Sum(
						p => p.Purchases.Where(t => t.Type.ToString() == storeType)
						.Sum(g => g.Game.Price)),
					Purchases = x.Cards.SelectMany(p => p.Purchases)
					.Where(x => x.Type.ToString() == storeType)					
					.Select(p => new ExportPurchaseDTO()
					{
						Card = p.Card.Number,
						Cvc = p.Card.Cvc,
						Date = p.Date.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
						Game = new ExportGameDTO()
						{
							Title = p.Game.Name,
							Genre = p.Game.Genre.Name,
							Price = p.Game.Price
						}
					})
					.OrderBy(x => x.Date)
					.ToArray()
				})
				.OrderByDescending(x => x.TotalSpent)
				.ThenBy(x => x.Username)
				.ToArray();

			var sb = new StringBuilder();

			var namespaces = new XmlSerializerNamespaces();
			namespaces.Add(String.Empty, String.Empty);

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportUserPurchasesDTO[]), new XmlRootAttribute("Users"));

			using (StringWriter writer = new StringWriter(sb))
            {
				xmlSerializer.Serialize(writer, users, namespaces);
            }
 
			return sb.ToString().TrimEnd();
		}
	}
}