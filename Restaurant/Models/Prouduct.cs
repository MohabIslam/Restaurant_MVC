using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string ImageUrl { get; set; } = "https://via.placeholder.com/150";


        [ValidateNever]
        public Category? Category { get; set; } // A Product Belongs To A Catrgory , Navigationl Prop
      
        [ValidateNever]
        public ICollection<OrderItem>? OrderItems { get; set; } // A Product Can Be in Many Order Items 
       
        [ValidateNever]
        public ICollection<ProductIngredient>? ProductIngredients { get; set; } // A Product Can Habe Many Ingredient
    }
}