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
using MyBudget.Data;

namespace MyBudget
{
    public partial class TransactionEntryForm : Form
    {
        BudgetDataModel budgetData;
        public TransactionEntryForm(BudgetDataModel budgetData)
        {
            InitializeComponent();
            this.budgetData = budgetData;
        }

        private void TransactionEntry_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbo_BudgetName_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible)
            {
                UpdateComboBoxBudgetname();
            }
        }

        private void UpdateComboBoxBudgetname()
        {
            cmbo_BudgetName.Items.Clear();
            foreach(var budget in budgetData.Budgets)
            {
                cmbo_BudgetName.Items.Add(budget.Name);
            }
        }
    }
}

