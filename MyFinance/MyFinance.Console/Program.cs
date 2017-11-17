using MyFinance.Data;
using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFinanceContext MFC = new MyFinanceContext();
            Category cat = new Category { name = "cat1"};

            //MFC.Categories.Add(cat);
            MFC.Products.Add(new Chemical { address = new Address { City = "tunis", StreetAddress = "rue de marseille" }, DateProd=DateTime.Now, Name="prod" , category=new Category { CategoryId = 1, name = "voiture" } });
            MFC.SaveChanges();
        }
    }
}
