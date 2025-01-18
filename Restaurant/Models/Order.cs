using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Security.Principal;

namespace Restaurant.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string? UserId { get; set; } // This link for Navigationl by Id
        public ApplicationUser User { get; set; } // 
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem> OrderItems{ get; set; }
    }
}