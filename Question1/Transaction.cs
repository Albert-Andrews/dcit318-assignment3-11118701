using System;

namespace Question1
{
    // Record struct for transactions
    public readonly record struct Transaction(int Id, DateTime Date, decimal Amount, string Category);
}
