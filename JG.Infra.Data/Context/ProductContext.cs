using JG.Domain.Entities;
using JG.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace JG.Infra.Data.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("FCamaraDBConnection")
        {

        }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            IConvention[] conventions = {
                new PluralizingTableNameConvention(),
                new OneToManyCascadeDeleteConvention(),
                new ManyToManyCascadeDeleteConvention()
            };

            //Remove conventions
            modelBuilder.Conventions.Remove(conventions);

            //string -> varchar
            modelBuilder.Properties<string>().Configure(s => s.HasColumnType("varchar"));

            //Product Configurations
            modelBuilder.Configurations.Add(new ProductConfiguration());
        }

    }
}
