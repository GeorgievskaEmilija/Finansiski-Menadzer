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
    public partial class SettingsFrom : Form
    {
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
            this.Hide();
            Program.StatisticsForm.createChart(0);
            Program.StatisticsForm.Show();
        }

        private void accountsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
