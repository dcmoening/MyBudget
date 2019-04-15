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
        public MoneyReceivedDB myIncome = new MoneyReceivedDB();
        private const string JANUARY = "January";
        private const string FEBRUARY = "February";
        private const string MARCH = "March";
        private const string APRIL = "April";
        private const string MAY = "May";
        private const string JUNE = "June";
        private const string JULY = "July";
        private const string AUGUST = "August";
        private const string SEPTEMBER = "September";
        private const string OCTOBER = "October";
        private const string NOVEMBER = "November";
        private const string DECEMBER = "December";
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

            
            if (errNbr == 0)
            {
                //Update main form
                UpdateMainForm();
            }            

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
            if (lstvw_Budget.SelectedItems.Count > 0)
            {
                BudgetEntry form_BudgetEntry = new BudgetEntry(myBudget);

                form_BudgetEntry.FormClosed += new FormClosedEventHandler(BudgetEntry_FormClosed);

                form_BudgetEntry.isModifyBudgetEntry = true;
                form_BudgetEntry.setCategoryName(lstvw_Budget.SelectedItems[0].Text);
                form_BudgetEntry.setCategoryAmt(System.Convert.ToDecimal(lstvw_Budget.SelectedItems[0].SubItems[1].Text));
                form_BudgetEntry.Show();
            }            
        }

        private void btn_moneyreceivedAdd_Click(object sender, EventArgs e)
        {
            MoneyReceivedEntry form_IncomeEntry = new MoneyReceivedEntry(myBudget, myIncome);

            form_IncomeEntry.FormClosed += new FormClosedEventHandler(TransactionEntry_FormClosed);

            form_IncomeEntry.isAddTransactionEntry = true;
            form_IncomeEntry.Show();
        }

        private void btn_moneyreceivedMinus_Click(object sender, EventArgs e)
        {
            String categoryID;
            int errNbr;
            // if budget is income, do not allow delete
            if (lstvw_MoneyReceived.SelectedItems.Count > 0)
            {
                categoryID = lstvw_MoneyReceived.SelectedItems[0].SubItems[0].Text;
                errNbr = myIncome.IncomeTableDeleteCategoryNameCurrentMonth(categoryID);
                if (errNbr == 0)
                {
                    UpdateMainForm();
                }
            }
        }

        private void btn_moneyreceivedModify_Click(object sender, EventArgs e)
        {
            //TODO add code from modifying income
            int income_ID;
            string income_String;

            if (lstvw_MoneyReceived.SelectedItems.Count > 0)
            {
                income_ID = Convert.ToInt32(lstvw_MoneyReceived.SelectedItems[0].SubItems[0].Text);
                income_String = lstvw_MoneyReceived.SelectedItems[0].SubItems[1].Text;

                //TODO: in TransactionEntry, if modify is selected get the Transaction ID of the item selected so it can be updated in the database.
                myIncome.SelectedTransaction = new Transaction
                {
                    transactionID = income_ID,
                    transactionName = income_String
                };

                MoneyReceivedEntry form_IncomeEntry = new MoneyReceivedEntry(myBudget, myIncome);
                form_IncomeEntry.FormClosed += new FormClosedEventHandler(TransactionEntry_FormClosed);
                form_IncomeEntry.isModifyTransactionEntry = true;
                form_IncomeEntry.Show();
            }
        }

        private void tmr_UpdateMainScreen_Tick(object sender, EventArgs e)
        {
            //TODO Update mainscreen labels and tables on timer event
            UpdateMainForm();
            
        }

        public void UpdateMainForm()
        {
            //update Budget Listview
            UpdateBudgetListView();
            UpdateTransactionListView();
            UpdateIncomeListView();
            UpdateIncomeTotals();
            FillBudgetDataGridView();
        }

        public void UpdateIncomeListView()
        {
            lstvw_MoneyReceived.Items.Clear();
            myIncome.IncomeTableGetCurrentMonth(ref lstvw_MoneyReceived );
        }

        public void UpdateTransactionListView()
        {
            lstvw_TransactionEntry.Items.Clear();
            myTransaction.TransactionTableGetCurrentMonth(ref lstvw_TransactionEntry);
        }
        
        public void UpdateBudgetListView()
        {
            lstvw_Budget.Items.Clear();
            myBudget.BudgetTableGetCategoryCurrentMonth(ref lstvw_Budget);
            
        }        

        public void UpdateIncomeTotals()
        {
            TotalData myTotalData = new TotalData();

            //lbl_TotalExpectedIncome.Text = myTotalData.GetTotalExpectedIncome().ToString();
            FormatForColor(ref lbl_TotalExpectedIncome, myTotalData.GetTotalExpectedIncomeCurrentMonth());

            //lbl_TotalExpectedBudget.Text = myTotalData.GetTotalExpectedBudget().ToString();
            FormatForColor(ref lbl_TotalExpectedBudget, myTotalData.GetTotalExpectedBudgetCurrentMonth());

            //lbl_ExpectedIncomeRemaining.Text = myTotalData.GetExpectedIncomeRemaining().ToString();
            FormatForColor(ref lbl_ExpectedIncomeRemaining, myTotalData.GetExpectedIncomeRemainingCurrentMonth());

            //lbl_TotalIncome.Text = myTotalData.GetTotalIncome().ToString();
            FormatForColor(ref lbl_TotalIncome, myTotalData.GetTotalIncomeCurrentMonth());

            //lbl_TotalSpent.Text = myTotalData.GetTotalSpent().ToString();
            FormatForColor(ref lbl_TotalSpent, myTotalData.GetTotalSpentCurrentMonth());

            //lbl_TotalIncomeRemaining.Text = myTotalData.GetTotalIncomeRemaining().ToString();
            FormatForColor(ref lbl_TotalIncomeRemaining, myTotalData.GetTotalIncomeRemainingCurrentMonth());
        }        

        private void FormatForColor(ref Label lbl, decimal val)
        {
            string formatedVal = String.Empty;

            if (val > 0)
            {
                lbl.ForeColor = Color.Green;
                
            }
            else
            {
                lbl.ForeColor = Color.Red;
            }

            lbl.Text = val.ToString();
        }

        private void FillBudgetDataGridView()
        {
            //https://stackoverflow.com/questions/29148568/filling-a-liststring-with-mysql-query
            //https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-bind-objects-to-windows-forms-datagridview-controls
            
            BindingSource bindingSource = new BindingSource();
            List<string> budgetLst = new List<string>();
            BudgetDB myBudget = new BudgetDB();
            TransactionDB myTransaction = new TransactionDB();
            int errNbr = 0;
            decimal budgetAmount = 0;
            decimal budgetSpent = 0;
            decimal budgetRemaing = 0;

            //Get list of budgets that money is spent from
            errNbr = myBudget.BudgetTableGetExpenseCategoryCurrentMonth(ref budgetLst);

            //For each budget item get the budget amount, budget spent, and budget remaining 
            if (errNbr == 0)
            {
                foreach (string budgetName in budgetLst)
                {
                    //Get budget amount from budget table
                    errNbr = myBudget.BudgetTableGetBudgetAmtForCategory(ref budgetAmount, budgetName);
                    //Get budget spent from transaction table
                    errNbr = myTransaction.TransactionTableGetTotalBudgetAmtSpent(ref budgetSpent,budgetName);
                    //Get budget remaining by subtracting total spent from total budget amount
                    budgetRemaing = budgetAmount - budgetSpent;
                    //Create new BudgetTable object initialized with above values
                    BudgetTableEntry tmpEntry = new BudgetTableEntry(budgetName, budgetAmount.ToString(), budgetSpent.ToString(), budgetRemaing.ToString());
                    //Add BudgetTable to Binding source
                    bindingSource.Add(tmpEntry);
                }
                dgv_BudgetReport.DataSource = bindingSource;

            }      
        }       

        private void januaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = JANUARY;
        }

        private void februaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = FEBRUARY;
        }

        private void marchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = MARCH;
        }

        private void aprilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = APRIL;
        }

        private void mayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = MAY;
        }

        private void juneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = JUNE;
        }

        private void julyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = JULY;
        }

        private void augustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = AUGUST;
        }

        private void septemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = SEPTEMBER;
        }

        private void octoberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = OCTOBER;
        }

        private void novemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = NOVEMBER;
        }

        private void decemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMonthSelected.Text = DECEMBER;
        }
    }
}
