namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.Data.Models;
    using Theatre.Data.Models.Enums;
    using Theatre.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";        

        public static string ImportPlays(TheatreContext context, string xmlString)
        {
            var sb = new StringBuilder();

            List<Play> playsToAdd = new List<Play>();


            XmlSerializer serialize = new XmlSerializer(typeof(ImportPlaysDTO[]), new XmlRootAttribute("Plays"));

            using (StringReader reader = new StringReader(xmlString))
            {
                var playDtos = (ImportPlaysDTO[])serialize.Deserialize(reader);
                

                foreach (var playDto in playDtos)
                {

                    TimeSpan duration = TimeSpan.ParseExact(playDto.Duration, "c", CultureInfo.InvariantCulture);

                    if (!IsValid(playDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if (duration.Hours == 0)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Play play = new Play()
                    {
                        Title = playDto.Title,
                        Duration = duration,
                        Rating = playDto.Rating,
                        Genre = Enum.Parse<Genre>(playDto.Genre),
                        Description = playDto.Description,
                        Screenwriter = playDto.Screenwriter
                    };


                    playsToAdd.Add(play);

                    sb.AppendLine($"Successfully imported {play.Title} with genre {play.Genre} and a rating of {play.Rating}!");
                }             

            }

            context.Plays.AddRange(playsToAdd);

            context.SaveChanges();

            return sb.ToString().TrimEnd();            
        }

        public static string ImportCasts(TheatreContext context, string xmlString)
        {

            var sb = new StringBuilder();

            List<Cast> castsToAdd = new List<Cast>();

            XmlSerializer serialize = new XmlSerializer(typeof(ImportCastsDTO[]), new XmlRootAttribute("Casts"));

            using (StringReader reader = new StringReader(xmlString))
            {

                var castDtos = (ImportCastsDTO[])serialize.Deserialize(reader);

                foreach (var castDto in castDtos)
                {
                    if (!IsValid(castDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }


                    Cast cast = new Cast()
                    {
                        FullName = castDto.FullName,
                        IsMainCharacter = castDto.IsMainCharacter,
                        PhoneNumber = castDto.PhoneNumber,
                        PlayId = castDto.PlayId
                    };


                    string role = String.Empty;

                    if (cast.IsMainCharacter)
                    {
                        role = "main";
                    }
                    else
                    {
                        role = "lesser";
                    }
                    

                    castsToAdd.Add(cast);

                    sb.AppendLine($"Successfully imported actor {cast.FullName} as a {role} character!");
                }

            }

            context.Casts.AddRange(castsToAdd);

            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportTtheatersTickets(TheatreContext context, string jsonString)
        {
            var sb = new StringBuilder();

            List<Theatre> theatreToAdd = new List<Theatre>();

            var theatreDtos = JsonConvert.DeserializeObject<ImportProjectionsDTO[]>(jsonString);

            foreach (var theatreDto in theatreDtos)
            {

                if (!IsValid(theatreDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }                              

                Theatre theatre = new Theatre()
                {
                    Name = theatreDto.Name,
                    NumberOfHalls = theatreDto.NumberOfHalls,
                    Director = theatreDto.Director,
                };

                foreach (var tiket in theatreDto.Tickets)
                {                    
                    if (!IsValid(tiket))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
              
                    theatre.Tickets.Add(new Ticket
                    {
                        Price = tiket.Price,
                        RowNumber = tiket.RowNumber,
                        PlayId = tiket.PlayId
                    });
                }

                theatreToAdd.Add(theatre);

                sb.AppendLine($"Successfully imported theatre {theatre.Name} with #{theatre.Tickets.Count} tickets!");
            }

            context.Theatres.AddRange(theatreToAdd);

            context.SaveChanges();
            
            return sb.ToString().TrimEnd();
        }


        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
