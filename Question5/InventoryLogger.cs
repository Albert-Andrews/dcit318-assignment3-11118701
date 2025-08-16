using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Question5
{
    public class InventoryLogger<T> where T : IInventoryEntity
    {
        private readonly List<T> _items = new();
        private readonly string _filePath;

        public InventoryLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Add(T item) => _items.Add(item);

        public List<T> GetAll() => new(_items);

        public void SaveToFile()
        {
            try
            {
                var json = JsonSerializer.Serialize(_items, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);
                Console.WriteLine($"Saved {_items.Count} items to {_filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Save Error] " + ex.Message);
            }
        }

        public void LoadFromFile()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    Console.WriteLine("No saved file found.");
                    return;
                }

                var json = File.ReadAllText(_filePath);
                var data = JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
                _items.Clear();
                _items.AddRange(data);

                Console.WriteLine($"Loaded {_items.Count} items from {_filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[Load Error] " + ex.Message);
            }
        }
    }
}
