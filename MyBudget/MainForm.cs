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
    public partial class MainForm : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        ErrorNotify errorNotify;
        String connStr;

        public MainForm()
        {
            InitializeComponent();
        }

        public static String ReturnConnectionString()
        {
            string connString = "server=" + ConfigurationManager.AppSettings["server"].ToString() + ";" +
                                     "user=" + ConfigurationManager.AppSettings["user"].ToString() + ";" +
                                     "database=" + ConfigurationManager.AppSettings["database"].ToString() + ";" +
                                     "port=" + ConfigurationManager.AppSettings["port"].ToString() + ";" +
                                     "password=" + ConfigurationManager.AppSettings["password"] + ";";
            return connString;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_transAdd_Click(object sender, EventArgs e)
        {
            TransactionEntry form_TransactionEntry = new TransactionEntry();
            form_TransactionEntry.isAddTransactionEntry = true;
            form_TransactionEntry.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            //Setup connection information for updating the main form.
            try
            {
                connStr = MainForm.ReturnConnectionString();
                conn = new MySqlConnection(connStr);
                cmd = new MySqlCommand();
            }
            catch (Exception ex)
            {
                //Catch connection for budget entry error
                errorNotify = new ErrorNotify();
                errorNotify.errDescription = ex.Message;
                errorNotify.errLocalDescription = "Error connecting to the database";
                errorNotify.Show();
            }

            //Update main form
            UpdateMainForm();

            //TODO check if income budget is in database.  If not add it.


        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            conn.Close();
        }

        private void btn_transMinus_Click(object sender, EventArgs e)
        {
            //TODO add code for deleting Transaction
        }

        private void btn_budgetAdd_Click(object sender, EventArgs e)
        {
            BudgetEntry form_BudgetEntry = new BudgetEntry();
            
            form_BudgetEntry.FormClosed += new FormClosedEventHandler(BudgetEntry_FormClosed);
                            
            form_BudgetEntry.isAddBudgetEntry = true;
            form_BudgetEntry.Show();
        }       

        void BudgetEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When budget entry closes update the budget listview
            UpdateBudgetListView();
        }

        private void btn_budgetMinus_Click(object sender, EventArgs e)
        {
            String categoryName;
            // add code for deleting budget
            // if budget is income, do not allow delete
            if(lstvw_Budget.SelectedItems.Count > 0)
            {
                categoryName = lstvw_Budget.SelectedItems[0].Text;
                if (categoryName != "income")
                {
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
                        UpdateBudgetListView();
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
                }
            }                
        }

        private void btn_BudgetModify_Click(object sender, EventArgs e)
        {
            //TODO add code for modifying budget
            BudgetEntry form_BudgetEntry = new BudgetEntry();

            form_BudgetEntry.FormClosed += new FormClosedEventHandler(BudgetEntry_FormClosed);

            form_BudgetEntry.isModifyBudgetEntry = true;
            form_BudgetEntry.setCategoryName(lstvw_Budget.SelectedItems[0].Text);
            form_BudgetEntry.setCategoryAmt(System.Convert.ToDecimal(lstvw_Budget.SelectedItems[0].SubItems[1].Text));
            form_BudgetEntry.Show();
        }

        private void btn_moneyreceivedAdd_Click(object sender, EventArgs e)
        {
            //TODO add code for adding income
        }

        private void btn_moneyreceivedMinus_Click(object sender, EventArgs e)
        {
            //TODO add code for deleting income
        }

        private void btn_moneyreceivedModify_Click(object sender, EventArgs e)
        {
            //TODO add code from modifying income
        }

        private void tmr_UpdateMainScreen_Tick(object sender, EventArgs e)
        {
            //TODO Update mainscreen labels and tables on timer event
        }

        public void UpdateMainForm()
        {
            //update Budget Listview
            UpdateBudgetListView();

            //TODO update Money Received Listview
            //TODO update Transaction Entry Listview
            //TODO update Budget and Income totals
            //TODO update Budget Table

        }
        
        public void UpdateBudgetListView()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd.Connection = conn;
                cmd.CommandText = "SELECT CategoryName, CategoryAmt FROM table_Budget";
                MySqlDataReader rdr = cmd.ExecuteReader();

                lstvw_Budget.Items.Clear();

                while (rdr.Read())
                {
                    ListViewItem lstvwItem = new ListViewItem();
                    lstvwItem.SubItems[0].Text = rdr[0].ToString();
                    lstvwItem.SubItems.Add(rdr[1].ToString());
                    lstvw_Budget.Items.Add(lstvwItem);
                }
                rdr.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                //TODO catch exception in updating budget list view.
            }
        }
    }
}
