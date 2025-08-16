using System;

namespace Question5
{
    // Immutable record implementing IInventoryEntity
    public record InventoryItem(int Id, string Name, int Quantity, DateTime DateAdded) : IInventoryEntity;
}
