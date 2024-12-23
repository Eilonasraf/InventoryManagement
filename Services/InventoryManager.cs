using InventoryManagement.Models;
using InventoryManagement.Helpers;

namespace InventoryManagement.Services
{   
    public class InventoryManager
    {
        private List<Product> products = new List<Product>(); // List to store all products
        public void AddProduct(int id, string name, decimal price, int quantity)
        {
            while (true) // Keep prompting until a unique ID is entered
            {
                // Check if a product with the same ID already exists
                bool idExists = false;
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Id == id)
                    {
                        Console.WriteLine($"Invalid: A product with ID {id} already exists. Please enter a new ID.");
                        idExists = true;
                        id = InputHelper.ParseInput<int>("Enter a new ID: "); // Prompt for a new ID
                        break;
                    }
                }

                if (!idExists) break; // Exit the loop if the ID is unique
            }

            // If the ID is unique, add the new product
            products.Add(new Product(id, name, price, quantity));
            Console.WriteLine("Product added successfully:");
            Console.WriteLine(products[^1]); // Display the added product
        }

        // Removes a product from the inventory by its ID
        public void RemoveProduct(int id)
        {
            Product product = null; // Default value

            // Iterate through the list to find the product with the matching ID
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id) // Check the condition
                {
                    product = products[i]; // Assign the matching product
                    break; // Exit the loop as soon as a match is found
                }
            }

            // Check if the product was found
            if (product != null)
            {
                products.Remove(product); // Remove the product from the list
                Console.WriteLine("Product removed.");
            }
            else
            {
                Console.WriteLine("Product not found."); // If no product matches the ID
            }
        }

        // Updates the quantity of a product by its ID
        public void UpdateQuantity(int id, int quantity)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id) // Check if the current product matches the ID
                {
                    products[i].Quantity = quantity; // Update the quantity
                    Console.WriteLine("Quantity updated.");
                    return; // Exit the method after updating
                }
            }

            // If no product with the matching ID is found
            Console.WriteLine("Product not found.");
        }

        // Calculates the total value of the inventory
        public decimal CalculateInventoryValue()
        {
            decimal totalValue = 0; // Initialize total value

            for (int i = 0; i < products.Count; i++)
            {
                totalValue += products[i].Price * products[i].Quantity; // Add the product's value to the total
            }
            return totalValue; // Return the total value
        }

        // Finds a product in the inventory by its ID
        public Product FindProductById(int id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id) // Check if the current product's ID matches the input ID
                {
                    return products[i]; // Return the matching product immediately
                }
            }

            // If no product is found, return null
            return null;
        }

        // Finds the most expensive product in the inventory
        public List<Product> FindMostExpensiveProducts()
        {
            List<Product> mostExpensiveProducts = new List<Product>();
            if (products.Count == 0)
            {
                return mostExpensiveProducts; // Return an empty list if there are no products
            }
            decimal maxPrice = 0;
            // Find the maximum price
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price > maxPrice)
                {
                    maxPrice = products[i].Price;
                }
            }
            // Collect all products with the maximum price
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price == maxPrice)
                {
                    mostExpensiveProducts.Add(products[i]);
                }
            }
            return mostExpensiveProducts;
        }

        // Filters products within a specified price range
        public List<Product> FilterProductsByPriceRange(decimal min, decimal max)
        {
            List<Product> filteredProducts = new List<Product>(); // Create a new list to store the results

            // Iterate through the list of products
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price >= min && products[i].Price <= max) // Check if the product's price is within the range
                {
                    filteredProducts.Add(products[i]); // Add the product to the result list
                }
            }

            // Check if no products were found within the range
            if (filteredProducts.Count == 0)
            {
                // Determine if the minimum price is greater than all products
                decimal highestPrice = 0;
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Price > highestPrice)
                    {
                        highestPrice = products[i].Price;
                    }
                }

                if (min > highestPrice)
                {
                    Console.WriteLine("Sorry, the minimum price is too high. No products match the specified range.");
                }
                else
                {
                    Console.WriteLine("Sorry, no products match the specified range.");
                }
            }

            return filteredProducts; // Return the list of filtered products
        }
    
    }
}