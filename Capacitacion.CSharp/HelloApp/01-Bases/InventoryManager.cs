partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Laptop", "Smartphone", "Tablet", "Monitor", "Keyboard"];
        int[] stock = [10, 25, 15, 8, 30];
        double[] prices = [999.99, 499.99, 299.99, 199.99, 49.99];

        WriteLine("Inventory Management System");
        WriteLine("-------------------------------------------------");
        WriteLine("Press 1 to view inventory\nPress 2 to buy a product\nPress 3 to exit\n");

        if (!int.TryParse(ReadLine(), out int choice) || choice < 1 || choice > 3)
        {
            WriteLine("Invalid choice. Please select a valid option (1-3).");
            return;
        }
        if (choice == 1)
        {
            WriteLine("\nInventory List:");
            WriteLine("-------------------------------------------------");
            for (int i = 0; i < products.Length; i++)
            {
                WriteLine($"{products[i]} | Stock: {stock[i]} | Price: ${prices[i]:F2}");
            }
            WriteLine("-------------------------------------------------\n");
            InventoryManager();
        }
        else if (choice == 2)
        {
            WriteLine("\nSelect a product for buying:\n");
            string? searchedProduct = ReadLine();
            if (products.Any(p => p.Equals(searchedProduct, StringComparison.OrdinalIgnoreCase)))
            {
                WriteLine("\nEnter the quantity to buy:\n");
                int quantityInput = int.Parse(ReadLine()!);
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                    {
                        if (quantityInput <= stock[i])
                        {
                            double totalPrice = quantityInput * prices[i];
                            stock[i] -= quantityInput;
                            WriteLine($"\nYou bought {quantityInput} {products[i]}(s) for a total of ${totalPrice:F2}. Remaining stock: {stock[i]}\n");
                            InventoryManager();
                        }
                        else
                        {
                            WriteLine($"\nInsufficient stock for {products[i]}. Available stock: {stock[i]}\n");
                        }
                    }
                }
            }
            else
            {
                WriteLine($"\nProduct '{searchedProduct}' found in inventory.\n");
                InventoryManager();
            }
        }
        else
        {
            WriteLine("\nExiting the program. Thank you!\n");
        }
    }
}