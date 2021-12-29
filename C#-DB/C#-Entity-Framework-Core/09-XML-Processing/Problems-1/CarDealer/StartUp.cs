using System;
using CarDealer.Data;
using CarDealer.DTO.Input;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using CarDealer.Models;
using CarDealer.DTO.Output;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new CarDealerContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //var suplierXml = File.ReadAllText("../../../Datasets/suppliers.xml");
            //var suplierXml = File.ReadAllText("../../../Datasets/parts.xml");

            //Query 9. Import Suppliers
            //Console.WriteLine(ImportSuppliers(context, suplierXml)); 

            //Query 10. Import Parts
            //Console.WriteLine(ImportParts(context, suplierXml));

            //Query 14. Cars With Distance
            //Console.WriteLine(GetCarsWithDistance(context));
        }


        //Query 9. Import Suppliers
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SuplierInputModelDto[]), new 
                XmlRootAttribute("Suppliers"));
            
            var supplierDto = (SuplierInputModelDto[])xmlSerializer.Deserialize(new StringReader(inputXml));

            var suppliers = supplierDto.Select(x => new Supplier
            {
                Name = x.Name,
                IsImporter = x.IsImporter
            })
            .ToList();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}";          
        }

        //Query 10. Import Parts
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(PartsInputModelDto[]), new
                XmlRootAttribute("Parts"));

            var partsDto = (PartsInputModelDto[])xmlSerializer2.Deserialize(new StringReader(inputXml));

            var suppliersIds = context.Suppliers.Select(x => x.Id).ToList();

            var parts = partsDto
                .Where(x => suppliersIds.Contains(x.SupplierId))
                .Select(x => new Part
                {
                    Name = x.Name,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    SupplierId = x.SupplierId
                })
                .ToList();

            context.Parts.AddRange(parts);
            context.SaveChanges();
           
            return $"Successfully imported {parts.Count}";
        }

        //Query 14. Cars With Distance
        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.TravelledDistance > 2000000)
                .Select(c => new CarOutputModelDto
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CarOutputModelDto[]), new XmlRootAttribute("cars"));

            var textWriter = new StringWriter();

            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            xmlSerializer.Serialize(textWriter, cars, ns);

            var result = textWriter.ToString();

            return result;
        }
    }
}