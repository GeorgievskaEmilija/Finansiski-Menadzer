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
    public partial class AccountsForm : Form
    {
        public AccountsForm()
        {
            InitializeComponent();
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.TransactionForm.Show();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.StatisticsForm.createChart(0);
            Program.StatisticsForm.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.SettingsFrom.Show();
        }

        public void UpdateValues()
        {
            accountsListBox.Items.Clear();
            var accounts = Program.Data.Accounts.Values.ToList();
            foreach (var item in accounts)
            {
                string text = item.Name;
                accountsListBox.Items.Add(text);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (accountsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the account you want to edit");
            }
            else
            {
                EditAccount editAccount = new EditAccount();
                Account account = Program.Data.Accounts[accountsListBox.SelectedItem.ToString()];
                editAccount.account = account;
                Program.Data.Accounts.Remove(account.Name);
                editAccount.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (accountsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the account you want to delete");
            }
            else
            {
                string account = accountsListBox.SelectedItem.ToString();
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this account?", "Delete account", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.Data.Accounts.Remove(account);
                    Program.Data.UpdateValues();
                    this.UpdateValues();
                    //da gi izbrisham site transakci od ovaj account
                    /*foreach (var item in Program.Data.Transactions)
                    {
                        if (item.Account.Name.Equals(account))
                        {
                            Program.Data.Transactions.Remove(item);
                        }
                    }*/
                    Program.TransactionForm.UpdateValues();
                }
                else if (DialogResult == DialogResult.No)
                {

                }
            }
        }
        private void accountsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.AccountsForm.Show();
        }
    }
}
