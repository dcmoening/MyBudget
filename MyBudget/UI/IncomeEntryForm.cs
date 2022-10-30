using System;
using System.Windows.Forms;
using MyBudget.Data;

namespace MyBudget
{
    public partial class IncomeEntryForm : Form
    {
        BudgetDataModel budgetData;
        public IncomeEntryForm(BudgetDataModel budgetData)
        {
            InitializeComponent();
            this.budgetData = budgetData;
        }

        private void MoneyReceivedEntry_Load(object sender, EventArgs e)
        {

        }

        private void UpdateComboBoxBudgetname()
        {
            cmbo_BudgetName.Items.Clear();
            foreach (var budget in budgetData.Budgets)
            {
                cmbo_BudgetName.Items.Add(budget.Name);
            }
        }

        private void IncomeEntryForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                UpdateComboBoxBudgetname();
            }
        }
    }
}

