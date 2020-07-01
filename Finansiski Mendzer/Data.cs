using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    public class Data
    {
        //Објект Data во кој се чуваат сите податоци кои корисникот ги внесува

        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Dictionary<string, Account> Accounts { get; set; }
        public Dictionary<string, Category> IncomeCategories { get; set; }
        public Dictionary<string, Category> ExpensesCategories { get; set; }
        public Dictionary<string, Group> Groups { get; set; }
        public string FilePath { get; set; }
        public bool firstTimeUsing;
        public Data()
        {
            Income = 0;
            Expenses = 0;
            Total = 0;
            Groups = new Dictionary<string, Group>
            {
                { "Accounts", new Group("Accounts") },
                { "Cash", new Group("Cash") },
                { "Card", new Group("Card") },
                { "Debit Card", new Group("Debit Card") },
                { "Savings", new Group("Savings") },
                { "Investments", new Group("Investments") },
                { "Loan", new Group("Loan") },
                { "Insurance", new Group("Insurance") }
            };
            Transactions = new List<Transaction>();
            Accounts = new Dictionary<string, Account>();
            IncomeCategories = new Dictionary<string, Category>();
            ExpensesCategories = new Dictionary<string, Category>();
            FilePath = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            FilePath = FilePath.Substring(0, FilePath.Length - 3) + "data.csv";
            if (!File.Exists(FilePath))
            {
                using (File.Create(FilePath));
                firstTimeUsing = true;
            }
            else
            {
                GetFromCSV(FilePath);
                firstTimeUsing = false;
            }
        }


        public void AddTransaction(Transaction transaction)
        {
            //Се додава трансакција, се користи во формите EditTransaction и AddTransaction
            Transactions.Add(transaction);
            UpdateValues();
        }

        public void UpdateValues()
        {
            //Ги ажурира вредностите во објектот.
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
            //Враќа стринг објект од сите податоци во овој објект.
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
            //Чита податоци од csv фајл и запишува во овој објект.
            using (StreamReader file = new StreamReader(path))
            {
                string type = "";
                string line;
                line = file.ReadLine();
                if (line == null)
                {
                    return;
                }
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
            //Ги запишува моменталните вредности во csv фајлот и ги ажурира вредностите во целата форма.
            File.WriteAllText(FilePath, ToCSV());
            Program.TransactionForm.UpdateValues();
            Program.StatisticsForm.createChart(0);
            Program.AccountsForm.UpdateValues();
            UpdateValues();
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
            //Прави копија на csv фајлот на десктоп.
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string finalPath = System.IO.Path.Combine(desktopPath, "data.csv");
            try
            {
                System.IO.File.Copy(FilePath, finalPath, true);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
