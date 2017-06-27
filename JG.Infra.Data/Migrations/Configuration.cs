namespace JG.Infra.Data.Migrations
{
    using Domain.Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

            context.Product.AddOrUpdate(
              new Product { Name = "Celular Moto X", Description = "Aparelho celular android 2 Geração.", Price = 799 },
              new Product { Name = "Caixa de Som JBL", Description = "", Price = 650 },
              new Product { Name = "iPad Air 2", Description = "iPad Air 2 Apple 4G 64GB Cinza", Price = 3500 }
            );

        }
    }
}
