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
    
    public partial class BudgetEntry : Form
    {
        const int ERROR_BUDGET = 1000;
        const int ERROR_BUDGET_ENTRY_EXIST = ERROR_BUDGET + 1;
        private BudgetDB myBudget;
        DateTime categoryBudgetDate;
        public Boolean isAddBudgetEntry;
        public Boolean isModifyBudgetEntry;
        //ErrorNotify errorNotify;
        String categoryName;
        Decimal categoryAmt;

        public BudgetEntry(BudgetDB budget)
        {
            myBudget = budget;
            InitializeComponent();
        }

        public void setCategoryName(string catName)
        {
            categoryName = catName;
        }

        public void setCategoryAmt(decimal catAmt)
        {
            categoryAmt = catAmt;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            int errNbr = 0;
            string categoryAmtStr;
            if (txt_BudgetName.Text != "")
            {                
                categoryName = txt_BudgetName.Text;
                categoryAmtStr = txt_BudgetAmt.Text;

            if (isAddBudgetEntry)
            {
                errNbr = myBudget.BudgetTableAddCategoryData(categoryName, categoryAmtStr);
                //TODO Handle error retrieved adding Budget category data

            }
                else if (isModifyBudgetEntry)
                {
                    errNbr = myBudget.BudgetTableModifyCategoryData(categoryName, categoryAmtStr);
                    //TODO Handle error retrieved modifying Budget category data
                }
            }
            closeForm();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            myBudget = null;
            closeForm();
        }

        private void closeForm()
        {
            this.Close();
        }

        private void BudgetEntry_Load(object sender, EventArgs e)
        {
            if (isModifyBudgetEntry)
            {
                txt_BudgetName.Text = categoryName;
                txt_BudgetAmt.Text = categoryAmt.ToString();
                txt_BudgetName.ReadOnly = true;
            }            
        }           
    }
}

