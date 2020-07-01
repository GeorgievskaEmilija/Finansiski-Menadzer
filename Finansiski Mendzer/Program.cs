using System;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    internal static class Program
    {
        public static TransactionForm TransactionForm { get; set; }
        public static StatisticsForm StatisticsForm { get; set; }
        public static AccountsForm AccountsForm { get; set; }
        public static SettingsFrom SettingsFrom { get; set; }
        public static Data Data { get; set; }
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Data = new Data();
            TransactionForm = new TransactionForm();
            StatisticsForm = new StatisticsForm();
            AccountsForm = new AccountsForm();
            SettingsFrom = new SettingsFrom();
            if (Data.firstTimeUsing)
            {
                MessageBox.Show("For correctly and best working application, please do this next steps:\n" 
                    + "1. Go in Accounts Form and add one or more desired accounts.\n"
                    + "2. Go in Settings Form and add one or more desired income and expense categories.\n"
                    + "If you want help, click on the help button in the Settings Form.\n");
            }
            Application.Run(TransactionForm);
            
        }
    }
}
