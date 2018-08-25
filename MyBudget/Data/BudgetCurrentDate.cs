using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/// <summary>
/// Allow modification of data outside of the present month
/// </summary>
namespace MyBudget
{
    public class BudgetCurrentDate : DatabaseConnection
    {
        private static DateTime budgetDate;

        /// <summary>
        /// BudgetDate will contain the year month and always the date of the first of the month
        /// </summary>
        //public static DateTime GetBudgetDate
        //{
        //    get { return budgetDate; }
        //}

        /// <summary>
        /// Get total amount spent for a budget category for the current month
        /// </summary>
        /// <param name="rslt"></param>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public int GetBudgetDate(ref DateTime budgetDate)
        {
            int errNbr = 0;

            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT CurrentDate FROM table_currentdate";
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        while (rdr.Read())
                        {

                            DateTime.TryParse(rdr[0].ToString(), out budgetDate);
                        }
                        rdr.Close();
                    }
                    else
                    {
                        //TODO add error number for not connecting to database when calculating sum of budgeted income
                        errNbr = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO catch exception in updating sum of budgeted income.
                errNbr = -1;
            }

            return errNbr;
        }

        public void SetBudgetToCurrentMonth()
        {
            budgetDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        public void SetBudgetToCustomMonth(int year, int month)
        {
            budgetDate = new DateTime(year, month, 1);
        }

    }
}
