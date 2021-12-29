using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.DTO;
using CarDealer.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

           var context = new CarDealerContext();
            
           context.Database.EnsureDeleted();
           context.Database.EnsureCreated();
            
            //var json = File.ReadAllText("../../../Datasets/suppliers.json");
            //var json = File.ReadAllText("../../../Datasets/parts.json");
            //var json = File.ReadAllText("../../../Datasets/cars.json");
            //var json = File.ReadAllText("../../../Datasets/customers.json");
            //var json = File.ReadAllText("../../../Datasets/sales.json");



            //Query 9. Import Suppliers
            //ImportSuppliers(context, json);

            //Query 10. Import Parts
            //ImportParts(context, json);

            //Query 11. Import Cars
            //ImportCars(context, json);

            //Query 12. Import Customers
            //ImportCustomers(context, json);

            //Query 13. Import Sales
            //ImportSales(context, json);

            //Query 14. Export Local Suppliers
            //Console.WriteLine(GetOrderedCustomers(context));

            //Query 15.Export Cars from Make Toyota
            //Console.WriteLine(GetCarsFromMakeToyota(context));

            //Query 16. Export Local Suppliers
            //Console.WriteLine(GetLocalSuppliers(context));

            //Query 17. Export Cars with Their List of Parts
            //Console.WriteLine(GetCarsWithTheirListOfParts(context));

            //Query 18. Export Total Sales by Customer
            //Console.WriteLine(GetTotalSalesByCustomer(context));

            //Query 19. Export Sales with Applied Discount
            //Console.WriteLine(GetSalesWithAppliedDiscount(context));


        }

        //Query 9. Import Suppliers
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var suppliersDTO = JsonConvert
                .DeserializeObject<IEnumerable<ImportSuplirtInputModelDto>>(inputJson);

            var suppliers = suppliersDTO.Select(x => new Supplier
            {
                Name = x.Name,
                IsImporter = x.IsImporter
            })
            .ToList();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}.";            
        }

        //Query 10. Import Parts
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var partsDTO = JsonConvert
                .DeserializeObject<IEnumerable<ImportPartsDto>>(inputJson);

            var suppliers = context.Suppliers.ToList();

            var parts = partsDTO
                .Where(x => context.Suppliers.Any(y => y.Id == x.SupplierId))
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

            return $"Successfully imported {parts.Count}.";
        }

        //Query 11. Import Cars
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var carsDto = JsonConvert.DeserializeObject<IEnumerable<ImportCarsDto>>(inputJson);

            var listOfCars = new List<Car>();

            foreach (var car in carsDto)
            {
                var currentCar = new Car
                {
                    Make = car.Make,
                    Model = car.Model,
                    TravelledDistance = car.TravelledDistance
                };

                foreach (var partId in car?.PartsId.Distinct())
                {
                    currentCar.PartCars.Add(new PartCar
                    {
                        PartId = partId
                    });
                }
                
                listOfCars.Add(currentCar);
            }

            context.Cars.AddRange(listOfCars);
            context.SaveChanges();

           return $"Successfully imported {listOfCars.Count}.";
        }

        //Query 12. Import Customers
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var customersDto = JsonConvert.DeserializeObject<IEnumerable<ImportCustomersDto>>(inputJson);

            var customers = customersDto
                .Select(x => new Customer
                {
                    Name = x.Name,
                    BirthDate = x.BirthDate,
                    IsYoungDriver = x.IsYoungDriver
                })
                .ToArray();

            context.AddRange(customers);
            context.SaveChanges();

           return $"Successfully imported {customers.Length}.";
        }

        //Query 13. Import Sales
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var salesDto = JsonConvert.DeserializeObject<IEnumerable<ImportSalesDto>>(inputJson);

            var sales = salesDto
                .Select(x => new Sale
                {
                    CarId = x.CarId,
                    CustomerId = x.CustomerId,
                    Discount = x.Discount
                }).ToList();


            context.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}.";
        }

        //Query 14. Export Local Suppliers
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .Select(c => new
                {
                    c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    c.IsYoungDriver
                })
                .ToList();

            var customersJson = JsonConvert.SerializeObject(customers, Formatting.Indented);

            return customersJson;
        }

        //Query 15.Export Cars from Make Toyota
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var toyotas = context.Cars
                .Where(x => x.Make == "Toyota")
                .Select(x => new
                {
                    Id = x.Id,
                    Make = x.Make,
                    Model = x.Model,
                    TravelledDistance = x.TravelledDistance
                })
                .OrderBy(x => x.Model)
                .ThenByDescending(x => x.TravelledDistance)
                .ToList();

                var toyotasJson = JsonConvert.SerializeObject(toyotas);

            return toyotasJson;
        }

        //Query 16. Export Local Suppliers
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                 .Where(x => x.IsImporter == false)
                 .Select(x => new
                 {
                     Id = x.Id,
                     Name = x.Name,
                     PartsCount = x.Parts.Count
                 })
                 .ToList();

            var suppliersJson = JsonConvert.SerializeObject(suppliers, Formatting.Indented);
            
            return suppliersJson;
        }

        //Query 17. Export Cars with Their List of Parts
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .Select(c => new ExportCarPartsDto
                {
                    Car = new ExportCarDto
                    {
                        Make = c.Make,
                        Model = c.Model,
                        TravelledDistance = c.TravelledDistance
                    },
                    Parts = c.PartCars
                        .Select(p => new ExportPartDto
                        {
                            Name = p.Part.Name,
                            Price = $"{p.Part.Price:F2}"
                        })
                        .ToList()
                })
                .ToList();

            var carsJson = JsonConvert.SerializeObject(cars, Formatting.Indented);

            return carsJson;
        }

        //Query 18. Export Total Sales by Customer
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                .Where(x => x.Sales.Count > 0)
                .Select(x => new
                {
                    FullName = x.Name,
                    BoughtCars = x.Sales.Count(),                             
                    SpentMoney = x.Sales.SelectMany(s => s.Car.PartCars).Sum(p => p.Part.Price)
                })
                .OrderByDescending(x => x.SpentMoney)
                .ThenByDescending(x => x.BoughtCars)
                .ToList();
         

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var customersJson = JsonConvert.SerializeObject(customers, settings);

            return customersJson;
        }

        //Query 19. Export Sales with Applied Discount
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
           var sales = context.Sales

          .Select(s => new ExportCustomerSaleDto
          {
              Car = new ExportCarDto
              {
                  Make = s.Car.Make,
                  Model = s.Car.Model,
                  TravelledDistance = s.Car.TravelledDistance
              },
              CustomerName = s.Customer.Name,
              Discount = s.Discount,
              Price = s.Car.PartCars.Sum(pc => pc.Part.Price),
              PriceWithDiscount = s.Car.PartCars.Sum(pc => pc.Part.Price) -
                                      s.Car.PartCars.Sum(pc => pc.Part.Price) * s.Discount / 100
          })
          .Take(10)
          .ToList();

            string result = JsonConvert.SerializeObject(sales, Formatting.Indented);

            return result;
        }
    }
}

