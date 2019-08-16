using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;
using Pluralsight.Graphgl.Mvc.Data.Entities;

namespace Pluralsight.Graphgl.Mvc.Data
{
    public static class InitialData
    {
        public static void Seed(this CarvedRockDbContext dbContext)
        {
            if (!dbContext.Products.Any())
            {
                dbContext.Products.Add(new Product
                {
                    Name = "Mountain Walkers",
                    Description = "Use this shoes to pass any mountain",
                    Price = 109.9m,
                    Rating = 5,
                    Type = ProductType.Boots,
                    Stock = 54,
                    PhotoFileName = "some_shoes_1.jpg",
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview { Title = "Best Product ever", Review = "would buy it every time" },
                        new ProductReview { Title = "Still walking", Review = "I can not stop walking" },
                        new ProductReview { Title = "Are shoes", Review = "Look like shoes, feel like shoes, are definitely shoes." },
                        new ProductReview { Title = "Bääää", Review = "Worst color ever" },
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Hill Walkers",
                    Description = "Use this shoes to pass any hill",
                    Price = 89.9m,
                    Rating = 3,
                    Type = ProductType.Boots,
                    Stock = 12,
                    PhotoFileName = "some_shoes_2.jpg",
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview { Title = "Best Product ever", Review = "would buy it every time" },
                        new ProductReview { Title = "Still walking", Review = "I can not stop walking" },
                        new ProductReview { Title = "Are shoes", Review = "Look like shoes, feel like shoes, are definitely shoes." },
                        new ProductReview { Title = "Bääää", Review = "Worst color ever" },
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Rock walkers",
                    Description = "Use this shoes to pass any Rock",
                    Price = 129.9m,
                    Rating = 5,
                    Type = ProductType.Boots,
                    Stock = 7,
                    PhotoFileName = "some_shoes_3.jpg",
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview { Title = "Best Product ever", Review = "would buy it every time" },
                        new ProductReview { Title = "Still walking", Review = "I can not stop walking" },
                        new ProductReview { Title = "Are shoes", Review = "Look like shoes, feel like shoes, are definitely shoes." },
                        new ProductReview { Title = "Bääää", Review = "Worst color ever" },
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Dont die tied",
                    Description = "Use this harness to not die",
                    Price = 5.1m,
                    Rating = 5,
                    Type = ProductType.ClimbingGear,
                    Stock = 241,
                    PhotoFileName = "some_harness_1.jpg",
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview { Title = "Best Product ever", Review = "would buy it every time" },
                        new ProductReview { Title = "Still walking", Review = "I can not stop walking" },
                        new ProductReview { Title = "Are shoes", Review = "Look like shoes, feel like shoes, are definitely shoes." },
                        new ProductReview { Title = "Bääää", Review = "Worst color ever" },
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Grippy Clemmo",
                    Description = "Use this carbine to hold to the rope",
                    Price = 66.6m,
                    Rating = 2,
                    Type = ProductType.ClimbingGear,
                    Stock = 5,
                    PhotoFileName = "some_carbine_1.jpg",
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview { Title = "Best Product ever", Review = "would buy it every time" },
                        new ProductReview { Title = "Still walking", Review = "I can not stop walking" },
                        new ProductReview { Title = "Are shoes", Review = "Look like shoes, feel like shoes, are definitely shoes." },
                        new ProductReview { Title = "Bääää", Review = "Worst color ever" },
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "Ropyrope",
                    Description = "Use this rope to not fall on any ground",
                    Price = 239.9m,
                    Rating = 5,
                    Type = ProductType.ClimbingGear,
                    Stock = 7,
                    PhotoFileName = "some_rope_1.jpg",
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview { Title = "Best Product ever", Review = "would buy it every time" },
                        new ProductReview { Title = "Still walking", Review = "I can not stop walking" },
                        new ProductReview { Title = "Are shoes", Review = "Look like shoes, feel like shoes, are definitely shoes." },
                        new ProductReview { Title = "Bääää", Review = "Worst color ever" },
                    }
                });

                dbContext.Products.Add(new Product
                {
                    Name = "BoatyMcBoatFace",
                    Description = "Use this ship to celebrate the british",
                    Price = 499.8m,
                    Rating = 5,
                    Type = ProductType.Kayaks,
                    Stock = 0,
                    PhotoFileName = "some_ship_1.jpg",
                    ProductReviews = new List<ProductReview>
                    {
                        new ProductReview { Title = "Best Product ever", Review = "would buy it every time" },
                        new ProductReview { Title = "Still walking", Review = "I can not stop walking" },
                        new ProductReview { Title = "Are shoes", Review = "Look like shoes, feel like shoes, are definitely shoes." },
                        new ProductReview { Title = "Bääää", Review = "Worst color ever" },
                    }
                });

                dbContext.SaveChanges();
            }
        }
    }
}
