using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entities
{
    public class Provider
    {   //[Key()]
        public int Id { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }
        public ICollection<Product> ProductList { get; set; }
    }
}
