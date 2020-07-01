using System;
using System.IO;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    public partial class SettingsFrom : Form
    {
        //Форма каде корисникот може да манипулира со поставките.

        public string currency;
        public SettingsFrom()
        {
            InitializeComponent();
            currencyComboBox.Items.Add("MKD, Македонски Денар");
            currencyComboBox.Items.Add("USD, American Dollar");
            currencyComboBox.Items.Add("EUR, Euro");
            currencyComboBox.SelectedIndex = 0;
            currency = currencyComboBox.SelectedItem.ToString().Substring(0, 3);
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

        private void addIncomeButton_Click(object sender, EventArgs e)
        {
            if (incomeTextBox.Text != null && incomeTextBox.Text != "")
            {
                Program.Data.IncomeCategories.Add(incomeTextBox.Text, new IncomeCategory(incomeTextBox.Text));
                MessageBox.Show("Succesfully added the category: " + incomeTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please enter a name for the income category!");
            }
            incomeTextBox.Text = "";
        }

        private void expenseAddButton_Click(object sender, EventArgs e)
        {
            if (expenseTextBox.Text != null && expenseTextBox.Text != "")
            {
                Program.Data.ExpensesCategories.Add(expenseTextBox.Text, new ExpensesCategory(expenseTextBox.Text));
                MessageBox.Show("Succesfully added the category: " + expenseTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please enter a name for the expenses category!");
            }
            expenseTextBox.Text = "";
        }

        private void csvButton_Click(object sender, EventArgs e)
        {
            if (Program.Data.saveToDesktop())
            {
                MessageBox.Show("CSV file saved to Desktop!");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void currencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency = currencyComboBox.SelectedItem.ToString().Substring(0, 3);
        }

        private void editIncomeButton_Click(object sender, EventArgs e)
        {
            EditCategories editCategories = new EditCategories
            {
                categoriesType = true
            };
            editCategories.LoadValues();
            editCategories.Show();
            Hide();
        }

        private void SettingsFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void editExpenseButton_Click(object sender, EventArgs e)
        {
            EditCategories editCategories = new EditCategories
            {
                categoriesType = false
            };
            editCategories.LoadValues();
            editCategories.Show();
            Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete all data?", "Delete data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(Program.Data.FilePath);
                Program.Data = new Data();
                MessageBox.Show("Data successfully deleted! The application will restart!");
                Application.Restart();
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For correctly and best working application, please do this next steps:\n"
                    + "1. Go in Accounts Form and add one or more desired accounts.\n"
                    + "2. Go in Settings Form and add one or more desired income and expense categories.\n");
        }
    }
}
