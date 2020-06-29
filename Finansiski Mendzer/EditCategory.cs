using System;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    public partial class EditCategory : Form
    {
        //Форма каде се манипулира со веќе постоечки објект од класата Category

        public EditCategories editCategories;

        public string oldName;

        public EditCategory()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            editCategories.Show();
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {
            Hide();
            editCategories.Show();
        }

        public void loadName()
        {
            nameTextBox.Text = oldName;
        }

        private void EditCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            editCategories.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Equals("") && nameTextBox.Text == null)
            {
                MessageBox.Show("You must give this category a name!");
            }
            else
            {
                Category category;
                if (editCategories.categoriesType)
                {
                    category = new IncomeCategory(nameTextBox.Text);
                    foreach (Transaction item in Program.Data.Transactions)
                    {
                        if (item.Category.Name.Equals(oldName) && item.Category is IncomeCategory)
                        {
                            item.Category = category;
                        }
                    }
                    Program.Data.IncomeCategories.Remove(oldName);
                    Program.Data.IncomeCategories.Add(nameTextBox.Text, category);
                }
                else
                {
                    category = new ExpensesCategory(nameTextBox.Text);
                    foreach (Transaction item in Program.Data.Transactions)
                    {
                        if (item.Category.Name.Equals(oldName) && item.Category is ExpensesCategory)
                        {
                            item.Category = category;
                        }
                    }
                    Program.Data.ExpensesCategories.Remove(oldName);
                    Program.Data.ExpensesCategories.Add(nameTextBox.Text, category);
                }
            }
            Hide();
            editCategories.LoadValues();
            Program.Data.WriteAndUpdate();
            editCategories.Show();
        }
    }
}
