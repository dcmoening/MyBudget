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
        private ListViewItem BudgetCategoryLstVwItem;
        public BudgetDB myBudget = new BudgetDB();
        public TransactionDB myTransaction = new TransactionDB();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int errNbr;
            errNbr = myBudget.OpenDBConnection();
            
            BudgetCategoryLstVwItem = new ListViewItem();
            //TODO alert user if db did not connect

            //Update main form
            UpdateMainForm();

            //TODO check if income budget is in database.  If not add it.


        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            myBudget.CloseConnection();
        }
        
        private void btn_transAdd_Click(object sender, EventArgs e)
        {
            TransactionEntry form_TransactionEntry = new TransactionEntry(myBudget, myTransaction);

            form_TransactionEntry.FormClosed += new FormClosedEventHandler(TransactionEntry_FormClosed);

            form_TransactionEntry.isAddTransactionEntry = true;
            form_TransactionEntry.Show();
        }

        private void btn_transModify_Click(object sender, EventArgs e)
        {
            int transaction_ID;
            string transaction_String;

            if(lstvw_TransactionEntry.SelectedItems.Count > 0)
            {
                transaction_ID = Convert.ToInt32(lstvw_TransactionEntry.SelectedItems[0].SubItems[0].Text);
                transaction_String = lstvw_TransactionEntry.SelectedItems[0].SubItems[1].Text;

                //TODO: in TransactionEntry, if modify is selected get the Transaction ID of the item selected so it can be updated in the database.
                myTransaction.SelectedTransaction = new Transaction
                {
                    transactionID = transaction_ID,
                    transactionName = transaction_String
                };

                TransactionEntry form_TransactionEntry = new TransactionEntry(myBudget, myTransaction);
                form_TransactionEntry.FormClosed += new FormClosedEventHandler(TransactionEntry_FormClosed);
                form_TransactionEntry.isModifyTransactionEntry = true;
                form_TransactionEntry.Show();
            }                        
        }

        private void btn_transMinus_Click(object sender, EventArgs e)
        {
            String categoryID;
            int errNbr;
            // if budget is income, do not allow delete
            if (lstvw_TransactionEntry.SelectedItems.Count > 0)
            {
                categoryID = lstvw_TransactionEntry.SelectedItems[0].SubItems[0].Text;
                errNbr = myTransaction.TransactionTableDeleteCategoryName(categoryID);
                if (errNbr == 0)
                {
                    UpdateMainForm();
                }                
            }
        }

        private void btn_budgetAdd_Click(object sender, EventArgs e)
        {
            BudgetEntry form_BudgetEntry = new BudgetEntry(myBudget);
            
            form_BudgetEntry.FormClosed += new FormClosedEventHandler(BudgetEntry_FormClosed);
                            
            form_BudgetEntry.isAddBudgetEntry = true;
            form_BudgetEntry.Show();
        }       

        void BudgetEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When budget entry closes update the budget listview
            UpdateMainForm();
        }

        void TransactionEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When budget entry closes update the budget listview
            UpdateMainForm();
        }

        private void btn_budgetMinus_Click(object sender, EventArgs e)
        {
            String categoryName;
            int errNbr;
            // if budget is income, do not allow delete
            if(lstvw_Budget.SelectedItems.Count > 0)
            {
                categoryName = lstvw_Budget.SelectedItems[0].Text;
                if (categoryName != "income")
                {
                    errNbr = myBudget.BudgetTableDeleteCategoryName(categoryName);
                    if (errNbr == 0)
                    {
                        UpdateBudgetListView();
                    }                    
                }
            }                
        }

        private void btn_BudgetModify_Click(object sender, EventArgs e)
        {
            //TODO add code for modifying budget
            BudgetEntry form_BudgetEntry = new BudgetEntry(myBudget);

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
            UpdateTransactionListView();
            //TODO update Money Received Listview
            //TODO update Transaction Entry Listview
            //TODO update Budget and Income totals
            //TODO update Budget Table

        }
        public void UpdateTransactionListView()
        {
            lstvw_TransactionEntry.Items.Clear();
            myTransaction.TransactionTableGetCurrentMonth(ref lstvw_TransactionEntry);
        }
        
        public void UpdateBudgetListView()
        {
            lstvw_Budget.Items.Clear();
            myBudget.BudgetTableGetCategory(ref lstvw_Budget);
            
        }        
    }
}
