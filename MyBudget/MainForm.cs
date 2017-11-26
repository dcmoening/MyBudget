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

namespace MyBudget
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static String ReturnConnectionString()
        {
            string connString = "server=" + ConfigurationManager.AppSettings["server"].ToString() + ";" +
                                     "user=" + ConfigurationManager.AppSettings["user"].ToString() + ";" +
                                     "database=" + ConfigurationManager.AppSettings["database"].ToString() + ";" +
                                     "port=" + ConfigurationManager.AppSettings["port"].ToString() + ";" +
                                     "password=" + ConfigurationManager.AppSettings["password"] + ";";
            return connString;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_transAdd_Click(object sender, EventArgs e)
        {
            TransactionEntry form_TransactionEntry = new TransactionEntry();
            form_TransactionEntry.isAddTransactionEntry = true;
            form_TransactionEntry.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TODO check if income budget is in database.  If not add it.
        }

        private void btn_transMinus_Click(object sender, EventArgs e)
        {
            //TODO add code for deleting Transaction
        }

        private void btn_budgetAdd_Click(object sender, EventArgs e)
        {
            BudgetEntry form_BudgetEntry = new BudgetEntry();
            form_BudgetEntry.isAddBudgetEntry = true;
            form_BudgetEntry.Show();
        }

        private void btn_budgetMinus_Click(object sender, EventArgs e)
        {
            //TODO add code for deleting budget
            // if budget is income, do not allow delete
        }

        private void btn_BudgetModify_Click(object sender, EventArgs e)
        {
            //TODO add code for modifying budget
            BudgetEntry form_BudgetEntry = new BudgetEntry();
            form_BudgetEntry.isAddBudgetEntry = true;
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
    }
}
