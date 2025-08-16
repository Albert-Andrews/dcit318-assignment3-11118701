using System;
using Question1;
using Question2;
using Question3;
using Question4;
using Question5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("====================================");
        Console.WriteLine(" DCIT 318 - Assignment 3 (11118701) ");
        Console.WriteLine("====================================");
        Console.WriteLine("Select a Question to Run:");
        Console.WriteLine("1. Finance Management System");
        Console.WriteLine("2. Healthcare System with Generics");
        Console.WriteLine("3. Warehouse Inventory Management");
        Console.WriteLine("4. Grading System with File I/O");
        Console.WriteLine("5. Inventory Records with Persistence");
        Console.Write("Enter choice (1-5): ");

        var choice = Console.ReadLine();

        Console.WriteLine(); // spacing

        switch (choice)
        {
            case "1":
                new FinanceApp().Run();
                break;
            case "2":
                new HealthSystemApp().Run();
                break;
            case "3":
                new WareHouseManager().Run();
                break;
            case "4":
                new StudentResultProcessor().Run();
                break;
            case "5":
                new InventoryApp().Run();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1–5.");
                break;
        }

        Console.WriteLine("\n=== Program Finished ===");
    }
}
