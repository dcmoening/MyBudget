using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MyBudget.Data;

namespace MyBudget
{
    public partial class MainForm : Form
    {
        private BudgetDataModel budgetData;
        //private ListViewItem BudgetCategoryLstVwItem;
        //public BudgetDB myBudget = new BudgetDB();
        //public TransactionDB myTransaction = new TransactionDB();
        //public MoneyReceivedDB myIncome = new MoneyReceivedDB();
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

        //Forms
        TransactionEntryForm transactionEntryForm;
        BudgetEntryForm budgetEntryForm;
        IncomeEntryForm incomeEntryForm;

        public MainForm(BudgetDataModel budgetData)
        {
            InitializeComponent();
            this.budgetData = budgetData;
            budgetData.Budgets.ListChanged += Budgets_ListChanged;
            budgetEntryForm = new BudgetEntryForm(budgetData);
            budgetEntryForm.FormClosing += EntryForm_FormClosing;

            transactionEntryForm = new TransactionEntryForm(budgetData);
            transactionEntryForm.FormClosing += EntryForm_FormClosing;

            //transactionListView.Leave += ListView_Leave;

            incomeEntryForm = new IncomeEntryForm(budgetData);
            incomeEntryForm.FormClosing += EntryForm_FormClosing;

            //incomeListView.Leave += ListView_Leave;

            //Update listviews
            UpdateTransactionListView();
            UpdateBudgetListView();
            UpdateIncomeListView();
        }

        

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                ((Form)sender).Hide();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        public void UpdateTransactionListView()
        {
            transactionListView.Items.Clear();
            foreach(var transaction in budgetData.Transactions)
            {
                var item = new ListViewItem(transaction.Name);
                item.SubItems.Add(transaction.Amount.ToString());
                transactionListView.Items.Add(item);
            }
        }

        public void UpdateIncomeListView()
        {
            incomeListView.Items.Clear();
            foreach (var income in budgetData.Incomes)
            {
                var item = new ListViewItem(income.Name);
                item.SubItems.Add(income.Amount.ToString());
                incomeListView.Items.Add(item);
            }
        }

        private void btn_transAdd_Click(object sender, EventArgs e)
        {
            transactionEntryForm.Show();
        }

        //Transaction
        #region Transaction
        private void transactionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddModifyButtons(modifyTransactionButton, removeTransactionButton, (ListView)sender);
        }
        #endregion

        //Budget
        #region Budget
        private void AddBudgetButton_Click(object sender, EventArgs e)
        {
            budgetEntryForm.SomeBudget = new Budget();
            budgetEntryForm.Show();
        }
        private void ModifyBudgetButton_Click(object sender, EventArgs e)
        {
            //Get item to be modified

            var index = budgetListView.SelectedIndices[0];
            budgetEntryForm.SomeBudget = budgetData.Budgets[index];
            budgetEntryForm.Show();
        }
        private void RemoveBudgetButton_Click(object sender, EventArgs e)
        {
            budgetData.Budgets.RemoveAt(budgetListView.SelectedIndices[0]);
        }
        private void Budgets_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateBudgetListView();
            UpdateAddModifyButtons(modifyBudgetButton, removeBudgetButton, budgetListView);
        }

        public void UpdateBudgetListView()
        {
            budgetListView.Items.Clear();
            var budgetsExist = budgetData.Budgets.Count() > 0;
            
            modifyBudgetButton.Enabled = budgetsExist;
            removeBudgetButton.Enabled = budgetsExist;

            foreach (var budget in budgetData.Budgets)
            {
                var item = new ListViewItem(budget.Name);
                item.SubItems.Add(budget.Amount.ToString());
                budgetListView.Items.Add(item);
            }
        }
        private void lstvw_Budget_SelectedIndexChanged(object sender, EventArgs e)
        {
            var budgetListView = (ListView)sender;
            UpdateAddModifyButtons(modifyBudgetButton, removeBudgetButton, (ListView)sender);
        }
        #endregion

        //Income
        #region Income
        private void incomeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UpdateAddModifyButtons(modifyIncomeButton, removeIncomeButton, (ListView)sender);
        }
        #endregion

        void UpdateAddModifyButtons(Button modify, Button remove, ListView listview)
        {
            bool itemSelected = listview.SelectedItems.Count > 0;
            modify.Enabled = itemSelected;
            remove.Enabled = itemSelected;
        }

        private void ListView_Leave(object sender, EventArgs e)
        {
            //clear selected items
            var listView = (ListView)sender;
            if(listView.SelectedItems.Count > 0)
            {
                listView.SelectedItems.Clear();
            }
        }

        

        
    }
}
