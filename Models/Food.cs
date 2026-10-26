using System;
using System.ComponentModel.DataAnnotations;
namespace Online_Food_Ordering_System.Models
{
    public class Food
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(1, 10000)]
        public decimal Price { get; set; }

        public string Category { get; set; }
    }
}
