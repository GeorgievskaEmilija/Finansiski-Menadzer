using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansiski_Mendzer
{
    public class ExpenseTransaction : Transaction
    {
        public ExpenseTransaction(DateTime date, Account account, Category category) : base(date, account, category)
        {
        }

        public ExpenseTransaction(DateTime date, Account account, Category category, decimal amount, string contents) : base(date, account, category, amount, contents)
        {
        }

        public ExpenseTransaction() : base() { }
        public override string ToCSV()
        {
            string Result = string.Format("0,{0},{1},{2},{3},{4}\n", Date, Account, Category, Amount, Contents);
            return Result;
        }
        public override void MakeTransaction() 
        {
            if (Account.Amount - Amount < 0 && !Account.Group.Equals("Card"))
            {
                throw new BadTransactionException();
            }
            else
            {
                Account.Amount -= Amount;
            }
        }
    }
}
