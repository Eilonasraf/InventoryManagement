namespace InventoryManagement.Models
{
    // Represents a single product in the inventory
    public class Product
    {
        public int Id { get; set; } // Unique identifier for the product
        public string Name { get; set; } // Name of the product
        public decimal Price { get; set; } // Price of the product
        public int Quantity { get; set; } // Quantity of the product in stock

        // Constructor to initialize the product's details
        public Product(int id, string name, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Format the product details as a string for display
        public override string ToString()
        {
            //string interpolation
            return $"ID: {Id}, Name: {Name}, Price: {Price:C}, Quantity: {Quantity}";
        }
    }
}