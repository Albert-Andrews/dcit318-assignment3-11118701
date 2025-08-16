using System;

namespace Question1
{
    public class CryptoWalletProcessor : ITransactionProcessor
    {
        public void Process(Transaction t) =>
            Console.WriteLine($"[CryptoWallet] Processing {t.Amount:C} for '{t.Category}' on {t.Date:d}");
    }
}
