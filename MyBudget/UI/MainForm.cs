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
            InitializeBudgetDataGridView(budgetData.Budgets);
            budgetEntryForm = new BudgetEntryForm(budgetData);
            modifyBudgetButton.Enabled = false;
            removeBudgetButton.Enabled = false;
            budgetEntryForm.FormClosing += EntryForm_FormClosing;
            budgetDataGridView.SelectionChanged += (o, e) =>
            {
                var buttonEnabled = budgetDataGridView.SelectedRows.Count > 0;
                modifyBudgetButton.Enabled = buttonEnabled;
                removeBudgetButton.Enabled = buttonEnabled;
            };

            // Only allow income and transactions to be added if budgets exist.
            budgetData.Budgets.ListChanged += (o, e) =>
            {
                var enabled = budgetData.Budgets.Count > 0;
                addIncomeButton.Enabled = enabled;
                addTransactionButton.Enabled = enabled;
            };

            InitializeIncomeDataGridView(budgetData.Incomes);
            incomeEntryForm = new IncomeEntryForm(budgetData);
            addIncomeButton.Enabled = false;
            modifyIncomeButton.Enabled = false;
            removeIncomeButton.Enabled = false;
            incomeEntryForm.FormClosing += EntryForm_FormClosing;
            incomeDataGridView.SelectionChanged += (o, e) =>
            {
                var buttonEnabled = budgetDataGridView.SelectedRows.Count > 0;
                modifyIncomeButton.Enabled = buttonEnabled;
                removeIncomeButton.Enabled = buttonEnabled;
            };

            transactionEntryForm = new TransactionEntryForm(budgetData);
            transactionEntryForm.FormClosing += EntryForm_FormClosing;

            //Update listviews
            UpdateTransactionListView();
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

        private void btn_transAdd_Click(object sender, EventArgs e)
        {
            transactionEntryForm.Show();
        }

        //Transaction
        #region Transaction
        private void transactionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UpdateAddModifyButtons(modifyTransactionButton, removeTransactionButton, (ListView)sender);
        }
        #endregion

        //Budget
        #region Budget
        private void InitializeBudgetDataGridView(BindingList<Budget> budgets)
        {
            budgetDataGridView.RowHeadersVisible = false;
            budgetDataGridView.DataSource = budgets;
            budgetDataGridView.Columns["Id"].Visible = false;
            budgetDataGridView.Columns["IsIncome"].Visible = false;
            budgetDataGridView.ReadOnly = true;
            budgetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            budgetDataGridView.AllowUserToAddRows = false;
            //Name Column
            budgetDataGridView.Columns["Name"].Resizable = DataGridViewTriState.False;
            budgetDataGridView.Columns["Name"].Width = 150;

            //Amount Column
            budgetDataGridView.Columns["Amount"].Resizable = DataGridViewTriState.False;
            budgetDataGridView.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void AddBudgetButton_Click(object sender, EventArgs e)
        {
            budgetEntryForm.SomeBudget = new Budget();
            budgetEntryForm.Show();
        }
        private void ModifyBudgetButton_Click(object sender, EventArgs e)
        {
            //Get item to be modified
            var index = budgetDataGridView.SelectedRows[0].Index;
            budgetEntryForm.SomeBudget = budgetData.Budgets[index];
            budgetEntryForm.Show();
        }
        private void RemoveBudgetButton_Click(object sender, EventArgs e)
        {
            budgetData.Budgets.RemoveAt(budgetDataGridView.SelectedRows[0].Index);
        }
        #endregion

        //Income
        #region Income
        private void InitializeIncomeDataGridView(BindingList<Income> budgets)
        {
            incomeDataGridView.RowHeadersVisible = false;
            incomeDataGridView.DataSource = budgets;
            incomeDataGridView.Columns["Id"].Visible = false;
            incomeDataGridView.Columns["Budget"].Visible = false;
            incomeDataGridView.ReadOnly = true;
            incomeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            incomeDataGridView.AllowUserToAddRows = false;
            //Name Column
            incomeDataGridView.Columns["Name"].Resizable = DataGridViewTriState.False;
            incomeDataGridView.Columns["Name"].Width = 150;

            //Amount Column
            incomeDataGridView.Columns["Amount"].Resizable = DataGridViewTriState.False;
            incomeDataGridView.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        #endregion

        

        private void ListView_Leave(object sender, EventArgs e)
        {
            //clear selected items
            var listView = (ListView)sender;
            if(listView.SelectedItems.Count > 0)
            {
                listView.SelectedItems.Clear();
            }
        }

        private void addIncomeButton_Click(object sender, EventArgs e)
        {
            incomeEntryForm.Show();
        }

        private void removeIncomeButton_Click(object sender, EventArgs e)
        {
            budgetData.Incomes.RemoveAt(incomeDataGridView.SelectedRows[0].Index);
        }

        private void modifyIncomeButton_Click(object sender, EventArgs e)
        {
            //Get item to be modified
            var index = incomeDataGridView.SelectedRows[0].Index;
            incomeEntryForm.SomeIncome = budgetData.Incomes[index];
            incomeEntryForm.Show();
        }
    }
}
