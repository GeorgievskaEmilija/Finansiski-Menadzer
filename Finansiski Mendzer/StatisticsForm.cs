using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Finansiski_Mendzer
{
    //Форма каде корисникот може графички да ги гледа податоците во Data објекотот.

    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            transactionComboBox.Items.Add("Income");
            transactionComboBox.Items.Add("Expenses");
            typeComboBox.Items.Add("This Month");
            typeComboBox.Items.Add("This Week");
            typeComboBox.Items.Add("This Year");
            transactionComboBox.SelectedIndex = 0;
            typeComboBox.SelectedIndex = 0;
            createChart(0);
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

        private void transactionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            createChart(transactionComboBox.SelectedIndex);
        }

        public void createChart(int n, string type = "Month")
        {
            //Се врши креирање на пита графикон, според претходно избраните вредности, од каков тип е и за кои трансакции.
            if (type.Equals("Month"))
            {
                typeComboBox.SelectedIndex = 0;
            }
            List<Transaction> allowedTransaction = new List<Transaction>();
            DateTime now = DateTime.Today;
            if (type.Equals("month") || type.Equals("Month"))
            {
                int month = now.Month;
                int year = now.Year;
                foreach (Transaction item in Program.Data.Transactions)
                {
                    if (item.Date.Year == year && item.Date.Month == month)
                    {
                        allowedTransaction.Add(item);
                    }
                }
            }
            else if (type.Equals("week"))
            {
                DayOfWeek fromDay = now.DayOfWeek;
                DateTime from = now;
                while (!fromDay.ToString().Equals("Monday"))
                {
                    from = from.AddDays(-1);
                    fromDay = from.DayOfWeek;
                }
                DateTime to = from.AddDays(6);
                foreach (Transaction item in Program.Data.Transactions)
                {
                    if (item.Date.Year == now.Year && item.Date.Date >= from.Date && item.Date.Date <= to.Date)
                    {
                        allowedTransaction.Add(item);
                    }
                }
            }
            else
            {
                int year = now.Year;
                foreach (Transaction item in Program.Data.Transactions)
                {
                    if (item.Date.Year == year)
                    {
                        allowedTransaction.Add(item);
                    }
                }
            }
            chart.Series[0].ChartType = SeriesChartType.Pie;
            if (n == 0)
            {
                getChart("income", allowedTransaction);

            }
            else
            {
                getChart("expenses", allowedTransaction);
            }
        }

        private void getChart(string type, List<Transaction> allowedTransaction)
        {
            //x листата се имиња на трансакциите, додека y листата се вредностите соодветно за трансакциите.
            int[] points;
            int i = 0;
            int[] y;
            string[] x;
            if (type.Equals("income"))
            {
                points = new int[Program.Data.IncomeCategories.Keys.Count];
                foreach (string c in Program.Data.IncomeCategories.Keys)
                {
                    points[i] = 0;
                    foreach (Transaction t in allowedTransaction)
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
                foreach (string c in Program.Data.IncomeCategories.Keys)
                {
                    if (points[i] != 0)
                    {
                        count++;
                    }
                    i++;
                }
                i = 0;
                y = new int[count];
                x = new string[count];
                int j = 0;
                foreach (string c in Program.Data.IncomeCategories.Keys)
                {
                    if (points[i] != 0)
                    {
                        x[j] = c + ": " + points[i].ToString();
                        y[j] = points[i];
                        j++;
                    }
                    i++;
                }
            }
            else
            {
                points = new int[Program.Data.ExpensesCategories.Keys.Count];
                foreach (string c in Program.Data.ExpensesCategories.Keys)
                {
                    points[i] = 0;
                    foreach (Transaction t in allowedTransaction)
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
                foreach (string c in Program.Data.ExpensesCategories.Keys)
                {
                    if (points[i] != 0)
                    {
                        count++;
                    }
                    i++;
                }
                i = 0;
                y = new int[count];
                x = new string[count];
                int j = 0;
                foreach (string c in Program.Data.ExpensesCategories.Keys)
                {
                    if (points[i] != 0)
                    {
                        x[j] = c + ": " + points[i].ToString();
                        y[j] = points[i];
                        j++;
                    }
                    i++;
                }
            }
            chart.Series[0].Points.DataBindXY(x, y);
            chart.Legends[0].Enabled = true;
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex == 0)
            {
                createChart(transactionComboBox.SelectedIndex, "month");
            }
            else if (typeComboBox.SelectedIndex == 1)
            {
                createChart(transactionComboBox.SelectedIndex, "week");
            }
            else
            {
                createChart(transactionComboBox.SelectedIndex, "year");
            }
        }
    }
}
