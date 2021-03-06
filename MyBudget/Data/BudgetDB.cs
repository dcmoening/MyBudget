﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MyBudget
{
    public class BudgetDB: DatabaseConnection
    {
        public struct budgetNameAmt
        {
            public string name;
            public decimal amt;
        };

        #region Public Members
        /// <summary>
        /// Returns all items in budget categroy
        /// </summary>
        /// <param name="Categorylst"></param>
        /// <returns></returns>
        public int BudgetTableGetCategory(ref List<string> Categorylst)
        {
            int errNbr = 0;
            //ListViewItem CategorylstvwItem = new ListViewItem();

            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT CategoryName, CategoryAmt FROM table_Budget";
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        while (rdr.Read())
                        { 
                            Categorylst.Add(rdr[0].ToString());
                        }
                        rdr.Close();
                    }
                    else
                    {
                        //TODO add error number for not connecting to database when select all category data from Budget table
                        errNbr = -1;
                    }
                }


            }
            catch (Exception ex)
            {
                //TODO catch exception in updating budget list view.
                errNbr = -1;
            }

            return errNbr;
        }
        /// <summary>
        /// Returns total budgeted income for a specific month in a specific year
        /// </summary>
        /// <param name="rslt"></param>
        /// <returns></returns>
        public int BudgetTableGetTotalIncomeAmtForMonthYear(ref decimal rslt, int monthValue, int yearValue)
        {
            rslt = 0;
            int errNbr = 0;

            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT sum(CategoryAmt) FROM table_Budget WHERE CategoryIsIncome=TRUE AND YEAR(categoryBudgetDate) =?yearValue AND MONTH(categoryBudgetDate) =?monthValue";
                    cmd.Parameters.Add("?yearValue", MySqlDbType.VarChar).Value = yearValue;
                    cmd.Parameters.Add("?monthValue", MySqlDbType.VarChar).Value = monthValue;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        while (rdr.Read())
                        {
                            decimal.TryParse(rdr[0].ToString(),out rslt);
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

        /// <summary>
        /// Returns total budgeted income for the current month
        /// </summary>
        /// <param name="rslt"></param>
        /// <returns></returns>
        public int BudgetTableGetTotalIncomeAmtCurrentMonth(ref decimal rslt)
        {
            rslt = 0;
            int errNbr = 0;
            int monthValue = DateTime.Now.Month;
            int yearValue = DateTime.Now.Year;

            errNbr = BudgetTableGetTotalIncomeAmtForMonthYear(ref rslt, monthValue, yearValue);

            return errNbr;
        }

        /// <summary>
        /// Returns total amount of money budgeted
        /// </summary>
        /// <param name="rslt"></param>
        /// <returns></returns>
        public int BudgetTableGetTotalBudgetAmtYearMonth(ref decimal rslt, int yearValue, int monthValue)
        {
            rslt = 0;
            int errNbr = 0;

            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT sum(CategoryAmt) FROM table_Budget WHERE CategoryIsIncome=FALSE AND YEAR(categoryBudgetDate) =?yearValue AND MONTH(categoryBudgetDate) =?monthValue";
                    cmd.Parameters.Add("?yearValue", MySqlDbType.VarChar).Value = yearValue;
                    cmd.Parameters.Add("?monthValue", MySqlDbType.VarChar).Value = monthValue;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        while (rdr.Read())
                        {
                            decimal.TryParse(rdr[0].ToString(), out rslt);
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
        
        /// <summary>
        /// Returns list of expected income
        /// </summary>
        /// <param name="categorylst"></param>
        /// <returns></returns>
        public int BudgetTableGetIncomeCategoryCurrentMonth(ref List<string> categorylst)
        {
            int errNbr = 0;
            int monthVal = DateTime.Now.Month;
            int yearVal = DateTime.Now.Year;

            errNbr = BudgetTableGetIncomeCategoryYearMonth(ref categorylst, yearVal, monthVal);

            return errNbr;
        }

        public int BudgetTableGetIncomeCategoryYearMonth(ref List<string> Categorylst, int yearValue, int monthValue)
        {
            int errNbr = 0;
            //ListViewItem CategorylstvwItem = new ListViewItem();

            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT CategoryName, CategoryAmt FROM table_Budget WHERE CategoryIsIncome=TRUE AND YEAR(categoryBudgetDate) =?yearValue AND MONTH(categoryBudgetDate) =?monthValue";
                    cmd.Parameters.Add("?yearValue", MySqlDbType.VarChar).Value = yearValue;
                    cmd.Parameters.Add("?monthValue", MySqlDbType.VarChar).Value = monthValue;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        while (rdr.Read())
                        {
                            Categorylst.Add(rdr[0].ToString());
                        }
                        rdr.Close();
                    }
                    else
                    {
                        //TODO add error number for not connecting to database when select all category data from Budget table
                        errNbr = -1;
                    }
                }


            }
            catch (Exception ex)
            {
                //TODO catch exception in updating budget list view.
                errNbr = -1;
            }

            return errNbr;
        }
        /// <summary>
        /// Returns list of expected spent income
        /// </summary>
        /// <param name="Categorylst"></param>
        /// <returns></returns>
        public int BudgetTableGetExpenseCategoryCurrentMonth(ref List<string> Categorylst)
        {
            int errNbr = 0;
            int yearValue = DateTime.Now.Year;
            int monthValue = DateTime.Now.Month;

            BudgetTableGetExpenseCategoryYearMonth(ref Categorylst, yearValue, monthValue);

            return errNbr;
        }

        public int BudgetTableGetExpenseCategoryYearMonth(ref List<string> Categorylst, int yearValue, int monthValue)
        {
            int errNbr = 0;
            //ListViewItem CategorylstvwItem = new ListViewItem();

            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT CategoryName, CategoryAmt FROM table_Budget WHERE CategoryIsIncome=FALSE AND YEAR(categoryBudgetDate) =?yearValue AND MONTH(categoryBudgetDate) =?monthValue";
                    cmd.Parameters.Add("?yearValue", MySqlDbType.VarChar).Value = yearValue;
                    cmd.Parameters.Add("?monthValue", MySqlDbType.VarChar).Value = monthValue;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        while (rdr.Read())
                        {
                            Categorylst.Add(rdr[0].ToString());
                        }
                        rdr.Close();
                    }
                    else
                    {
                        //TODO add error number for not connecting to database when select all category data from Budget table
                        errNbr = -1;
                    }
                }


            }
            catch (Exception ex)
            {
                //TODO catch exception in updating budget list view.
                errNbr = -1;
            }

            return errNbr;
        }
        /// <summary>
        /// Return a list budgetNameAmt type of budget expense names and decimal amounts
        /// </summary>
        /// <param name="Categorylst"></param>
        /// <returns></returns>
        public int BudgetTableGetExpenseCategory(ref List<budgetNameAmt> Categorylst)
        {
            int errNbr = 0;
            //ListViewItem CategorylstvwItem = new ListViewItem();
            
            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT CategoryName, CategoryAmt FROM table_Budget WHERE CategoryIsIncome=FALSE";
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        while (rdr.Read())
                        {
                            budgetNameAmt tmpCategory = new budgetNameAmt();
                            tmpCategory.name = (rdr[0].ToString());
                            decimal.TryParse(rdr[0].ToString(), out tmpCategory.amt);
                        }
                        rdr.Close();
                    }
                    else
                    {
                        //TODO add error number for not connecting to database when select all category data from Budget table
                        errNbr = -1;
                    }
                }


            }
            catch (Exception ex)
            {
                //TODO catch exception in updating budget list view.
                errNbr = -1;
            }

            return errNbr;
        }
        /// <summary>
        /// Determines if the categoryName is an expense or income budget
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public bool BudgetTableIsIncome(string categoryName)
        {
            int errNbr = 0;
            bool val = false;
            string test;
            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT CategoryIsIncome FROM table_Budget WHERE CategoryName=?categoryName";
                    cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    
                    while (rdr.Read())
                    {
                        test = rdr[0].ToString();
                            Boolean.TryParse(test, out val);
                    }
                    rdr.Close();                
                    
                }
                else
                {
                    //TODO add error number for not connecting to database when select all category data from Budget table
                    errNbr = -1;
                }

            }
            catch (Exception ex)
            {
                //TODO catch exception in updating budget list view.
                errNbr = -1;
            }

            return val;
        }
        /// <summary>
        /// Update the amount for a specified category
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="categoryAmtStr"></param>
        /// <param name="categoryIsIncome"></param>
        /// <returns></returns>
        public int BudgetTableModifyCategoryData(string categoryName, string categoryAmtStr, bool categoryIsIncome)
        {
            int errNbr = 0;
            decimal categoryAmtDec = 0;
            DateTime categoryBudgetDate;
            
            //Check if categoryAmtStr is in decimal format
            if (decimal.TryParse(categoryAmtStr, out categoryAmtDec))
            {
                try
                {
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        //Update database
                        cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        categoryBudgetDate = DateTime.Now;
                        cmd.CommandText = "UPDATE table_budget SET CategoryAmt=?categoryAmt, CategoryBudgetDate=?categoryBudgetDate, CategoryIsIncome=?categoryIsIncome WHERE CategoryName=?categoryName";
                        cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                        cmd.Parameters.Add("?categoryAmt", MySqlDbType.Decimal).Value = categoryAmtDec;
                        cmd.Parameters.Add("?categoryBudgetDate", MySqlDbType.DateTime).Value = categoryBudgetDate;
                        cmd.Parameters.Add("?categoryIsIncome", MySqlDbType.Bit).Value = categoryIsIncome;
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        //TODO create error number for tried to open database and connection did not open when modifying data in budget table
                        errNbr = -1;
                    }                       
                
                }
                catch (Exception ex)
                {
                    //TODO create error number for general database error modifying Budget Data
                    errNbr = -1;
                }
            }
            else
            {
                //TODO create error number for budget category amount entered not in decimal formal when modifying data in Budget table
                errNbr = -1;
            }


            return errNbr;
        }
        /// <summary>
        /// Insert category name and ammount into the Budget database
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="categoryAmtStr"></param>
        /// <returns></returns>
        public int BudgetTableAddCategoryData(string categoryName, string categoryAmtStr, bool categoryIsIncome)
        {
            int errNbr = 0;
            decimal categoryAmtDec = 0;
            DateTime categoryBudgetDate;
            //Check if categoryAmtStr is in decimal format
            if (decimal.TryParse(categoryAmtStr, out categoryAmtDec))
            {
                try
                {
                    //Select CategoryName from Budget table.
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        //cmd = new MySqlCommand();
                        //cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM table_Budget WHERE CategoryName = ?categoryName";
                        cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                        
                        //conn.Close();
                    }
                    else
                    {
                        //TODO create error number for tried to open database and connection did not open when adding data to budget table
                        errNbr = -1;
                    }
                    
                    if (errNbr == 0)
                    {
                        MySqlDataReader rdr = cmd.ExecuteReader();

                        //check if budget name has already been created before adding
                        if (!rdr.HasRows)
                        {
                            rdr.Close();
                            //if (conn.State != ConnectionState.Open)
                            //{
                            //    conn.Open();
                            //}
                            cmd = new MySqlCommand();
                            categoryBudgetDate = DateTime.Now;
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO table_budget(CategoryName, CategoryAmt, CategoryBudgetDate,CategoryIsIncome) VALUES(?categoryName, ?categoryAmt, ?categoryBudgetDate, ?categoryIsIncome)";
                            cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                            cmd.Parameters.Add("?categoryAmt", MySqlDbType.Decimal).Value = categoryAmtDec;
                            cmd.Parameters.Add("?categoryBudgetDate", MySqlDbType.DateTime).Value = categoryBudgetDate;
                            cmd.Parameters.Add("?categoryIsIncome", MySqlDbType.Bit).Value = categoryIsIncome;
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            //TODO create error number for when trying to insert new budget data when budget data for that category name already exists.
                            //
                            errNbr = -1;
                        }
                    }                    
                }
                catch (Exception ex)
                {

                    //TODO create error number for general database error adding Budget Data
                    errNbr = -1;
                }
            }
            else
            {
                //TODO create error number for budget category amount entered not in decimal format when adding data to Budget table

                errNbr = -1;
            }

            return errNbr;
        }
        /// <summary>
        /// Delete the category from the Buddget table.
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public int BudgetTableDeleteCategoryName(string categoryName)
        {
            int errNbr = 0;
            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM table_Budget WHERE CategoryName=?categoryName";
                    cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                    cmd.ExecuteNonQuery();

                    //conn.Close();
                    //cmd.Dispose();
                }
                //if (conn.State != ConnectionState.Open)
                //{
                //    conn.Open();
                //}
                
            }
            catch (Exception ex)
            {
                //TODO catch exception in updating budget list view.
                errNbr = -1;
                //errorNotify = new ErrorNotify();
                //errorNotify.errDescription = ex.Message;
                //errorNotify.errLocalDescription = "Error Deleting a Budget";
                //errorNotify.Show();
                //conn.Close();
            }

            return errNbr;
        }

        /// <summary>
        /// Returns a ListViewItem containing the categorys found in the Budget Table
        /// </summary>
        /// <param name="CategorylstvwItem"></param>
        /// <returns></returns>
        public int BudgetTableGetCategoryCurrentMonth(ref ListView categorylstv)
        {
            int errNbr = 0;
            int yearValue = DateTime.Now.Year;
            int monthValue = DateTime.Now.Month;

            errNbr = BudgetTableGetCategoryMonthYear(ref categorylstv, monthValue, yearValue);

            return errNbr;
        }

        public int BudgetTableGetCategoryMonthYear(ref ListView Categorylstv, int monthValue, int yearValue)
        {
            int errNbr = 0;
            ListViewItem CategorylstvwItem = new ListViewItem();

            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT CategoryName, CategoryAmt FROM table_Budget WHERE YEAR(categoryBudgetDate) =?yearValue AND MONTH(categoryBudgetDate) =?monthValue";
                    cmd.Parameters.Add("?yearValue", MySqlDbType.VarChar).Value = yearValue;
                    cmd.Parameters.Add("?monthValue", MySqlDbType.VarChar).Value = monthValue;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        while (rdr.Read())
                        {
                            CategorylstvwItem = new ListViewItem();
                            CategorylstvwItem.SubItems[0].Text = rdr[0].ToString();
                            CategorylstvwItem.SubItems.Add(rdr[1].ToString());
                            Categorylstv.Items.Add(CategorylstvwItem);
                        }
                        rdr.Close();
                    }
                    else
                    {
                        //TODO add error number for not connecting to database when select all category data from Budget table
                        errNbr = -1;
                    }
                }


            }
            catch (Exception ex)
            {
                //TODO catch exception in updating budget list view.
                errNbr = -1;
            }

            return errNbr;
        }

        /// <summary>
        /// Get total amount spent for a budget category for the current month
        /// </summary>
        /// <param name="rslt"></param>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public int BudgetTableGetBudgetAmtForCategory(ref decimal rslt, string categoryName)
        {
            rslt = 0;
            int errNbr = 0;

            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT CategoryAmt FROM table_Budget WHERE CategoryIsIncome = FALSE AND CategoryName = ?categoryName";
                    cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        while (rdr.Read())
                        {
                            decimal.TryParse(rdr[0].ToString(), out rslt);
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

        #endregion
    }
}
