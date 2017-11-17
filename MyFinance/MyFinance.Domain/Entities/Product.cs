using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyFinance.Domain.Entities
{
    public class Product
    {   
        public int ProductId { get; set; }
        [Display(Name = "Production Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage ="Erreur")]
        [MaxLength(50)]
        [MinLength(8)]
        [StringLength(25, ErrorMessage ="Erreur max 25 caractère")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Range(0,Int32.MaxValue)]
        public int Quantity { get; set; }
        [ForeignKey("category")]
        public int? CategoryId { get; set; } //0 ou 1 ==> nullable
        public virtual Category category { get; set; }
        public string Image { get; set; }
        public ICollection<Provider> ProviderList { get; set; }
        public Product()
        {

        }
    }
}
