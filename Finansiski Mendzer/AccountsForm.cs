namespace Finansiski_Mendzer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    public partial class AccountsForm : Form
    {
        //Форма каде корисникот може детално да ги разгледа објектите од класата Account и да манипулира со нив.
        public AccountsForm()
        {
            InitializeComponent();
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            Program.Data.WriteAndUpdate();
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Data.WriteAndUpdate();
            Program.TransactionForm.Show();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Data.WriteAndUpdate();
            Program.StatisticsForm.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Data.WriteAndUpdate();
            Program.SettingsFrom.Show();
        }

        public void UpdateValues()
        {
            //Ја ажурира формата со податоците кои се наоѓаат во Data.
            accountsListBox.Items.Clear();
            List<Account> accounts = Program.Data.Accounts.Values.ToList();
            foreach (Account item in accounts)
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
                    Program.Data.WriteAndUpdate();
                    List<Transaction> newTransactionList = new List<Transaction>();
                    foreach (Transaction item in Program.Data.Transactions)
                    {
                        if (!item.Account.Name.Equals(account))
                        {
                            newTransactionList.Add(Program.Data.Transactions.ElementAt(Program.Data.Transactions.IndexOf(item)));
                        }
                    }
                    Program.Data.Transactions = newTransactionList;
                    Program.Data.WriteAndUpdate();
                }
            }
        }

        private void accountsButton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Data.WriteAndUpdate();
            Program.AccountsForm.Show();
        }

        private void AccountsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
