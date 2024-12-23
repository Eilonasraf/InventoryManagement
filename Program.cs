using InventoryManagement.Models; // For the Product class
using InventoryManagement.Services; // For the InventoryManager class
using InventoryManagement.Helpers; // For helper methods like ParseInput and ParseString

namespace InventoryManagement
{
    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager(); // Create an instance of the inventory manager

            // Loop to display the menu and process user input
            while (true)
            {
                // Display options
                Console.WriteLine("\nInventory Management System:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Update Quantity");
                Console.WriteLine("4. Calculate Inventory Value");
                Console.WriteLine("5. Find Product by ID");
                Console.WriteLine("6. Find Most Expensive Product");
                Console.WriteLine("7. Filter Products by Price Range");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                // Read the user's choice
                string choice = Console.ReadLine();

                try
                {
                    // Match user input to menu options
                    switch (choice)
                    {
                        case "1": // Add a product to the inventory
                            int id = InputHelper.ParseInput<int>("Enter ID: "); // Prompt for ID
                            string name = InputHelper.ParseString("Enter Name: "); // Prompt for name
                            decimal price = InputHelper.ParseInput<decimal>("Enter Price: "); // Prompt for price
                            int quantity = InputHelper.ParseInput<int>("Enter Quantity: "); // Prompt for quantity
                            manager.AddProduct(id, name, price, quantity); // Add product
                            break;

                        case "2": // Remove a product from the inventory
                            id = InputHelper.ParseInput<int>("Enter ID to remove: ");
                            manager.RemoveProduct(id); // Remove product
                            break;

                        case "3": // Update quantity of a product
                            id = InputHelper.ParseInput<int>("Enter ID to update: ");
                            quantity = InputHelper.ParseInput<int>("Enter new Quantity: ");
                            manager.UpdateQuantity(id, quantity); // Update quantity
                            break;

                        case "4": // Calculate the total value of the inventory
                            Console.WriteLine($"Total Inventory Value: {manager.CalculateInventoryValue():C}");
                            break;

                        case "5": // Find a product by its ID
                            id = InputHelper.ParseInput<int>("Enter ID to find: ");
                            var product = manager.FindProductById(id); // Search for product
                            Console.WriteLine(product != null ? product.ToString() : "Product not found.");
                            break;

                        case "6": // Find the most expensive product(s)
                            var expensiveProducts = manager.FindMostExpensiveProducts(); // Get expensive products
                            if (expensiveProducts.Count > 0)
                            {
                                Console.WriteLine("Most expensive products:");
                                foreach (var expensiveProduct in expensiveProducts)
                                {
                                    Console.WriteLine(expensiveProduct);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No products in inventory.");
                            }
                            break;

                        case "7": // Filter products by price range
                            decimal min = InputHelper.ParseInput<decimal>("Enter minimum price: ");
                            decimal max = InputHelper.ParseInput<decimal>("Enter maximum price: ");
                            var filtered = manager.FilterProductsByPriceRange(min, max); // Get filtered list
                            foreach (var p in filtered)
                            {
                                Console.WriteLine(p); // Display filtered products
                            }
                            break;

                        case "8": // Exit the program
                            Console.WriteLine("Exiting...");
                            return;

                        default: // Handle invalid menu choices
                            Console.WriteLine("Invalid choice, try again.");
                            break;
                    }
                }
                catch (Exception ex) // Handle unexpected errors
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}