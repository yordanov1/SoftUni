namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.Data.Models.Enums;
    using Theatre.DataProcessor.ExportDto;

    public class Serializer
    {
        public static string ExportTheatres(TheatreContext context, int numbersOfHalls)
        {

            var theathres = context.Theatres.Where(x => x.NumberOfHalls >= numbersOfHalls && x.Tickets.Count >= 20).ToArray()
                .Select(x => new
                {
                    Name = x.Name,
                    Halls = x.NumberOfHalls,
                    TotalIncome = Math.Round(x.Tickets.Where(r => r.RowNumber >= 1 && r.RowNumber <= 5).Sum(t => t.Price), 2),
                    Tickets = x.Tickets.Where(r => r.RowNumber >= 1 && r.RowNumber <= 5).Select(t => new
                    {
                        Price = t.Price,
                        RowNumber = t.RowNumber
                    })
                    .OrderByDescending(t => t.Price)
                    .ToArray()
                })
                .OrderByDescending(x => x.Halls)
                .ThenBy(x => x.Name)
                .ToArray();


                string json = JsonConvert.SerializeObject(theathres, Formatting.Indented);

                return json;           
        }

        public static string ExportPlays(TheatreContext context, double rating)
        {

            var plays = context.Plays
                .Where(x => x.Rating <= rating)
                .OrderBy(x => x.Title)
                .ThenByDescending(x => x.Genre)
                .Select(x => new ExportPlaysDTO()
                {
                    Title = x.Title,
                    Duration = x.Duration.ToString("c", CultureInfo.InvariantCulture),
                    Rating = x.Rating == 0 ? "Premier" : x.Rating.ToString(),
                    Genre = x.Genre.ToString(),
                    Actors = x.Casts
                    .Where(main => main.IsMainCharacter)
                    .Select(a => new ExportActorDTO() 
                    {
                        FullName = a.FullName,
                        MainCharacter = $"Plays main character in '{a.Play.Title}'."
                    })
                    .OrderByDescending(a => a.FullName)
                    .ToArray()
                }).ToArray();


            StringBuilder sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);
            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportPlaysDTO[]), new XmlRootAttribute("Plays"));

            using (StringWriter writer = new StringWriter(sb))
            {
                xmlSerializer.Serialize(writer, plays, namespaces);
            }

            return sb.ToString().TrimEnd();            
        }
    }
}
