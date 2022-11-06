using System;
using System.Linq;
using System.Windows.Forms;
using MyBudget.Data;

namespace MyBudget
{
    public partial class TransactionEntryForm : Form
    {
        BudgetDataModel budgetData;

        private Transaction someTransaction = new Transaction();

        public Transaction SomeTransaction
        {
            get { return someTransaction; }
            set
            {
                someTransaction.Id = value.Id;
                someTransaction.Budget = value.Budget;
                someTransaction.Amount = value.Amount;
            }
        }
        public TransactionEntryForm(BudgetDataModel budgetData)
        {
            InitializeComponent();
            this.budgetData = budgetData;
            transactionAmountTextBox.DataBindings.Add(new Binding("Text", someTransaction, "Amount"));
            budgetNameComboBox.DisplayMember = "Name";
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //TODO use modal and formclosing
            someTransaction.Budget = budgetData.Budgets[budgetNameComboBox.SelectedIndex];
            var modifiedTransaction = budgetData.Transactions.Where(i => i.Id == someTransaction.Id).FirstOrDefault();
            if (modifiedTransaction != null)
            {
                //modifying income
                modifiedTransaction.Budget = someTransaction.Budget;
                modifiedTransaction.Amount = decimal.Parse(transactionAmountTextBox.Text);
            }
            else
            {
                //adding income
                var newTransaction = new Transaction(someTransaction);
                budgetData.Transactions.Add(newTransaction);
            }
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //TODO make this show modal and just used form closing
            Close();
        }

        private void TransactionEntryForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (budgetData.Budgets.Count > 0)
                {
                    budgetNameComboBox.DataSource = budgetData.Budgets.Where(b => !b.IsIncome).ToList();
                    var modifiedTransaction = budgetData.Transactions.Where(i => i.Id == someTransaction.Id).FirstOrDefault();
                    var selectIndex = modifiedTransaction != null ? budgetData.Budgets.IndexOf(modifiedTransaction.Budget) : 0;
                    budgetNameComboBox.SelectedIndex = selectIndex == -1 ? 0 : selectIndex;
                    budgetNameComboBox.Focus();
                    okButton.Enabled = true;
                }
                else
                {
                    okButton.Enabled = false;
                }
                budgetNameComboBox.Focus();
            }
        }

        private void txt_TransactionAmt_TextChanged(object sender, EventArgs e)
        {
            //TODO: possibly get rid of this and just do a check on OK.
            decimal val;
            if (!decimal.TryParse(transactionAmountTextBox.Text, out val) &&
                !string.IsNullOrEmpty(transactionAmountTextBox.Text))
            {
                transactionAmountTextBox.Text = transactionAmountTextBox.Text.Remove(transactionAmountTextBox.Text.Length - 1, 1);
            }
            else
            {
                someTransaction.Amount = val;
            }
        }
    }
}

