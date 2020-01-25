using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Entities
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Style { get; set; }
        public string Color { get;set; }
        public string Sku { get; set; }
        [Required]
        public string Title { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
