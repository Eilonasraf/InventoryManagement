# Inventory Management System

This project is a simple console application written in **C#**, designed to manage inventory for a business. It demonstrates basic programming principles and object-oriented programming (OOP) concepts while keeping things straightforward.

As someone with a background in **C++**, this project showcases how I have adapted my knowledge to C#. The focus is on building a functional system that fulfills the requirements while learning and utilizing the basics of the C# ecosystem.

---

## Features

1. **Add Product**: Add a new product to the inventory with ID, name, price, and quantity.
    - **Unique IDs**: Each product must have a unique ID. The program validates this during product addition and prevents duplicates.
    - **Valid Names**: Product names must consist of valid characters (letters, spaces, hyphens, and apostrophes).
2. **Remove Product**: Remove a product by its unique ID.
3. **Update Quantity**: Update the quantity of an existing product.
4. **Calculate Inventory Value**: Compute the total value of all products in the inventory.
5. **Find Product by ID**: Search for a product using its unique ID.
6. **Find Most Expensive Product**: Retrieve the most expensive product in the inventory.
7. **Filter by Price Range**: List all products within a specified price range. Provides feedback if no products match the range or if the minimum price is higher than all available products.

---

## Prerequisites

Before running the project, ensure the following tools are installed:

1. **.NET SDK**: Download and install the .NET SDK from [Microsoft's official site](https://dotnet.microsoft.com/download).
2. **Text Editor/IDE**: Use Visual Studio Code, Visual Studio, or any text editor of your choice.

Verify your .NET installation by running the following command in your terminal:
```bash
> dotnet --version
```
If the installation is successful, this will output the installed .NET SDK version.

---

## Setup Instructions

1. **Clone the Repository**:
   ```bash
   git clone <repository-url>
   cd <repository-folder>
   ```

2. **Restore Dependencies**:
   Inside the project directory, run:
   ```bash
   dotnet restore
   ```

3. **Run the Application**:
   Execute the following command to start the application:
   ```bash
   dotnet run
   ```

---

## Usage Instructions

1. When the program starts, you will see a menu with several options:
   ```
   Inventory Management System:
   1. Add Product
   2. Remove Product
   3. Update Quantity
   4. Calculate Inventory Value
   5. Find Product by ID
   6. Find Most Expensive Product
   7. Filter Products by Price Range
   8. Exit
   ```
2. Enter the corresponding number for the desired action.
3. Follow the prompts to provide the required inputs (e.g., product ID, name, price).

---

## OOP Concepts Demonstrated

The project is structured around basic OOP principles:

1. **Encapsulation**:
   - Product properties (ID, name, price, quantity) are encapsulated in the `Product` class.
   - Inventory operations (add, remove, update, filter) are handled within the `InventoryManager` class.

2. **Abstraction**:
   - The `InventoryManager` class abstracts the logic for managing inventory operations.

3. **Scalability**:
   - Although minimal, the project can be extended to include additional features or functionalities.

4. **Collections**:
   - The program uses a `List<Product>` to store and manipulate inventory data, similar to how `std::vector` works in C++.

5. **Separation of Concerns**:
   - The project uses a clear pattern to separate code into distinct files and namespaces for better organization:
     - `Models` namespace for data structures (e.g., `Product` class).
     - `Services` namespace for business logic (e.g., `InventoryManager` class).
     - `Helpers` namespace for utility methods (e.g., input validation in `InputHelper`).

---

## Adapting C++ Knowledge to C#

This project reflects my transition from C++ to C#. Here are some key differences and adaptations:

1. **Properties vs. Getters/Setters**:
   - In C#, `get` and `set` simplify property access compared to manually writing getters and setters in C++.

2. **Helper Methods for Input Parsing**:
   - C# uses methods like `ParseInput<T>` and `ParseString` to ensure robust and reusable input validation.
   - This approach avoids crashing on invalid inputs (e.g., entering "abc" instead of a number).
   - Name validation ensures product names consist only of valid characters.

3. **Error Handling**:
   - C#'s `try-catch` blocks are similar to modern C++ exception handling.

4. **String Interpolation**:
   - Formatting strings in C# using `$"..."` feels intuitive and cleaner than constructing strings manually in C++.

5. **Default `ToString()` Implementation**:
   - Overriding the `ToString()` method in C# is like overloading the `<<` operator in C++, allowing objects to define their display format.

6. **Project Structure**:
   - Unlike standalone `.cpp` files in C++, C# projects are managed with `.csproj` files that centralize build and dependency configurations.

7. **Namespace Organization**:
   - Namespaces provide logical grouping for code components, improving modularity and readability. Each major functionality is placed in its respective namespace (`Models`, `Services`, `Helpers`).

---

## Conclusion

This project demonstrates how I applied my C++ experience to build a functional inventory management system in C#. It highlights my ability to learn a new programming language, implement clean code structure, and effectively use modern programming practices.