using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin" });
            }


            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Assassin's Creed Valhalla",
                    Description =
                        "Just a fake description for the project.",
                    Price = 3999,
                    PictureUrl = "/images/products/Assassin's Creed Valhalla -PS4.png",
                    Brand = "Ubisoft Montreal",
                    Type = "Game",
                    Console = "Playstation 4",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Assassin's Creed Valhalla",
                    Description =
                        "Just a fake description for the project.",
                    Price = 6999,
                    PictureUrl = "/images/products/Assassin's Creed Valhalla -PS5.png",
                    Brand = "Ubisoft Montreal",
                    Type = "Game",
                    Console = "Playstation 5",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Atlas Fallen",
                    Description =
                        "Just a fake description for the project.",
                    Price = 5999,
                    PictureUrl = "/images/products/Atlas Fallen.png",
                    Brand = "Deck13 Interactive",
                    Type = "Game",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Cyberpunk 2077",
                    Description =
                       "Just a fake description for the project.",
                    Price = 5999,
                    PictureUrl = "/images/products/Cyberpunk 2077.png",
                    Brand = "CD Projekt RED",
                    Type = "Game",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "dualsense wireless controller white",
                    Description =
                        "Just a fake description for the project.",
                    Price = 4999,
                    PictureUrl = "/images/products/dualsense wireless controller white.png",
                    Brand = "Sony",
                    Type = "Controller",
                    Console = "Playstation 5",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "dualsense wireless controller black",
                    Description =
                        "Just a fake description for the project.",
                    Price = 4999,
                    PictureUrl = "/images/products/dualsense wireless controller black.png",
                    Brand = "Sony",
                    Type = "Controller",
                    Console = "Playstation 5",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "dualshock wireless controller black",
                    Description =
                        "Just a fake description for the project.",
                    Price = 2999,
                    PictureUrl = "/images/products/dualshock wireless controller black.png",
                    Brand = "Sony",
                    Type = "Controller",
                    Console = "Playstation 4",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "dualshock wireless controller white",
                    Description =
                        "Just a fake description for the project.",
                    Price = 2999,
                    PictureUrl = "/images/products/dualshock wireless controller white.png",
                    Brand = "Sony",
                    Type = "Controller",
                    Console = "Playstation 4",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gran Turismo 7",
                    Description =
                        "Just a fake description for the project.",
                    Price = 6999,
                    PictureUrl = "/images/products/Gran Turismo 7.png",
                    Brand = "Polyphony Digital",
                    Type = "Game",
                    Console = "Playstation 5",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Hogwarts Legacy",
                    Description =
                        "Just a fake description for the project.",
                    Price = 6999,
                    PictureUrl = "/images/products/Hogwarts Legacy.png",
                    Brand = "Avalanche Software",
                    Type = "Game",
                    Console = "Playstation 5",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Horizon Forbidden West",
                    Description =
                        "Just a fake description for the project.",
                    Price = 6999,
                    PictureUrl = "/images/products/HFW.png",
                    Brand = "Guerrilla Games",
                    Type = "Game",
                    Console = "Playstation 5",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "lords of the Fallen",
                    Description =
                        "Just a fake description for the project.",
                    Price = 6999,
                    PictureUrl = "/images/products/lords of the Fallen.png",
                    Brand = "Deck13 Interactive",
                    Type = "Game",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Redfall",
                    Description =
                        "Just a fake description for the project.",
                    Price = 5999,
                    PictureUrl = "/images/products/Redfall.png",
                    Brand = "Arkane Studios",
                    Type = "Game",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lies of P",
                    Description =
                        "Just a fake description for the project.",
                    Price = 4999,
                    PictureUrl = "/images/products/LOP.png",
                    Brand = "Round 8 Studio",
                    Type = "Game",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },
                
                new Product
                {
                    Name = "Resident Evil 4",
                    Description =
                        "Just a fake description for the project.",
                    Price = 5999,
                    PictureUrl = "/images/products/Resident Evil 4.png",
                    Brand = "Capcom",
                    Type = "Game",
                    Console = "Playstation 4",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Resident Evil Village",
                    Description = 
                        "Just a fake description for the project.",
                    PictureUrl = "/images/products/Resident Evil Village.png",
                    Price = 3999,
                    Brand = "Capcom",
                    Type = "Game",
                    Console = "Playstation 5",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Soulstice",
                    Description =
                        "Just a fake description for the project.",
                    Price = 3999,
                    PictureUrl = "/images/products/Soulstice.png",
                    Brand = "Forge Reply",
                    Type = "Game",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Street Fighter 6",
                    Description =
                        "Just a fake description for the project.",
                    Price = 4999,
                    PictureUrl = "/images/products/Street Fighter 6.png",
                    Brand = "Capcom",
                    Type = "Game",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Last of Us part II",
                    Description =
                        "Just a fake description for the project.",
                    Price = 6999,
                    PictureUrl = "/images/products/The Last of Us part II.png",
                    Brand = "Naughty Dog",
                    Type = "Game",
                    Console = "Playstation 4",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "The Last of Us",
                    Description =
                        "Just a fake description for the project.",
                    Price = 6999,
                    PictureUrl = "/images/products/The Last of Us.png",
                    Brand = "Naughty Dog",
                    Type = "Game",
                    Console = "Playstation 4",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Werewolf The Apocalypse - Earthblood",
                    Description =
                        "Just a fake description for the project.",
                    Price = 1999,
                    PictureUrl = "/images/products/Werewolf The Apocalypse - Earthblood.png",
                    Brand = "Cyanide",
                    Type = "Game",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "WWE 2K23",
                    Description =
                        "Just a fake description for the project.",
                    Price = 2999,
                    PictureUrl = "/images/products/WWE 2K23.png",
                    Brand = "Visual Concepts",
                    Type = "Game",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xbox Series X controller black",
                    Description =
                        "Just a fake description for the project.",
                    Price = 2999,
                    PictureUrl = "/images/products/Xbox Series X controller black.png",
                    Brand = "Microsoft",
                    Type = "Controller",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xbox Series X controller white",
                    Description =
                        "Just a fake description for the project.",
                    Price = 2999,
                    PictureUrl = "/images/products/Xbox Series X controller white.png",
                    Brand = "Microsoft",
                    Type = "Controller",
                    Console = "Xbox Series X",
                    QuantityInStock = 100
                },

            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}