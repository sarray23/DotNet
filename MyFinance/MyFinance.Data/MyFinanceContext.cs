using MyFinance.Data.Configuration;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data
{
    public class MyFinanceContext : DbContext
    {
        public MyFinanceContext() : base("name=MyFinanceDB")
        {
            Database.SetInitializer<MyFinanceContext>(new MyFinanceContextInitializer()); //initialiseur perso
           // Database.SetInitializer<MyFinanceContext>(new CreateDatabaseIfNotExists<MyFinanceContext>()); //initialiseur par defaut

        }
                public DbSet<Product> Products { get; set; }
                public DbSet<Provider> Providers { get; set; }
                public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) //pour activer la configuration
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
   public class MyFinanceContextInitializer : DropCreateDatabaseAlways<MyFinanceContext>
    {
        protected override void Seed(MyFinanceContext context)
        {
            base.Seed(context);
            var listCategorie = new List<Category>() {
                new Category {name="voiture" } ,
                new Category {name="multimedia" }
            };
            context.Categories.AddRange(listCategorie);
            context.SaveChanges();
        }

    }
}
