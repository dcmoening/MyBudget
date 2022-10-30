using MyBudget.Data;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace MyBudget
{
    static class Program
    {
        static BudgetDataModel budgetData;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            budgetData = LoadBudgetData();
            Application.Run(new MainForm(budgetData));
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        static BudgetDataModel LoadBudgetData()
        {
            // Get this month and year
            string thisYear = DateTime.Now.Year.ToString();
            string thisMonth = DateTime.Now.Month.ToString();
            string thisMonthJson = thisYear + "\\" + thisMonth + ".json";
            BudgetDataModel budgetDataModel;

            if (File.Exists(thisMonthJson))
            {
                budgetDataModel = JsonSerializer.Deserialize<BudgetDataModel>(thisMonthJson);
            }
            else
            {
                // File will be created in the future
                budgetDataModel = new BudgetDataModel();
            }

            return budgetDataModel;
        }
    }
}
