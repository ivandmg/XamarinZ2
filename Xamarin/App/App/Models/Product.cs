namespace App.Models
{
    
    public class Product
    {
        
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; }

        public double Price { get; set; }
    }
}

