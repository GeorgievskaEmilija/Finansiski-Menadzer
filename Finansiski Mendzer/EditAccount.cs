using System;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    public partial class EditAccount : Form
    {
        //Форма каде се манипулира со веќе постоечки објект од класата Account

        public Account account;
        public EditAccount()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                AddingAccount();
            }

        }

        private void AddingAccount()
        {
            Program.AccountsForm.Hide();
            Group group = (Group)groupComboBox.SelectedItem;
            string name = nameTextBox.Text;
            decimal amount;
            if (amountTextBox.Text != "" && amountTextBox.Text != null)
            {
                amount = Convert.ToDecimal(amountTextBox.Text);
            }
            else
            {
                amount = 0;
            }
            account = new Account(group, name, amount);
            Program.Data.Accounts.Add(account.ToString(), account);
            Program.AccountsForm.Show();
            Program.Data.WriteAndUpdate();
            Close();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            LoadLists();
        }

        private void LoadLists()
        {
            foreach (string s in Program.Data.Groups.Keys)
            {
                groupComboBox.Items.Add(Program.Data.Groups[s]);
            }
        }

        private bool ValidateData()
        {
            if (groupComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select specific group");
                return true;
            }
            return false;
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            LoadLists();
            groupComboBox.SelectedItem = account.Group;
            nameTextBox.Text = account.Name;
            amountTextBox.Text = account.Amount.ToString();
        }

        private void EditAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.AccountsForm.Show();
        }
    }
}
