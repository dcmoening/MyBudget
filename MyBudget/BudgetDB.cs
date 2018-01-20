using System;
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
    class BudgetDB
    {
        #region fields
            private MySqlConnection conn;
            private MySqlCommand cmd;
            private ErrorNotify errorNotify;
            private String connStr;
        #endregion

        #region Public Members
        public int OpenDBConnection()
        {
            int errNbr = 0;
            try
            {
                connStr = ReturnConnectionString();
                conn = new MySqlConnection(connStr);
                conn.Open();
                cmd = new MySqlCommand();
            }
            catch (Exception ex)
            {
                //TODO add better error catching.
                errNbr = 1;
            }
        return errNbr;
        }

        public void CloseConnection()
        {
            conn.Close();
        }
        public int BudgetTableModifyCategoryData(string categoryName, string categoryAmtStr)
        {
            int errNbr = 0;
            decimal categoryAmtDec = 0;
            DateTime categoryBudgetDate;
            //Check if categoryAmtStr is in decimal format
            if (decimal.TryParse(categoryAmtStr, out categoryAmtDec))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    if (conn.State == ConnectionState.Open)
                    {
                        //Update database
                        cmd = new MySqlCommand();
                        categoryBudgetDate = DateTime.Now;
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE table_budget SET CategoryAmt=?categoryAmt, CategoryBudgetDate=?categoryBudgetDate WHERE CategoryName=?categoryName";
                        cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                        cmd.Parameters.Add("?categoryAmt", MySqlDbType.Decimal).Value = categoryAmtDec;
                        cmd.Parameters.Add("?categoryBudgetDate", MySqlDbType.DateTime).Value = categoryBudgetDate;
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
        public int BudgetTableAddCategoryData(string categoryName, string categoryAmtStr)
        {
            int errNbr = 0;
            decimal categoryAmtDec = 0;
            DateTime categoryBudgetDate;

            //Check if categoryAmtStr is in decimal format
            if (decimal.TryParse(categoryAmtStr, out categoryAmtDec))
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                try
                {
                    //Select CategoryName from Budget table.
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM table_Budget WHERE CategoryName = ?categoryName";
                        cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                        
                        conn.Close();
                    }
                    else
                    {
                        //TODO create error number for tried to open database and connection did not open when adding data to budget table
                        errNbr = -1;
                    }
                    
                    if (errNbr == 0)
                    {
                        //check if budget name has already been created before adding
                        if (!rdr.HasRows)
                        {
                            if (conn.State != ConnectionState.Open)
                            {
                                conn.Open();
                            }
                            cmd = new MySqlCommand();
                            categoryBudgetDate = DateTime.Now;
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO table_budget(CategoryName, CategoryAmt, CategoryBudgetDate) VALUES(?categoryName, ?categoryAmt, ?categoryBudgetDate)";
                            cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                            cmd.Parameters.Add("?categoryAmt", MySqlDbType.Decimal).Value = categoryAmtDec;
                            cmd.Parameters.Add("?categoryBudgetDate", MySqlDbType.DateTime).Value = categoryBudgetDate;
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
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM table_Budget WHERE CategoryName=?categoryName";
                cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                cmd.ExecuteNonQuery();

                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                //TODO catch exception in updating budget list view.
                errorNotify = new ErrorNotify();
                errorNotify.errDescription = ex.Message;
                errorNotify.errLocalDescription = "Error Deleting a Budget";
                errorNotify.Show();
                conn.Close();
            }

            return errNbr;
        }

        /// <summary>
        /// Returns a ListViewItem containing the categorys found in the Budget Table
        /// </summary>
        /// <param name="CategorylstvwItem"></param>
        /// <returns></returns>
        public int BudgetTableGetCategory(ListViewItem CategorylstvwItem)
        {
            int errNbr = 0;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd.Connection = conn;
                cmd.CommandText = "SELECT CategoryName, CategoryAmt FROM table_Budget";
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    CategorylstvwItem = new ListViewItem();
                    CategorylstvwItem.SubItems[0].Text = rdr[0].ToString();
                    CategorylstvwItem.SubItems.Add(rdr[1].ToString());
                }
                rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                //TODO catch exception in updating budget list view.
                errNbr = -1;
            }

            return errNbr;
        }
        #endregion

        #region Constructor
        internal BudgetDB()
            {

            }
        #endregion

        #region Private Members
        private static String ReturnConnectionString()
        {
            string connString = "server=" + ConfigurationManager.AppSettings["server"].ToString() + ";" +
                                     "user=" + ConfigurationManager.AppSettings["user"].ToString() + ";" +
                                     "database=" + ConfigurationManager.AppSettings["database"].ToString() + ";" +
                                     "port=" + ConfigurationManager.AppSettings["port"].ToString() + ";" +
                                     "password=" + ConfigurationManager.AppSettings["password"] + ";";
            return connString;
        }
        #endregion
    }
}
