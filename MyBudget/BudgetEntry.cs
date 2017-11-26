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
    public partial class BudgetEntry : Form
    {
        const int ERROR_BUDGET = 1000;
        const int ERROR_BUDGET_ENTRY_EXIST = ERROR_BUDGET + 1;

        String connStr = MainForm.ReturnConnectionString();
        String categoryName;
        Decimal categoryAmt;
        MySqlCommand cmd;
        MySqlConnection conn;
        DateTime categoryBudgetDate;
        public Boolean isAddBudgetEntry;
        public Boolean isModifyBudgetEntry;
        ErrorNotify errorNotify;

        public BudgetEntry()
        {
            InitializeComponent();
        }

        public void setCategoryName(string catName)
        {
            categoryName = catName;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(txt_BudgetName.Text != "")
            {
                errorNotify = new ErrorNotify();
                categoryName = txt_BudgetName.Text;

                //Try to convert text entered into decimal
                if (decimal.TryParse(this.txt_BudgetAmt.Text, out categoryAmt))
                {
                    if (isAddBudgetEntry)
                    {
                        try
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "SELECT * FROM table_Budget WHERE CategoryName = ?categoryName";
                            cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                            MySqlDataReader rdr = cmd.ExecuteReader();                            

                            //check if budget name has already been created before adding
                            if (!rdr.HasRows)
                            {
                                rdr.Close();
                                cmd = new MySqlCommand();
                                categoryBudgetDate = DateTime.Now;
                                cmd.Connection = conn;
                                cmd.CommandText = "INSERT INTO table_budget(CategoryName, CategoryAmt, CategoryBudgetDate) VALUES(?categoryName, ?categoryAmt, ?categoryBudgetDate)";
                                cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                                cmd.Parameters.Add("?categoryAmt", MySqlDbType.Decimal).Value = categoryAmt;
                                cmd.Parameters.Add("?categoryBudgetDate", MySqlDbType.DateTime).Value = categoryBudgetDate;
                                cmd.ExecuteNonQuery();
                                closeForm();
                            }
                            else
                            {
                                //display error budget name has already been added
                                errorNotify.errNbr = ERROR_BUDGET_ENTRY_EXIST.ToString();
                                errorNotify.errLocalDescription = "Budget Entry " + categoryName + " already exists.";

                                //for catch add budget entry log the values of connection string, categoryName, categoryBudgetDate, categoryAmt
                                errorNotify.errDescription = "Category Name: " + categoryName + "\n"
                                    + "Category Amount: " + categoryAmt + "\n"
                                    + "Category Budget Date: " + categoryBudgetDate;

                                errorNotify.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            //Catch adding budget entry error
                            errorNotify.errDescription = ex.Message;
                            errorNotify.errLocalDescription = "Error adding budget item.";
                            errorNotify.Show();
                        }
                    }
                    else if (isModifyBudgetEntry)
                    {
                        try
                        {
                            //Update database
                            categoryBudgetDate = DateTime.Now;
                            cmd.Connection = conn;
                            cmd.CommandText = "UPDATE table_budget SET CategoryAmt=?categoryAmt, CategoryBudgetDate=?categoryBudgetDate)";
                            cmd.Parameters.Add("?categoryAmt", MySqlDbType.Decimal).Value = categoryAmt;
                            cmd.Parameters.Add("?categoryBudgetDate", MySqlDbType.DateTime).Value = categoryBudgetDate;
                            cmd.ExecuteNonQuery();
                            closeForm();
                        }
                        catch (Exception ex)
                        {
                            //Catch updating budget entry error
                            errorNotify.errDescription = ex.Message;
                            errorNotify.errLocalDescription = "Error updating budget item.";
                            errorNotify.Show();
                        }
                    }
                }
                else
                {
                    //TODO notify that entered value for budget amount is not a number.
                    errorNotify.errLocalDescription = "Please enter a decimal amount.";
                    errorNotify.Show();
                }
            }                        
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void closeForm()
        {
            conn.Close();
            this.Close();
        }

        private void BudgetEntry_Load(object sender, EventArgs e)
        {
            try
            {
                connStr = MainForm.ReturnConnectionString();
                conn = new MySqlConnection(connStr);
                conn.Open();
                cmd = new MySqlCommand();
            }
            catch(Exception ex)
            {
                //Catch connection for budget entry error
                errorNotify = new ErrorNotify();
                errorNotify.errDescription = ex.Message;
                errorNotify.errLocalDescription = "Error connecting to the database";
                errorNotify.Show();
            }
        }
           
    }
}

