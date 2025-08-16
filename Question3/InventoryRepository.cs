using System.Collections.Generic;

namespace Question3
{
    public class InventoryRepository<T> where T : IInventoryItem
    {
        private readonly Dictionary<int, T> items = new();

        public void AddItem(T item)
        {
            if (items.ContainsKey(item.Id))
                throw new DuplicateItemException($"Item with ID {item.Id} already exists.");
            items[item.Id] = item;
        }

        public T GetItemById(int id)
        {
            if (!items.ContainsKey(id))
                throw new ItemNotFoundException($"Item with ID {id} not found.");
            return items[id];
        }

        public void RemoveItem(int id)
        {
            if (!items.Remove(id))
                throw new ItemNotFoundException($"Item with ID {id} not found.");
        }

        public List<T> GetAllItems() => new(items.Values);

        public void UpdateQuantity(int id, int newQuantity)
        {
            if (newQuantity < 0)
                throw new InvalidQuantityException("Quantity cannot be negative.");
            var item = GetItemById(id);
            item.Quantity = newQuantity;
        }
    }
}
