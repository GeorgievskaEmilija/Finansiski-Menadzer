using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    public partial class TransactionForm : Form
    {
        //Форма каде корисникот детално може да ги гледа трансакциите и да манипулира со нив.

        public TransactionForm()
        {
            InitializeComponent();
            typeComboBox.Items.Add("Daily");
            typeComboBox.Items.Add("Weekly");
            typeComboBox.Items.Add("Monthly");
            typeComboBox.Items.Add("Yearly");
            typeComboBox.SelectedIndex = 0;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            Program.Data.WriteAndUpdate();
        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction();
            Program.TransactionForm.Hide();
            addTransaction.ShowDialog();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Data.WriteAndUpdate();
            Program.StatisticsForm.Show();
        }

        private void accountsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Data.WriteAndUpdate();
            Program.AccountsForm.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Data.WriteAndUpdate();
            Program.SettingsFrom.Show();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Data.WriteAndUpdate();
            Program.TransactionForm.Show();
        }

        public void UpdateValues()
        {
            Program.Data.UpdateValues();
            incomeLabel.Text = Program.Data.Income.ToString();
            expensesLabel.Text = Program.Data.Expenses.ToString();
            totalLabel.Text = Program.Data.Total.ToString();
            typeComboBox.SelectedIndex = 0;
            LoadDaily();
        }

        private void transactionsListBox_DoubleClick(object sender, EventArgs e)
        {
            EditTransaction editTransaction = new EditTransaction();
            Transaction t = (Transaction)transactionsListBox.SelectedItem;
            editTransaction.Transaction = t;
            Program.Data.Transactions.Remove(t);
            Account a = Program.Data.Accounts[t.Account.ToString()];
            a.Amount -= t.Amount;
            Program.TransactionForm.Hide();
            editTransaction.ShowDialog();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            transactionsListBox.Items.Clear();
            if (typeComboBox.SelectedIndex == 0)
            {
                LoadDaily();
            }
            else if (typeComboBox.SelectedIndex == 1)
            {
                LoadWeekly();
            }
            else if (typeComboBox.SelectedIndex == 2)
            {
                LoadMonthly();
            }
            else if (typeComboBox.SelectedIndex == 3)
            {
                LoadYearly();
            }
            if (Program.Data.Transactions.Count != 0)
            {
                typesListBox.SelectedIndex = 0;
                LoadTransactions();

            }
        }

        private void LoadTransactions(int n = 0)
        {
            transactionsListBox.Items.Clear();
            if (typeComboBox.SelectedIndex == 0)
            {
                DateTime date = DateTime.Parse(typesListBox.SelectedItem.ToString() + ".2020");
                transactionsListBox.Items.Clear();
                foreach (Transaction item in Program.Data.Transactions)
                {
                    if (item.Date.ToString("MM/dd/yyyy").Equals(date.ToString("MM/dd/yyyy")))
                    {
                        transactionsListBox.Items.Add(item);
                    }
                }
            }
            else if (typeComboBox.SelectedIndex == 1)
            {
                string[] parts = typesListBox.SelectedItem.ToString().Split('~');
                DateTime from = DateTime.Parse(parts[0] + ".2020");
                DateTime to = DateTime.Parse(parts[1] + ".2020");
                foreach (Transaction item in Program.Data.Transactions)
                {
                    if (item.Date.Date <= to.Date && item.Date.Date >= from.Date)
                    {
                        transactionsListBox.Items.Add(item);
                    }
                }
            }
            else if (typeComboBox.SelectedIndex == 2)
            {
                string[] parts = typesListBox.SelectedItem.ToString().Split(' ');
                string month = parts[1];
                foreach (Transaction item in Program.Data.Transactions)
                {
                    if (item.Date.ToString("MM").Equals(month) && item.Date.Year == DateTime.Now.Year)
                    {
                        transactionsListBox.Items.Add(item);
                    }
                }
            }
            else if (typeComboBox.SelectedIndex == 3)
            {
                int year = Convert.ToInt32(typesListBox.SelectedItem.ToString());
                foreach (Transaction item in Program.Data.Transactions)
                {
                    if (item.Date.Year == year)
                    {
                        transactionsListBox.Items.Add(item);
                    }
                }
            }
        }

        private void LoadYearly()
        {
            transactionsListBox.Items.Clear();
            typesListBox.Items.Clear();
            List<int> years = new List<int>();
            foreach (Transaction item in Program.Data.Transactions)
            {
                if (!years.Contains(item.Date.Year))
                {
                    years.Add(item.Date.Year);
                }
            }
            IOrderedEnumerable<int> items = years.OrderByDescending(i => i);
            foreach (int item in items)
            {
                typesListBox.Items.Add(item);
            }
        }

        private void LoadMonthly()
        {
            transactionsListBox.Items.Clear();
            typesListBox.Items.Clear();
            int year = DateTime.Now.Year;
            List<string> months = new List<string>();
            foreach (Transaction item in Program.Data.Transactions)
            {
                if (!months.Contains(item.Date.ToString("MMMM MM")) && item.Date.Year == year)
                {
                    months.Add(item.Date.ToString("MMMM MM"));
                }
            }
            IOrderedEnumerable<string> items = months.OrderByDescending(i => i);
            foreach (string item in items)
            {
                typesListBox.Items.Add(item);
            }
        }

        private void LoadWeekly()
        {
            transactionsListBox.Items.Clear();
            typesListBox.Items.Clear();
            int year = DateTime.Now.Year;
            List<string> weeks = new List<string>();
            IOrderedEnumerable<Transaction> transactions = Program.Data.Transactions.OrderByDescending(i => i.Date);
            foreach (Transaction item in transactions)
            {
                string week = getWeek(item.Date);
                if (!weeks.Contains(week) && item.Date.Year == year)
                {
                    weeks.Add(week);
                }
            }
            foreach (string item in weeks)
            {
                typesListBox.Items.Add(item);
            }
        }

        private string getWeek(DateTime date)
        {
            DayOfWeek day = date.DayOfWeek;
            while (!day.ToString().Equals("Monday"))
            {
                date = date.AddDays(-1);
                day = date.DayOfWeek;
            }
            return date.ToString("dd.MM") + " ~ " + date.AddDays(6).ToString("dd.MM");
        }

        private void LoadDaily()
        {
            transactionsListBox.Items.Clear();
            typesListBox.Items.Clear();
            int year = DateTime.Now.Year;
            List<string> days = new List<string>();
            IOrderedEnumerable<Transaction> transactions = Program.Data.Transactions.OrderByDescending(i => i.Date);
            foreach (Transaction item in transactions)
            {
                string day = item.Date.ToString("dd.MM");
                if (!days.Contains(day) && item.Date.Year == year)
                {
                    days.Add(day);
                }
            }
            foreach (string item in days)
            {
                typesListBox.Items.Add(item);
            }
        }

        private void typesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTransactions(typesListBox.SelectedIndex);
        }
    }
}
