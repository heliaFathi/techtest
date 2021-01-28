namespace TechTest01.Repository.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TechTest01.Domain.Catalog;

    internal sealed class Configuration : DbMigrationsConfiguration<TechTest01.Repository.CatalogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TechTest01.Repository.CatalogContext context)
        {

            context.Products.AddOrUpdate<Product>(p => 
                new { p.Id, p.Name, p.Description, p.Price, p.ImageUrl, p.Slug },
                new Product
                {
                    Name = "Women's Surge Pelham",
                    Description = "Standout style and lightweight comfort make " +
                                            "these the perfect shoe for everyday wear around town.",
                    Price = 200,
                    ImageUrl = "https://thenorthface.com.au/dw/image/v2/BDFS_PRD/on/demandware.static/-/Sites-northface-master-catalog/default/dwa5200051/images/NF0A3UZJ/NF0A3UZJKX7_1.jpg?sw=600&sh=600",
                    Slug = "Casual Footware"

                },
                new Product
                {
                    Name = "WOMEN'S BALLARD LACE II",
                    Description = "Transition through the seasons with a classic leather boot that's comfortable and lightweight for all-day outdoor wear.",
                    Price = 270,
                    ImageUrl = "https://thenorthface.com.au/dw/image/v2/BDFS_PRD/on/demandware.static/-/Sites-northface-master-catalog/default/dw6e61f5a5/images/NF0A2T4O/NF0A2T4OGU6_1.jpg?sw=600&sh=600",
                    Slug = "Casual Footware"

                },
                new Product
                {
                    Name = "WOMEN'S BASE CAMP SLIDE II",
                    Description = "Kick your boots off in style and relax your feet in these comfortable, sporty sliders. Featuring a durable moulded PU footbed and soft, water-friendly strap, these comfortable sandals can be kept on while you cool off in the stream or sea.",
                    Price = 60,
                    ImageUrl = "https://thenorthface.com.au/dw/image/v2/BDFS_PRD/on/demandware.static/-/Sites-northface-master-catalog/default/dw050982fd/images/NF0A3K4B/NF0A3K4BKY4_1.jpg?sw=600&sh=600",
                    Slug = "Casual Footware"

                },
                new Product
                {
                    Name = "WOMEN'S ULTRA ENDURANCE XF",
                    Description = "Built for the most-technical trails, the Ultra Endurance XF trail-running shoe is specifically for athletes seeking max cushioning and lightweight protection.",
                    Price = 220,
                    ImageUrl = "https://thenorthface.com.au/dw/image/v2/BDFS_PRD/on/demandware.static/-/Sites-northface-master-catalog/default/dwfdadd61b/images/NF0A3X1E/NF0A3X1ERRE_1.jpg?sw=600&sh=600",
                    Slug = "Casual Footware"

                });
        }
    }
}
