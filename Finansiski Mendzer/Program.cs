using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finansiski_Mendzer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static TransactionForm TransactionForm { get; set; }
        public static StatisticsForm StatisticsForm { get; set; }
        public static AccountsForm AccountsForm { get; set; }
        public static SettingsFrom SettingsFrom { get; set; }
        public static Data Data { get; set; }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Data = new Data();
            TransactionForm = new TransactionForm();
            StatisticsForm = new StatisticsForm();
            AccountsForm = new AccountsForm();
            SettingsFrom = new SettingsFrom();
            ///da se napraj promenliva i upatstvo ako prv pat se koristi programata
            Application.Run(TransactionForm);
        }
    }
}
