using System;

namespace Question1
{
    // Sealed class - cannot be inherited
    public sealed class SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber, decimal initialBalance)
            : base(accountNumber, initialBalance) { }

        public override void ApplyTransaction(Transaction transaction)
        {
            if (transaction.Amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            base.ApplyTransaction(transaction);
            Console.WriteLine($"Applied {transaction.Amount:C}. New balance: {Balance:C}");
        }
    }
}
