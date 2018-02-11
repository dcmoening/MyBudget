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
        String categoryName;
        Decimal categoryAmt;
        DateTime categoryBudgetDate;
        String connStr;
        MySqlConnection conn;
        MySqlCommand cmd;
        public Boolean isAddTransactionEntry;
        public Boolean isModifyTransactionEntry;
        
        public TransactionEntry()
        {
            InitializeComponent();
        }

        private void TransactionEntry_Load(object sender, EventArgs e)
        {
            //connStr = MainForm.ReturnConnectionString();
            conn = new MySqlConnection(connStr);
            cmd = new MySqlCommand();

            //Determine if modify or add btn was pressed for transaction entries
            if (isModifyTransactionEntry)
            {
                //TODO add modification of Transaction Entry
                //if modify
                //get selected item from the transaction listview and show it in the
                //list box on the transaction entry form
            }
            else
            {
                this.Close();
            }  
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            

            //Try to convert text entered into decimal
            if (decimal.TryParse(this.txt_TransactionAmt.Text, out categoryAmt))
            {
                categoryName = this.lstBox_BudgetName.SelectedItem.ToString();
                categoryBudgetDate = DateTime.Now;
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO table_transaction (CategoryName, ItemAmt, DatePurchased) VALUES (?categoryName, ?itemAmt, ?datePurchased)";
                cmd.Parameters.Add("?categoryName", MySqlDbType.VarChar).Value = categoryName;
                cmd.Parameters.Add("?itemAmt", MySqlDbType.Decimal).Value = categoryAmt;
                cmd.Parameters.Add("?datePurchased", MySqlDbType.DateTime).Value = categoryBudgetDate;
            }
            else
            {
                //TODO notify that entered value for transaction amount is incorrect.
            }
           
        }
    }
}

