using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    public class Data
    {
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Dictionary<string, Account> Accounts { get; set; }
        public Dictionary<string, Category> IncomeCategories { get; set; }
        public Dictionary<string, Category> ExpensesCategories { get; set; }
        public Dictionary<string, Group> Groups { get; set; }
        public string FilePath { get; set; }
        public Data()
        {
            Income = 0;
            Expenses = 0;
            Total = 0;
            Groups = new Dictionary<string, Group>();
            Groups.Add("Accounts", new Group("Accounts"));
            Groups.Add("Cash", new Group("Cash"));
            Groups.Add("Card", new Group("Card"));
            Groups.Add("Debit Card", new Group("Debit Card"));
            Groups.Add("Savings", new Group("Savings"));
            Groups.Add("Investments", new Group("Investments"));
            Groups.Add("Loan", new Group("Loan"));
            Groups.Add("Insurance", new Group("Insurance"));
            Transactions = new List<Transaction>();
            Accounts = new Dictionary<string, Account>();
            IncomeCategories = new Dictionary<string, Category>();
            ExpensesCategories = new Dictionary<string, Category>();
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            UpdateValues();
        }

        public void UpdateValues()
        {
            Income = 0;
            Expenses = 0;
            Total = 0;
            foreach (Transaction t in Transactions)
            {
                if (t is IncomeTransaction)
                {
                    Income += t.Amount;
                }
                else if (t is ExpenseTransaction)
                {
                    Expenses += t.Amount;
                }
            }
            Total = Income - Expenses;
        }

        

        public bool saveToDesktop()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string finalPath = System.IO.Path.Combine(desktopPath, "data.csv");
            try
            {
                System.IO.File.Copy(FilePath, finalPath, true);
            }
            catch (Exception e)
            {
                string text = e.Message;
                return false;
                
            }
            return true;
        }
    }
}
