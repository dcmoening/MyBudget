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
    public class MoneyReceivedDB : DatabaseConnection
    {
        #region Private Members



        //Income Table Constants
        private const string TABLE_INCOME = "table_income";
        private const string INCOME_COL_CATEGORYID = "idTable_Income";
        private const string INCOME_COL_CATEGORYNAME = "CategoryName";
        private const string INCOME_COL_ITEMAMT = "ItemAmt";
        private const string INCOME_COL_DATEPURCHASED = "DateReceived";

        #endregion

        #region Properties
        public Transaction SelectedTransaction
        {
            get;
            set;
        }

        #endregion

        #region Public Members

        public int IncomeTableModifyCategoryData(int categoryID, string itemAmtStr)
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
                        cmd.CommandText = "UPDATE" + " " + TABLE_INCOME + " " + "SET" + " " + INCOME_COL_ITEMAMT + "=?itemAmt," +
                                                                                                   INCOME_COL_DATEPURCHASED + "=?dateReceived " +
                                                                                     "WHERE" + " " + INCOME_COL_CATEGORYID + "=?categoryID";
                        cmd.Parameters.Add("?categoryID", MySqlDbType.Int32).Value = categoryID;
                        cmd.Parameters.Add("?itemAmt", MySqlDbType.Decimal).Value = itemAmtDec;
                        cmd.Parameters.Add("?dateReceived", MySqlDbType.DateTime).Value = datePurchased;
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        //TODO create error number for tried to open database and connection did not open when modifying data in income table
                        errNbr = -1;
                    }

                }
                catch (Exception ex)
                {
                    //TODO create error number for general database error modifying Income Data
                    errNbr = -1;
                }
            }
            else
            {
                //TODO create error number for budget category amount entered not in decimal formal when modifying data in Income table

                errNbr = -1;
            }


            return errNbr;
        }
        /// <summary>
        /// Insert category name and ammount into the Income database
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="categoryAmtStr"></param>
        /// <returns></returns>
        public int IncomeTableAddCategoryData(string categoryName, string itemAmtStr)
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
                    //Add entry into Income table.
                    errNbr = CheckDBConnection();
                    if (errNbr == 0)
                    {
                        cmd = new MySqlCommand();
                        datePurchased = DateTime.Now;
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO" + " " + TABLE_INCOME + "(" + INCOME_COL_CATEGORYNAME + ", " + INCOME_COL_ITEMAMT + ", " + INCOME_COL_DATEPURCHASED + ") VALUES(?categoryName, ?itemAmt, ?dateReceived)";
                        cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                        cmd.Parameters.Add("?itemAmt", MySqlDbType.Decimal).Value = itemAmtDec;
                        cmd.Parameters.Add("?dateReceived", MySqlDbType.DateTime).Value = datePurchased;
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
        /// Delete the category from the Income table.
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public int IncomeTableDeleteCategoryName(string categoryID)
        {
            int errNbr = 0;
            try
            {
                errNbr = CheckDBConnection();
                if (errNbr == 0)
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM" + " " + TABLE_INCOME + " " + "WHERE" + " " + INCOME_COL_CATEGORYID + "=?categoryId";
                    cmd.Parameters.Add("?categoryId", MySqlDbType.VarChar).Value = categoryID;
                    cmd.ExecuteNonQuery();
                }

                //conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                //TODO catch exception in updating Income list view.
                errNbr = -1;
            }

            return errNbr;
        }

        /// <summary>
        /// Returns a ListViewItem containing the items entered the current month
        /// </summary>
        /// <param name="CategorylstvwItem"></param>
        /// <returns></returns>
        public int IncomeTableGetCurrentMonth(ref ListView Categorylstv)
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
                    cmd.CommandText = "SELECT * FROM" + " " + TABLE_INCOME + " " + "WHERE YEAR(" + INCOME_COL_DATEPURCHASED + ") = YEAR(CURDATE()) AND MONTH(" + INCOME_COL_DATEPURCHASED + ") = MONTH(CURDATE())";

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
                        //TODO add error number for not connecting to database when select all category data from Income table
                        errNbr = -1;
                    }

                }
            }
            catch (Exception ex)
            {
                //TODO catch exception in updating Income list view.
                errNbr = -1;
            }

            return errNbr;
        }
        #endregion
    }


}
