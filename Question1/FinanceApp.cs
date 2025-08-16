using System;

namespace Question1
{
    public class FinanceApp
    {
        public void Run()
        {
            var account = new SavingsAccount("SA-001", 1000m);

            var t1 = new Transaction(1, DateTime.Today, 120m, "Groceries");
            var t2 = new Transaction(2, DateTime.Today, 300m, "Utilities");
            var t3 = new Transaction(3, DateTime.Today, 200m, "Entertainment");

            ITransactionProcessor p1 = new MobileMoneyProcessor();
            ITransactionProcessor p2 = new BankTransferProcessor();
            ITransactionProcessor p3 = new CryptoWalletProcessor();

            p1.Process(t1);
            account.ApplyTransaction(t1);

            p2.Process(t2);
            account.ApplyTransaction(t2);

            p3.Process(t3);
            account.ApplyTransaction(t3);

            Console.WriteLine($"\nFinal Balance for {account.AccountNumber}: {account.Balance:C}");
        }
    }
}
