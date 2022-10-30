using System;
using System.Linq;
using System.Windows.Forms;
using MyBudget.Data;

namespace MyBudget
{
    public partial class BudgetEntryForm : EntryForm
    {
        private Budget someBudget = new Budget();
        public Budget SomeBudget
        {
            get => someBudget;
            set
            {
                // copy by value to keep the control binding done in the constructor.
                someBudget.Id = value.Id;
                someBudget.Name = value.Name;
                someBudget.Amount = value.Amount;
                someBudget.IsIncome = value.IsIncome;
            }
        }

        private BudgetDataModel budgetData;
        public BudgetEntryForm(BudgetDataModel budgetData)
        {
            InitializeComponent();
            this.budgetData = budgetData;
            txt_BudgetName.DataBindings.Add(new Binding("Text", someBudget, "Name"));
            txt_BudgetAmt.DataBindings.Add(new Binding("Text", someBudget, "Amount"));
            chkbox_IsIncome.DataBindings.Add(new Binding("Checked", someBudget, "IsIncome"));
        }

        private void btn_OK_Click(object sender, System.EventArgs e)
        {
            var modifedBudget = budgetData.Budgets.Where(b => b.Id == someBudget.Id).FirstOrDefault();
            if (modifedBudget != null)
            {
                modifedBudget.Name = txt_BudgetName.Text;
                modifedBudget.Amount = decimal.Parse(txt_BudgetAmt.Text);
                modifedBudget.IsIncome = chkbox_IsIncome.Checked;
            }
            else
            {
                var budget = new Budget(someBudget);
                budgetData.Budgets.Add(budget);
            }

            Close();
        }

        private void btn_Cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void txt_BudgetAmt_TextChanged(object sender, System.EventArgs e)
        {
            decimal val;
            if(!decimal.TryParse(txt_BudgetAmt.Text, out val) && 
                !string.IsNullOrEmpty(txt_BudgetAmt.Text))
            {
                txt_BudgetAmt.Text = txt_BudgetAmt.Text.Remove(txt_BudgetAmt.Text.Length - 1, 1);
            }
        }
    }
}

