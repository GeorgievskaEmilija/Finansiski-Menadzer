using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction();
            Program.TransactionForm.Hide();
            addTransaction.ShowDialog();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.StatisticsForm.createChart(0);
            Program.StatisticsForm.Show();
            
        }

        private void accountsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.AccountsForm.UpdateValues();
            Program.AccountsForm.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.SettingsFrom.Show();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.TransactionForm.Show();
        }

        public void UpdateValues()
        {
            incomeLabel.Text = Program.Data.Income.ToString();
            expensesLabel.Text = Program.Data.Expenses.ToString();
            totalLabel.Text = Program.Data.Total.ToString();
            //treba da se prepraj
            transactionsListBox.Items.Clear();
            foreach (Transaction t in Program.Data.Transactions)
            {
                transactionsListBox.Items.Add(t);
            }
        }

        private void transactionsListBox_DoubleClick(object sender, EventArgs e)
        {
            //treba da go izbrisham objektot so go pustam od Data listata
            EditTransaction editTransaction = new EditTransaction();
            Transaction t = (Transaction)transactionsListBox.SelectedItem;
            editTransaction.Transaction = t;
            Program.Data.Transactions.Remove(t);
            Account a = Program.Data.Accounts[t.Account.ToString()];
            a.Amount -= t.Amount;
            Program.TransactionForm.Hide();
            editTransaction.ShowDialog();
        }
    }
}
