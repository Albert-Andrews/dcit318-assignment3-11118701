using System;

namespace Question3
{
    public class WareHouseManager
    {
        private readonly InventoryRepository<ElectronicItem> electronics = new();
        private readonly InventoryRepository<GroceryItem> groceries = new();

        public void SeedData()
        {
            electronics.AddItem(new ElectronicItem(1, "Smartphone", 10, "Xelux", 24));
            electronics.AddItem(new ElectronicItem(2, "Laptop", 5, "ProTek", 12));
            electronics.AddItem(new ElectronicItem(3, "Headphones", 20, "Soundly", 6));

            groceries.AddItem(new GroceryItem(101, "Rice 5kg", 15, DateTime.Today.AddMonths(12)));
            groceries.AddItem(new GroceryItem(102, "Milk 1L", 30, DateTime.Today.AddDays(10)));
            groceries.AddItem(new GroceryItem(103, "Eggs (Dozen)", 25, DateTime.Today.AddDays(14)));
        }

        public void PrintAllItems()
        {
            Console.WriteLine("--- Electronics ---");
            foreach (var e in electronics.GetAllItems())
                Console.WriteLine(e);

            Console.WriteLine("\n--- Groceries ---");
            foreach (var g in groceries.GetAllItems())
                Console.WriteLine(g);
        }

        public void DemoExceptions()
        {
            try
            {
                electronics.AddItem(new ElectronicItem(1, "Duplicate Phone", 1, "Xelux", 12));
            }
            catch (Exception ex) { Console.WriteLine("[Error] " + ex.Message); }

            try
            {
                groceries.RemoveItem(999);
            }
            catch (Exception ex) { Console.WriteLine("[Error] " + ex.Message); }

            try
            {
                electronics.UpdateQuantity(2, -5);
            }
            catch (Exception ex) { Console.WriteLine("[Error] " + ex.Message); }
        }

        public void Run()
        {
            SeedData();
            PrintAllItems();
            Console.WriteLine("\n--- Exception Demo ---");
            DemoExceptions();
        }
    }
}
