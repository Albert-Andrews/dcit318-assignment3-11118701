using System;

namespace Question1
{
    public class MobileMoneyProcessor : ITransactionProcessor
    {
        public void Process(Transaction t) =>
            Console.WriteLine($"[MobileMoney] Processing {t.Amount:C} for '{t.Category}' on {t.Date:d}");
    }
}
