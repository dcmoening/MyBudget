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
            txt_TransactionAmt.DataBindings.Add(new Binding("Text", someIncome, "Amount"));
            cmbo_BudgetName.DataSource = budgetData.Budgets;
            cmbo_BudgetName.DisplayMember = "Name";
        }

        private void MoneyReceivedEntry_Load(object sender, EventArgs e)
        {
                        
        }

        private void IncomeEntryForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if(budgetData.Budgets.Count > 0)
                {
                    var modifiedIncome = budgetData.Incomes.Where(i => i.Id == someIncome.Id).FirstOrDefault();
                    var selectIndex = modifiedIncome != null ? budgetData.Budgets.IndexOf(modifiedIncome.Budget) : 0;
                    cmbo_BudgetName.SelectedIndex = selectIndex == -1 ? 0 : selectIndex;
                    cmbo_BudgetName.Focus();
                    btn_OK.Enabled = true;
                }
                else
                {
                    btn_OK.Enabled = false;
                }
                cmbo_BudgetName.Focus();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            someIncome.Budget = budgetData.Budgets[cmbo_BudgetName.SelectedIndex];
            var modifiedIncome = budgetData.Incomes.Where(i => i.Id == someIncome.Id).FirstOrDefault();
            if (modifiedIncome != null)
            {
                //modifying income
                modifiedIncome.Budget = someIncome.Budget;
                modifiedIncome.Amount = decimal.Parse(txt_TransactionAmt.Text);
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
            Close();
        }

        private void txt_TransactionAmt_TextChanged(object sender, EventArgs e)
        {
            decimal val;
            if (!decimal.TryParse(txt_TransactionAmt.Text, out val) &&
                !string.IsNullOrEmpty(txt_TransactionAmt.Text))
            {
                txt_TransactionAmt.Text = txt_TransactionAmt.Text.Remove(txt_TransactionAmt.Text.Length - 1, 1);
            }
            else
            {
                someIncome.Amount = val;
            }
        }
    }
}

