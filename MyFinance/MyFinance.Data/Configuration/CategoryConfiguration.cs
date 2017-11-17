using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Configuration
{
    class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("MyCategory");     //Changer le nom dans la BD 
            HasKey(c => c.CategoryId); //renommer l'Id de Category
            Property(x=>x.name).HasMaxLength(50).IsRequired();
        }
    }
}
