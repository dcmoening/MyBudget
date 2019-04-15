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
    public partial class MoneyReceivedEntry : Form
    {
        
        Decimal categoryAmt;
        DateTime categoryBudgetDate;
        String connStr;
        MySqlConnection conn;
        MySqlCommand cmd;
        private BudgetDB myBudget;
        private MoneyReceivedDB myIncome;
        public Boolean isAddTransactionEntry;
        public Boolean isModifyTransactionEntry;
        
        public MoneyReceivedEntry(BudgetDB budget, MoneyReceivedDB income)
        {
            myBudget = budget;
            myIncome = income;
            InitializeComponent();
        }

        private void MoneyReceivedEntry_Load(object sender, EventArgs e)
        {
            //connStr = MainForm.ReturnConnectionString();
            conn = new MySqlConnection(connStr);
            cmd = new MySqlCommand();
            List<string> budgetLst = new List<string>();

            //Populate listview with current budget entries.
            myBudget.BudgetTableGetIncomeCategoryCurrentMonth(ref budgetLst);
            cmbo_BudgetName.DataSource = budgetLst;

            //Determine if modify or add btn was pressed for transaction entries
            if (isModifyTransactionEntry)
            {
                int selectedIndex;
                selectedIndex = cmbo_BudgetName.FindString(myIncome.SelectedTransaction.transactionName);
                cmbo_BudgetName.SelectedIndex = selectedIndex;
                cmbo_BudgetName.Enabled = false;

                //TODO add modification of Transaction Entry
                //if modify
                //get selected item from the transaction listview and show it in the
                //list box on the transaction entry form
            }            
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            int errNbr = 0;
            string categoryAmtStr;
            decimal categoryAmtDec = 0;

            
            categoryAmtStr = txt_TransactionAmt.Text;
            if (decimal.TryParse(categoryAmtStr, out categoryAmtDec))
            {
                if (isAddTransactionEntry)
                {
                    string categoryName;
                    categoryName = cmbo_BudgetName.SelectedItem.ToString();
                    if (!(string.IsNullOrEmpty(categoryName) | string.IsNullOrEmpty(categoryAmtStr)))
                    {
                        errNbr = myIncome.IncomeTableAddCategoryData(categoryName, categoryAmtStr);
                        //TODO Handle error retrieved adding Budget category data
                    }
                }
                else if (isModifyTransactionEntry)
                {
                    int categoryID;
                    categoryID = myIncome.SelectedTransaction.transactionID;
                    errNbr = myIncome.IncomeTableModifyCategoryData(categoryID, categoryAmtStr);
                    //TODO Handle error retrieved modifying Budget category data
                }
            }
            else
            {
                //TODO Handel error category amount not in decimal format
            }
            
            
            closeForm();

        }

        private void closeForm()
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

