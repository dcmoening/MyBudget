using System;
using System.Linq;
using System.Windows.Forms;
using MyBudget.Data;

namespace MyBudget
{
    public partial class IncomeEntryForm : Form
    {
        BudgetDataModel budgetData;

        private Income someIncome = new Income();

        public Income SomeIncome
        {
            get { return someIncome; }
            set
            {
                someIncome.Id = value.Id;
                someIncome.Budget = value.Budget;
                someIncome.Amount = value.Amount;
            }
        }

        public IncomeEntryForm(BudgetDataModel budgetData)
        {
            InitializeComponent();
            this.budgetData = budgetData;
            incomeAmountTextBox.DataBindings.Add(new Binding("Text", someIncome, "Amount"));
            budgetNameComboBox.DisplayMember = "Name";
        }

        private void IncomeEntryForm_VisibleChanged(object sender, EventArgs e)
        {
            //TODO remove and use modal dialog
            if (Visible)
            {
                if(budgetData.Budgets.Count > 0)
                {
                    budgetNameComboBox.DataSource = budgetData.Budgets.Where(b => b.IsIncome).ToList();
                    var modifiedIncome = budgetData.Incomes.Where(i => i.Id == someIncome.Id).FirstOrDefault();
                    var selectIndex = modifiedIncome != null ? budgetData.Budgets.IndexOf(modifiedIncome.Budget) : 0;
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

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //TODO remove and use modal dialog
            someIncome.Budget = budgetData.Budgets[budgetNameComboBox.SelectedIndex];
            var modifiedIncome = budgetData.Incomes.Where(i => i.Id == someIncome.Id).FirstOrDefault();
            if (modifiedIncome != null)
            {
                //modifying income
                modifiedIncome.Budget = someIncome.Budget;
                modifiedIncome.Amount = decimal.Parse(incomeAmountTextBox.Text);
            }
            else
            {
                //adding income
                var newIncome = new Income(someIncome);
                budgetData.Incomes.Add(newIncome);
            }
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //TODO remove and use modal dialog
            Close();
        }

        private void txt_TransactionAmt_TextChanged(object sender, EventArgs e)
        {
            //TODO remove and just do check on submission
            decimal val;
            if (!decimal.TryParse(incomeAmountTextBox.Text, out val) &&
                !string.IsNullOrEmpty(incomeAmountTextBox.Text))
            {
                incomeAmountTextBox.Text = incomeAmountTextBox.Text.Remove(incomeAmountTextBox.Text.Length - 1, 1);
            }
            else
            {
                someIncome.Amount = val;
            }
        }
    }
}

