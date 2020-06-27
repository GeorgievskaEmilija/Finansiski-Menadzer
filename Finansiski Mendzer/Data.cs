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
 /*IncomeCategories.Add("Dad", new IncomeCategory("Dad"));
IncomeCategories.Add("Grandma", new IncomeCategory("Grandma"));
IncomeCategories.Add("Last Month", new IncomeCategory("Last Month"));
IncomeCategories.Add("Other", new IncomeCategory("Other"));
ExpensesCategories.Add("Rent", new ExpensesCategory("Rent"));
ExpensesCategories.Add("Bills", new ExpensesCategory("Bills"));
ExpensesCategories.Add("Groceries", new ExpensesCategory("Groceries"));
ExpensesCategories.Add("Personal", new ExpensesCategory("Personal"));
ExpensesCategories.Add("Food", new ExpensesCategory("Food"));
ExpensesCategories.Add("Transportation", new ExpensesCategory("Transportation"));
ExpensesCategories.Add("Other", new ExpensesCategory("Other"));
Accounts.Add("Cash", new Account(Groups["Cash"], "Cash", 0));
Accounts.Add("Card", new Account(Groups["Debit Card"], "Card", 0));
Transactions.Add(new IncomeTransaction(new DateTime(), Accounts["Cash"], IncomeCategories["Dad"], 100, "glup,jazik"));*/
            FilePath = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            FilePath = FilePath.Substring(0, FilePath.Length - 3) + "data.csv";
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }
            else
            {
                //File.WriteAllText(FilePath, ToCSV());
                GetFromCSV(FilePath);
            }
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

        public string ToCSV()
        {
            string Result = "";
            Result += string.Format("{0},{1},{2}\n", Income, Expenses, Total);
            Result += string.Format("Categories:\n");
            foreach (string s in IncomeCategories.Keys)
            {
                Result += string.Format("{0}", IncomeCategories[s].ToCSV());
            }
            foreach (string s in ExpensesCategories.Keys)
            {
                Result += string.Format("{0}", ExpensesCategories[s].ToCSV());
            }
            Result += string.Format("Accounts:\n");
            foreach (string s in Accounts.Keys)
            {
                Result += string.Format("{0}", Accounts[s].ToCSV());
            }
            Result += string.Format("Transactions:\n");
            foreach (Transaction t in Transactions)
            {
                Result += string.Format("{0}", t.ToCSV());
            }
            return Result;
        }

        public void GetFromCSV(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                string type = "";
                string line;
                line = file.ReadLine();
                string[] parts = line.Split(',');
                Income = Convert.ToDecimal(parts[0]);
                Expenses = Convert.ToDecimal(parts[1]);
                Total = Convert.ToDecimal(parts[2]);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Equals("Categories:"))
                    {
                        type = line;
                        continue;
                    }
                    else if (line.Equals("Accounts:"))
                    {
                        type = line;
                        continue;
                    }
                    else if (line.Equals("Transactions:"))
                    {
                        type = line;
                        continue;
                    }
                    if (type.Equals("Categories:"))
                    {
                        if (line[0] == '1')
                        {
                            IncomeCategories.Add(line.Substring(2), new IncomeCategory(line.Substring(2)));
                        }
                        else
                        {
                            ExpensesCategories.Add(line.Substring(2), new ExpensesCategory(line.Substring(2)));
                        }
                    }
                    else if (type.Equals("Accounts:"))
                    {
                        Account a = MakeAccount(line);
                        Accounts.Add(a.Name, a);
                    }
                    else if (type.Equals("Transactions:"))
                    {
                        Transactions.Add(MakeTransaction(line));
                    }
                }
                file.Close();
            }
        }

        public void WriteAndUpdate()
        {
            //ova ke go napram pokasno
            ToCSV();
            //GetFromCSV();
        }

        public Account MakeAccount(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            Account account = new Account();
            if (Groups.ContainsKey(parts[0]))
            {
                account.Group = Groups[parts[0]];
                account.Name = parts[1];
                account.Amount = Convert.ToDecimal(parts[2]);
            }
            return account;
        }

        public Transaction MakeTransaction(string csvLine)
        {
            Transaction t;
            if (csvLine[0] == '1')
            {
                t = new IncomeTransaction();
            }
            else
            {
                t = new ExpenseTransaction();
            }
            csvLine = csvLine.Substring(2);
            string[] parts = csvLine.Split(',');
            if (Accounts.ContainsKey(parts[1]) && (IncomeCategories.ContainsKey(parts[2]) || ExpensesCategories.ContainsKey(parts[2])))
            {
                t.Date = DateTime.Parse(parts[0]);
                t.Account = Accounts[parts[1]];
                if (IncomeCategories.ContainsKey(parts[2]))
                {
                    t.Category = IncomeCategories[parts[2]];
                }
                else
                {
                    t.Category = ExpensesCategories[parts[2]];
                }
                t.Amount = Convert.ToDecimal(parts[3]);
                t.Contents = "";
                for (int i = 4; i < parts.Length; i++)
                {
                    if (i == parts.Length - 1)
                    {
                        t.Contents += string.Format("{0}", parts[i]);
                    }
                    else
                    {
                        t.Contents += string.Format("{0},", parts[i]);
                    }

                }
            }
            return t;
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
