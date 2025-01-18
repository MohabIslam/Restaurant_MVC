using System.ComponentModel;

namespace Restaurant.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; } // Forgin Key Prop
        public Category? MyProperty { get; set; } // A Product Belongs To A Catrgory , Navigationl Prop
        public ICollection<OrderItem>? OrderItems { get; set; } // A Product Can Be in Many Order Items 
        public ICollection<ProductIngredient>? ProductIngredients { get; set; } // A Product Can Habe Many Ingredient
    }
}