using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    public partial class EditCategories : Form
    {
        //Форма каде се манипулира со веќе постоечките објекти од класата Category

        public bool categoriesType;
        public EditCategories()
        {
            InitializeComponent();
        }

        private void EditCategories_Load(object sender, EventArgs e)
        {

        }

        private void EditCategories_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SettingsFrom.Show();
        }

        public void LoadValues()
        {
            categoriesListBox.Items.Clear();
            if (categoriesType)
            {
                List<Category> incomeCategories = Program.Data.IncomeCategories.Values.ToList();
                foreach (Category item in incomeCategories)
                {
                    categoriesListBox.Items.Add(item.Name);
                }
            }
            else
            {
                List<Category> expensesCategories = Program.Data.ExpensesCategories.Values.ToList();
                foreach (Category item in expensesCategories)
                {
                    categoriesListBox.Items.Add(item.Name);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (categoriesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category from the list you want to edit!");
            }
            else
            {
                EditCategory edit = new EditCategory
                {
                    oldName = (string)categoriesListBox.SelectedItem,
                    editCategories = this
                };
                edit.loadName();
                edit.Show();
                Hide();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (categoriesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category from the list you want to delete!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this category?", "Delete category", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string category = (string)categoriesListBox.SelectedItem;
                    List<Transaction> newTransactionList = new List<Transaction>();
                    foreach (Transaction item in Program.Data.Transactions)
                    {
                        if (!item.Category.Name.Equals(category))
                        {
                            newTransactionList.Add(Program.Data.Transactions.ElementAt(Program.Data.Transactions.IndexOf(item)));
                        }
                    }
                    if (categoriesType)
                    {
                        Program.Data.IncomeCategories.Remove(category);
                    }
                    else
                    {
                        Program.Data.ExpensesCategories.Remove(category);
                    }
                    LoadValues();
                    Program.Data.Transactions = newTransactionList;
                    Program.Data.WriteAndUpdate();
                }
            }
        }
    }
}
