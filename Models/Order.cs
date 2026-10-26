
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Food_Ordering_System.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public int FoodId { get; set; }
        public string FoodName { get; set; }

        public int Quantity { get; set; }
        [Precision(18, 2)]
        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
