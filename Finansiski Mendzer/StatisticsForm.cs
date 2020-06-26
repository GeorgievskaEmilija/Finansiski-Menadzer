using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Finansiski_Mendzer
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            transactionComboBox.Items.Add("Income");
            transactionComboBox.Items.Add("Expenses");
            transactionComboBox.SelectedIndex = 0;
            createChart(0);
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

        private void transactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            createChart(transactionComboBox.SelectedIndex);
        }

        public void createChart(int n)
        {
            int[] points;
            chart.Series[0].ChartType = SeriesChartType.Pie;
            if (n == 0)
            {
                int i = 0;
                points = new int[Program.Data.IncomeCategories.Keys.Count];
                foreach (var c in Program.Data.IncomeCategories.Keys) 
                {
                    points[i] = 0;
                    foreach (var t in Program.Data.Transactions)
                    {
                        if (t.Category.Name.Equals(c) && t.Category is IncomeCategory)
                        {
                            points[i] += Convert.ToInt32(t.Amount);
                        }
                    }
                    i++;
                }
                i = 0;
                int count = 0;
                foreach (var c in Program.Data.IncomeCategories.Keys)
                {
                    if (points[i] != 0)
                    {
                        count++;
                    }
                    i++;
                }
                i = 0;
                int[] y = new int[count];
                string[] x = new string[count];
                int j = 0;
                foreach (var c in Program.Data.IncomeCategories.Keys)
                {
                    if (points[i] != 0)
                    {
                        x[j] = c + ": " + points[i].ToString();
                        y[j] = points[i];
                        j++;
                    }
                    i++;
                }
                chart.Series[0].Points.DataBindXY(x, y);
                chart.Legends[0].Enabled = true;
            }
            else
            {
                int i = 0;
                points = new int[Program.Data.ExpensesCategories.Keys.Count];
                foreach (var c in Program.Data.ExpensesCategories.Keys)
                {
                    points[i] = 0;
                    foreach (var t in Program.Data.Transactions)
                    {
                        if (t.Category.Name.Equals(c) && t.Category is ExpensesCategory)
                        {
                            points[i] += Convert.ToInt32(t.Amount);
                        }
                    }
                    i++;
                }
                i = 0;
                int count = 0;
                foreach (var c in Program.Data.ExpensesCategories.Keys)
                {
                    if (points[i] != 0)
                    {
                        count++;
                    }
                    i++;
                }
                i = 0;
                int[] y = new int[count];
                string[] x = new string[count];
                int j = 0;
                foreach (var c in Program.Data.ExpensesCategories.Keys)
                {
                    if (points[i] != 0)
                    {
                        x[j] = c + ": " + points[i].ToString();
                        y[j] = points[i];
                        j++;
                    }
                    i++;
                }
                chart.Series[0].Points.DataBindXY(x, y);
                chart.Legends[0].Enabled = true;
            }
        }
    }
}
