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
    
    public class TransactionDB : DatabaseConnection
    {
        #region Private Members
        //Transaction Table Constants
        private const string TABLE_TRANSACTION = "table_Transaction";
        private const string TRANSACTION_COL_CATEGORYID = "idTable_Transaction";
        private const string TRANSACTION_COL_CATEGORYNAME = "CategoryName";
        private const string TRANSACTION_COL_ITEMAMT = "ItemAmt";
        private const string TRANSACTION_COL_DATEPURCHASED = "DatePurchased";


        #endregion

        #region Properties
        

        public Transaction SelectedTransaction
        {
          get;
          set;
        }

        #endregion

        #region Public Members

        public int TransactionTableModifyCategoryData(int categoryID, string itemAmtStr)
        {
            int errNbr = 0;
            decimal itemAmtDec = 0;
            DateTime datePurchased;
            //Check if categoryAmtStr is in decimal format
            if (decimal.TryParse(itemAmtStr, out itemAmtDec))
            {
                try
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        //Update database
                        cmd = new MySqlCommand();
                        datePurchased = DateTime.Now;
                        cmd.Connection = conn;
                        cmd.CommandText = "UPDATE" + " " + TABLE_TRANSACTION + " " + "SET" + " " + TRANSACTION_COL_ITEMAMT + "=?itemAmt," +
                                                                                                   TRANSACTION_COL_DATEPURCHASED + "=?datePurchased " +
                                                                                     "WHERE" + " " + TRANSACTION_COL_CATEGORYID + "=?categoryID";
                        cmd.Parameters.Add("?categoryID", MySqlDbType.Int32).Value = categoryID;
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
                    //Select CategoryName from Budget table.
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {                      
                            cmd = new MySqlCommand();
                            datePurchased = DateTime.Now;
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO" + " " + TABLE_TRANSACTION + "("+ TRANSACTION_COL_CATEGORYNAME + ", " + TRANSACTION_COL_ITEMAMT + ", " + TRANSACTION_COL_DATEPURCHASED + ") VALUES(?categoryName, ?itemAmt, ?datePurchased)";
                            cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                            cmd.Parameters.Add("?itemAmt", MySqlDbType.Decimal).Value = itemAmtDec;
                            cmd.Parameters.Add("?datePurchased", MySqlDbType.DateTime).Value = datePurchased;
                            cmd.ExecuteNonQuery();
                     }                    
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
        public int TransactionTableDeleteCategoryName(string categoryID)
        {
            int errNbr = 0;
            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {                    
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM" + " " + TABLE_TRANSACTION + " " + "WHERE" + " " + TRANSACTION_COL_CATEGORYID + "=?categoryId";
                    cmd.Parameters.Add("?categoryId", MySqlDbType.VarChar).Value = categoryID;
                    cmd.ExecuteNonQuery();
                }                

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
            ListViewItem CategorylstvwItem = new ListViewItem();

            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    //SELECT * FROM table WHERE YEAR(date) = YEAR(CURDATE()) AND MONTH(date) = MONTH(CURDATE())
                    cmd.CommandText = "SELECT * FROM" + " " + TABLE_TRANSACTION + " " + "WHERE YEAR(" + TRANSACTION_COL_DATEPURCHASED + ") = YEAR(CURDATE()) AND MONTH(" + TRANSACTION_COL_DATEPURCHASED + ") = MONTH(CURDATE())";

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    if (conn.State == ConnectionState.Open)
                    {
                        while (rdr.Read())
                        {
                            CategorylstvwItem = new ListViewItem();
                            CategorylstvwItem.SubItems[0].Text = rdr[0].ToString();
                            CategorylstvwItem.SubItems.Add(rdr[1].ToString());
                            CategorylstvwItem.SubItems.Add(rdr[2].ToString());
                            Categorylstv.Items.Add(CategorylstvwItem);
                        }
                        rdr.Close();

                        //conn.Close();
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

        public int TransactionTableGetTotalTransactionAmt(ref decimal rslt)
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
                    cmd.CommandText = "SELECT sum(" + TRANSACTION_COL_ITEMAMT + ") FROM " + " " + TABLE_TRANSACTION + " " + "WHERE YEAR(" + TRANSACTION_COL_DATEPURCHASED + ") = YEAR(CURDATE()) AND MONTH(" + TRANSACTION_COL_DATEPURCHASED + ") = MONTH(CURDATE())";
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
