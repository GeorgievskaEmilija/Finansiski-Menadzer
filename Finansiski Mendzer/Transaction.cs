using System;

namespace Finansiski_Mendzer
{
    public abstract class Transaction
    {
        //Абстрактна класа која претставува трансакција. Од оваа класа наследуваат IncomeTransaction и ExpenseTransaction.
        public DateTime Date { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
        public decimal Amount { get; set; }
        public string Contents { get; set; }

        public Transaction(DateTime date, Account account, Category category, decimal amount, string contents)
        {
            Date = date;
            Account = account;
            Category = category;
            Amount = amount;
            Contents = contents;
        }

        public Transaction(DateTime date, Account account, Category category)
        {
            Date = date;
            Account = account;
            Category = category;
            Amount = 0;
            Contents = "";
        }

        public Transaction() { }

        //Метод кој враќа true доколку оваа трансакција има логика да се изврши.
        public abstract bool MakeTransaction();

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Category, Account, Amount, Program.SettingsFrom.currency);
        }

        //Го враќа објектот во csv формат.
        public abstract string ToCSV();
    }
}
