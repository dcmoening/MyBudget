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
            TransactionEntry form_TransactionEntry = new TransactionEntry();
            form_TransactionEntry.isAddTransactionEntry = true;
            form_TransactionEntry.Show();
        }
        
        private void btn_transMinus_Click(object sender, EventArgs e)
        {
            //TODO add code for deleting Transaction
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
            UpdateBudgetListView();
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

            //TODO update Money Received Listview
            //TODO update Transaction Entry Listview
            //TODO update Budget and Income totals
            //TODO update Budget Table

        }
        
        public void UpdateBudgetListView()
        {
            lstvw_Budget.Items.Clear();
            myBudget.BudgetTableGetCategory(ref lstvw_Budget);            
        }
    }
}
