using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExam
{
    public class BankAccount:BankAccountManager, ILogger
    {
        public decimal Number { get;  }
        public string Owner { get;  }
        public readonly decimal minumumBalance;
        private static int accountNumberSeed = 1234567890;
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransaction)
                {
                    balance += item.Amount;
                }
                return balance;
            }

            set { }
        }
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransaction)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{Balance}\t{item.Note}");
            }
            return report.ToString();
        }
        public BankAccount(string name,decimal initialBalance,decimal minimumBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "initial Balance");
        }
        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }
    }
}
