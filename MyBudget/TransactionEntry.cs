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
    public partial class TransactionEntry : Form
    {
        public Boolean isAddTransactionEntry;
        public Boolean isModifyTransactionEntry;
        
        public TransactionEntry()
        {
            InitializeComponent();
        }

        private void lbl_label1_Click(object sender, EventArgs e)
        {

        }

        private void TransactionEntry_Load(object sender, EventArgs e)
        {
            String connStr = MainForm.ReturnConnectionString();
            String cmdStr;
            String categoryName;
            Decimal categoryAmt;
            DateTime categoryBudgetDate;

            //Determine if modify or add btn was pressed for transaction entries
            if (isAddTransactionEntry)
            {
                //if add
                //Get list of budgets located on the server
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand();

                categoryName = this.lstBox_BudgetName.SelectedItem.ToString();

                //Try to convert text entered into decimal
                if (decimal.TryParse(this.txt_textBox2.Text, out categoryAmt))
                {
                    //do nothing with categoryAmt
                }
                else
                {
                    //Post notification that entered value is incorrect.
                }

                categoryBudgetDate = DateTime.Now;
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO table_transaction (CategoryName, CategoryAmt, CategoryBudgetDate) VALUES (?categoryName, ?categoryAmt, ?categoryBudgetDate)";
                cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                cmd.Parameters.Add("?categoryAmt", MySqlDbType.Decimal).Value = categoryAmt;
                cmd.Parameters.Add("?categoryBudgetDate", MySqlDbType.DateTime).Value = categoryBudgetDate;

                //show them in listbox on form
            }
            else if (isModifyTransactionEntry)
            {

                //if modify
                //get selected item from the transaction listview and show it in the
                //list box on the transaction entry form
            }
            else
            {
                this.Close();
            }  
        }
    }
}

