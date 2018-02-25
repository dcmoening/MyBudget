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

namespace MyBudget.Data
{
    class TransactionDB : DatabaseConnection
    {
        #region Public Members

        public int TransactionTableModifyCategoryData(string categoryName, string itemAmtStr)
        {
            int errNbr = 0;
            decimal itemAmtDec = 0;
            DateTime datePurchased;
            //Check if categoryAmtStr is in decimal format
            if (decimal.TryParse(itemAmtStr, out itemAmtDec))
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
                        datePurchased = DateTime.Now;
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE table_transaction SET ItemAmt=?itemAmt, DatePurchased=?datePurchased WHERE CategoryName=?categoryName";
                        cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                        cmd.Parameters.Add("?itemAmt", MySqlDbType.Decimal).Value = itemAmtDec;
                        cmd.Parameters.Add("?datePurchased", MySqlDbType.DateTime).Value = datePurchased;
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
        public int TransactionTableAddCategoryData(string categoryName, string itemAmtStr)
        {
            int errNbr = 0;
            decimal itemAmtDec = 0;
            DateTime datePurchased;

            //Check if categoryAmtStr is in decimal format
            if (decimal.TryParse(itemAmtStr, out itemAmtDec))
            {
                //MySqlDataReader rdr = cmd.ExecuteReader();
                try
                {


                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    cmd = new MySqlCommand();
                    datePurchased = DateTime.Now;
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO table_budget(CategoryName, ItemAmt, DatePurchased) VALUES(?categoryName, ?itemAmt, ?datePurchased)";
                    cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                    cmd.Parameters.Add("?itemAmt", MySqlDbType.Decimal).Value = itemAmtDec;
                    cmd.Parameters.Add("?datePurchased", MySqlDbType.DateTime).Value = datePurchased;
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    errNbr = -1;
                }
            }
            return errNbr;                    
        }
        /// <summary>
        /// Delete the category from the Buddget table.
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public int TransactionTableDeleteCategoryName(string categoryName)
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
                cmd.CommandText = "DELETE FROM table_Transaction WHERE CategoryName=?categoryName";
                cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                cmd.ExecuteNonQuery();

                //conn.Close();
                cmd.Dispose();
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
        /// Returns a ListViewItem containing the items entered the current month
        /// </summary>
        /// <param name="CategorylstvwItem"></param>
        /// <returns></returns>
        public int TransactionTableGetCurrentMonth(ref ListView Categorylstv)
        {
            int errNbr = 0;
            DateTime endTIme;
            ListViewItem CategorylstvwItem = new ListViewItem();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd.Connection = conn;
                cmd.CommandText = "SELECT CategoryName, CategoryAmt FROM table_Budget";
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (conn.State == ConnectionState.Open)
                {
                    while (rdr.Read())
                    {
                        CategorylstvwItem = new ListViewItem();
                        CategorylstvwItem.SubItems[0].Text = rdr[0].ToString();
                        CategorylstvwItem.SubItems.Add(rdr[1].ToString());
                        Categorylstv.Items.Add(CategorylstvwItem);
                    }
                    
                    //conn.Close();
                }
                else
                {
                    //TODO add error number for not connecting to database when select all category data from Budget table
                    errNbr = -1;
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                //TODO catch exception in updating budget list view.
                errNbr = -1;
            }

            return errNbr;
        }
        #endregion
    }


}
