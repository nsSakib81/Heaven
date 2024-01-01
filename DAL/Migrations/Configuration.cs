namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for(int i=1; i <= 10; i++)
            {
                context.Sellers.AddOrUpdate(new Models.Seller
                {
                    Name = Guid.NewGuid().ToString().Substring(0, 15),
                    Sname = "Seller-" + i,
                    Password= Guid.NewGuid().ToString().Substring(0,10),
                    Type= "General-Seller"
                }) ;
            }
            Random random = new Random();
            for(int i=1; i<=20; i++)
            {
                context.Products.AddOrUpdate(new Models.Product
                {
                    id = i,
                    Title = Guid.NewGuid().ToString().Substring(0, 8),
                    Details = Guid.NewGuid().ToString(),
                    Prize = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    PostedBy = "Seller-" + random.Next(1, 11)
                }) ;
            }
            for(int i=1; i<=100; i++)
            {
                context.BuyerComments.AddOrUpdate(new Models.BuyerComment
                {
                    id=i,
                    BuyerReview=Guid.NewGuid().ToString().Substring(0,15),
                    PId=random.Next(1,21),
                    Time=DateTime.Now,
                    ReviewedBy="Seller-"+random.Next(1,11)
                });
            }
        }
    }
}
