using System;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    public partial class EditTransaction : Form
    {

        //Форма каде се манипулира со веќе постоечки објект од класата Transaction.

        public Transaction Transaction { get; set; }

        public EditTransaction()
        {
            InitializeComponent();
        }

        private void LoadLists(string transactionType)
        {
            if (transactionType.Equals("Income"))
            {
                foreach (string s in Program.Data.IncomeCategories.Keys)
                {
                    categoryComboBox.Items.Add(Program.Data.IncomeCategories[s]);
                }
            }
            else if (transactionType.Equals("Expenses"))
            {
                foreach (string s in Program.Data.ExpensesCategories.Keys)
                {
                    categoryComboBox.Items.Add(Program.Data.ExpensesCategories[s]);
                }
            }
        }

        private void incomeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            categoryComboBox.Items.Clear();
            LoadLists("Income");
        }

        private void expensesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            categoryComboBox.Items.Clear();
            LoadLists("Expenses");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                AddingTransaction();
                Close();
                Program.TransactionForm.Show();
            }
        }

        private void AddingTransaction()
        {
            Program.TransactionForm.Hide();
            DateTime dateTime = dateTimePicker.Value;
            Account account = (Account)accountComboBox.SelectedItem;
            Category category = (Category)categoryComboBox.SelectedItem;
            decimal amount;
            if (amountTextBox.Text != "" && amountTextBox.Text != null)
            {
                amount = Convert.ToDecimal(amountTextBox.Text);
            }
            else
            {
                amount = 0;
            }
            string contents = contentsTextBox.Text;
            if (incomeRadioButton.Checked)
            {
                Transaction = new IncomeTransaction(dateTime, account, category, amount, contents);
            }
            else
            {
                Transaction = new ExpenseTransaction(dateTime, account, category, amount, contents);
            }
            if (Transaction.MakeTransaction())
            {
                Program.Data.AddTransaction(Transaction);
                Program.Data.WriteAndUpdate();
            }
            else
            {
                MessageBox.Show("This asset's amount is not possible to be less than zero!");
            }
        }

        private bool ValidateData()
        {
            if (accountComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select specific asset");
                return true;
            }
            if (categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select specific category");
                return true;
            }
            return false;
        }

        private void EditTransaction_Load(object sender, EventArgs e)
        {
            foreach (string s in Program.Data.Accounts.Keys)
            {
                accountComboBox.Items.Add(Program.Data.Accounts[s]);
            }
            if (Transaction is IncomeTransaction)
            {
                LoadLists("Income");
            }
            else if (Transaction is ExpenseTransaction)
            {
                LoadLists("Expenses");
            }
            accountComboBox.SelectedItem = Transaction.Account;
            categoryComboBox.SelectedItem = Transaction.Category;
            amountTextBox.Text = Transaction.Amount.ToString();
            contentsTextBox.Text = Transaction.Contents;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this transaction?", "Delete transaction", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
                Program.TransactionForm.Show();
                Program.Data.WriteAndUpdate();
            }
            else if (DialogResult == DialogResult.No)
            {

            }
        }

        private void EditTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.TransactionForm.Show();
        }
    }
}
