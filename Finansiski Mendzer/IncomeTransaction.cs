using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansiski_Mendzer
{
    public class IncomeTransaction : Transaction
    {
        public IncomeTransaction(DateTime date, Account account, Category category) : base(date, account, category)
        {
        }

        public IncomeTransaction(DateTime date, Account account, Category category, decimal amount, string contents) : base(date, account, category, amount, contents)
        {
        }

        public IncomeTransaction() : base() { }

        public override void MakeTransaction()
        {
            Account.Amount += Amount;
        }

        public override string ToCSV()
        {
            string Result = string.Format("1,{0},{1},{2},{3},{4}\n", Date, Account, Category, Amount, Contents);
            return Result;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
