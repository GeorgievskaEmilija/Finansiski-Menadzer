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
            Application.Run(TransactionForm);
        }
    }
}
