using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ShaversWebApplication.Models;

namespace ShaversWebApplication.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> 
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Razors"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Hair Accessories"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Tan Accessories"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> 
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Electric Razor",
                    Description = "Razor for trimming beards or shaving heads." + 
                                  "Cordless battery of up to one hour", 
                    ImagePath="Razor.jpg",
                    UnitPrice = 48.50,
                    CategoryID = 1
                },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Cut-Throat Razor",
                    Description = "Stainless steel cut-throat razor for the perfect close shave.",
                    ImagePath="CutThroatRazor.jpg",
                    UnitPrice = 37.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Slider Razor",
                    Description = "Unique free-hand razor. Comes with DVD on how to use.",
                    ImagePath="Slider.jpg",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Scissors",
                    Description = "Black Titan professional hair cutting scissors",
                    ImagePath="Scissors.jpg",
                    UnitPrice = 13.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Kmes Hair Wax",
                    Description = "Kmes strong hold, long last, hair wax.",
                    ImagePath="KmesHairWax.jpg",
                    UnitPrice = 7.50,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Dax Wax",
                    Description = "Dax Wax for grooming short hair.",
                    ImagePath="DaxWax.jpg",
                    UnitPrice = 6.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Brylcreem",
                    Description = "Brylcreem styling creem for long and short hair.",
                    ImagePath="Brylcreem.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Redken Shampoo",
                    Description = "Redken mens shampoo for hair.",
                    ImagePath="Redken.png",
                    UnitPrice = 19.99,
                    CategoryID = 2  
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "DefinitelyDark",
                    Description = "Definitely Dark tan enhancing cream.",
                    ImagePath="DefinitelyDark.jpg",
                    UnitPrice = 12.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Mango Tango",
                    Description = "Mango Tango tan enhancing cream.",
                    ImagePath="MangoTango.jpg",
                    UnitPrice = 14.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Shore Thing",
                    Description = "Shore Thing tan enhancing cream.",
                    ImagePath="ShoreThing.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Australian Gold",
                    Description = "Australian Gold tan enhancing cream.",
                    ImagePath="AustrailianGold.jpg",
                    UnitPrice = 14.00,
                    CategoryID = 3
                },
            };

            return products;
        }
    }
}