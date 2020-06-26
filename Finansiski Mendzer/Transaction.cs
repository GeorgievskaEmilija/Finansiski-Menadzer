using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansiski_Mendzer
{
    public abstract class Transaction
    {
        public DateTime Date { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
        public decimal Amount { get; set; }
        public string Contents { get; set; }

        public Transaction(DateTime date, Account account, Category category, decimal amount, string contents)
        {
            this.Date = date;
            this.Account = account;
            this.Category = category;
            this.Amount = amount;
            this.Contents = contents;
        }

        public Transaction(DateTime date, Account account, Category category)
        {
            this.Date = date;
            this.Account = account;
            this.Category = category;
            this.Amount = 0;
            this.Contents = "";
        }

        public Transaction() { }
        

        public abstract void MakeTransaction();

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Category, Account, Amount, Program.SettingsFrom.currency);
        }

        public abstract string ToCSV();
    }
}
