using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProductShop.Data;
using ProductShop.DataTransferObjects;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var productShopContext = new ProductShopContext();

            productShopContext.Database.EnsureDeleted();
            productShopContext.Database.EnsureCreated();

            //Query 1. Import Users
            //string inputJason = File.ReadAllText("../../../Datasets/users.json"); 
            //var result = ImportUsers(productShopContext, inputJason);

            //Query 2. Import Products
            //string inputJason = File.ReadAllText("../../../Datasets/products.json"); 
            //var result = ImportProducts(productShopContext, inputJason);


            //Query 3. Import Categories
            //string inputJason = File.ReadAllText("../../../Datasets/categories.json"); 
            //var result = ImportCategories(productShopContext, inputJason);

            //Query 4. Import Categories and Products
            //string inputJason = File.ReadAllText("../../../Datasets/categories-products.json"); 
            //var result = ImportCategoryProducts(productShopContext, inputJason);

            //Query 5. Export Products in Range
            //var result = GetProductsInRange(productShopContext);

            //Query 6. Export Successfully Sold Products
            //var result = GetProductsInRange(productShopContext);

            //Query 7. Export Categories by Products Count
            //var result = GetCategoriesByProductsCount(productShopContext);

            //Query 8. Export Users and Products
            //var result = GetUsersWithProducts(productShopContext);

            //Console.WriteLine(result);

        }

        //Query 1. Import Users
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var users = JsonConvert.DeserializeObject<User[]>(inputJson);

            context.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Length}";
        }

        //Query 2. Import Products
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var products = JsonConvert.DeserializeObject<Product[]>(inputJson);

            context.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Length}";
        }

        //Query 3. Import Categories
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            Category[] categoiries = JsonConvert.DeserializeObject<Category[]>(inputJson)
                .Where(c => c.Name != null).ToArray();

            context.AddRange(categoiries);

            context.SaveChanges();

            return $"Successfully imported {categoiries.Length}";
        }

        //Query 4. Import Categories and Products
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var categoryProdycts = JsonConvert.DeserializeObject<CategoryProduct[]>(inputJson);

            context.AddRange(categoryProdycts);
            context.SaveChanges();

            return $"Successfully imported {categoryProdycts.Length}";
        }

        //Query 5. Export Products in Range
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(x => x.Price >= 500 && x.Price <= 1000)
                .Select(p => new
                {
                    name = p.Name,
                    price = p.Price,
                    seller = p.Seller.FirstName + " " + p.Seller.LastName
                })
                .OrderBy(x => x.price)
                .ToArray();

            var test = JsonConvert.SerializeObject(products, Formatting.Indented);

            return test;
        }

        //Query 6. Export Successfully Sold Products
        public static string GetSoldProducts(ProductShopContext context)
        {
            var usersSoldProducts = context.Users
                .Where(x => x.ProductsSold.Any(y => y.BuyerId != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    soldProducts = u.ProductsSold
                    .Where(p => p.BuyerId != null)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        buyerFirstName = p.Buyer.FirstName,
                        buyerLastName = p.Buyer.LastName
                    })
                })
                .OrderBy(x => x.lastName)
                .ThenBy(x => x.firstName)
                .ToList();


            var result = JsonConvert.SerializeObject(usersSoldProducts, Formatting.Indented);

            return result;
        }

        //Query 7. Export Categories by Products Count
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .Select(x => new
                {
                    category = x.Name,
                    productsCount = x.CategoryProducts.Count,
                    averagePrice = x.CategoryProducts.Average(y => y.Product.Price).ToString("F2"),
                    totalRevenue = x.CategoryProducts.Sum(y => y.Product.Price).ToString("F2")
                })
                .OrderByDescending(x => x.productsCount)
                .ToList();

            var result = JsonConvert.SerializeObject(categories, Formatting.Indented);

            return result;
        }

        //Query 8. Export Users and Products
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Include(x => x.ProductsSold)
                .ToList()
                .Where(x => x.ProductsSold.Any(b => b.BuyerId != null))
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    soldProducts = new
                    {
                        count = u.ProductsSold.Where(x => x.BuyerId != null).Count(),
                        products = u.ProductsSold.Where(x => x.BuyerId != null).Select(p => new
                        {
                            name = p.Name,
                            price = p.Price
                        })
                    }
                })
                .OrderByDescending(x => x.soldProducts.products.Count())
                .ToList();


            var resultObject = new
            {
                usersCount = users.Count(),
                users = users
            };

            var jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            var result = JsonConvert.SerializeObject(resultObject, Formatting.Indented, jsonSerializerSettings);

            return result;
        }
    }
}