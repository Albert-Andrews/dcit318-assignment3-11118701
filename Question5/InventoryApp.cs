using System;

namespace Question5
{
    public class InventoryApp
    {
        private readonly InventoryLogger<InventoryItem> logger = new("Question5/inventory_data.json");

        public void SeedSampleData()
        {
            logger.Add(new InventoryItem(1, "Stapler", 12, DateTime.Now));
            logger.Add(new InventoryItem(2, "Printer Paper (500)", 20, DateTime.Now));
            logger.Add(new InventoryItem(3, "Whiteboard Marker", 35, DateTime.Now));
            logger.Add(new InventoryItem(4, "Laptop Stand", 5, DateTime.Now));
            logger.Add(new InventoryItem(5, "USB-C Cable", 18, DateTime.Now));
        }

        public void Run()
        {
            Console.WriteLine("--- Inventory Demo ---");

            SeedSampleData();
            logger.SaveToFile();

            // Simulate loading again
            logger.LoadFromFile();

            foreach (var item in logger.GetAll())
            {
                Console.WriteLine($"#{item.Id}: {item.Name}, Qty={item.Quantity}, Added={item.DateAdded:g}");
            }
        }
    }
}
