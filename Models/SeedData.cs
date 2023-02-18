using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Spunges.Data;
using System;
using System.Linq;

namespace Spunges.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SpungesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SpungesContext>>()))
            {
                // Look for any movies.
                if (context.Spunge.Any())
                {
                    return;   // DB has been seeded
                }

                context.Spunge.AddRange(
                    new Spunge
                    {
                        Brand = "The Nartural Sea Spunge",
                        Material = "Natural Sea Spunge",
                        Color = "Yellow",
                        Shape = "Oval",
                        Rating = 5,
                        Price = 8.2M
                    },

                    new Spunge
                    {
                        Brand = "Scotch Brite",
                        Material = "Synthetic Spunge",
                        Color = "Brown",
                        Shape = "Round",
                        Rating = 5,
                        Price = 7.9M
                    },

                    new Spunge
                    {
                        Brand = "Boscia",
                        Material = "Konja Spunge",
                        Color = "Pink",
                        Shape = "Rectangular",
                        Rating = 4,
                        Price = 6.6M
                    },

                    new Spunge
                    {
                        Brand = "O-Cedar",
                        Material = "Cellulose Spunge",
                        Color = "Blue",
                        Shape = "Circular",
                        Rating = 3,
                        Price = 1.5M
                    },


                    new Spunge
                    {
                        Brand = "Rengora",
                        Material = "Loofah Spunge",
                        Color = "Green",
                        Shape = "Square",
                        Rating = 5,
                        Price = 4.3M
                    },


                    new Spunge
                    {
                        Brand = "Marine Bio",
                        Material = "Honeycomb Spunge",
                        Color = "White",
                        Shape = "Triangular",
                        Rating = 4,
                        Price = 5.5M
                    },


                    new Spunge
                    {
                        Brand = "Mr. Clean",
                        Material = "Polyurethane Foam Spunge",
                        Color = "Red",
                        Shape = "Irregular",
                        Rating = 5,
                        Price = 4.5M
                    },


                    new Spunge
                    {
                        Brand = "Morihata",
                        Material = "Charcoal Spunge",
                        Color = "Black",
                        Shape = "Cylindrical ",
                        Rating = 4,
                        Price = 3.9M
                    },


                    new Spunge
                    {
                        Brand = "Natural Bath & Body",
                        Material = "Wool Spunge",
                        Color = "Gray",
                        Shape = "Tear-Drop",
                        Rating = 3,
                        Price = 2.9M
                    },

                       new Spunge
                       {
                           Brand = "The Silk Spunge",
                           Material = "Sea Silk Spunge",
                           Color = "Orange",
                           Shape = "Irregular",
                           Rating = 5,
                           Price =7.8M
                       }
                );
                context.SaveChanges();
            }
        }
    }
}