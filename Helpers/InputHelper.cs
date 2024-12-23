using System;

namespace InventoryManagement.Helpers
{
    public static class InputHelper
    {
        // Helper method to parse and validate input
        public static T ParseInput<T>(string prompt) where T : struct
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                try
                {
                    return (T)Convert.ChangeType(input, typeof(T));
                }
                catch
                {
                    Console.WriteLine($"Invalid input. Please enter a valid {typeof(T).Name}.");
                }
            }
        }

        // Helper method to parse and validate strings
        public static string ParseString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && IsValidName(input))
                {
                    return input;
                }

                Console.WriteLine("Invalid input. Please enter a valid name (letters and spaces only).");
            }
        }

        // Helper method to validate the name
        private static bool IsValidName(string name)
        {
            foreach (char c in name)
            {
                // Allow letters, spaces, and specific special characters
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && c != '-' && c != '\'')
                {
                    return false; // Invalid character found
                }
            }

            return true; // All characters are valid
        }
    }
}