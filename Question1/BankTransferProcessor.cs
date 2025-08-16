using System;

namespace Question1
{
    public class BankTransferProcessor : ITransactionProcessor
    {
        public void Process(Transaction t) =>
            Console.WriteLine($"[BankTransfer] Processing {t.Amount:C} for '{t.Category}' on {t.Date:d}");
    }
}
