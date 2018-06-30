using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget
{
    class TotalData
    {
        BudgetDB mybudget = new BudgetDB();
        MoneyReceivedDB myIncome = new MoneyReceivedDB();
        TransactionDB myTransaction = new TransactionDB();

        /// <summary>
        /// This is the sum amount of items in the budgeted marked as income
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalExpectedIncome()
        {
            decimal rslt = 0;
            int errNbr = 0;
            errNbr = mybudget.BudgetTableGetTotalIncomeAmt(ref rslt);

            return rslt;
        }

        /// <summary>
        /// This is the sum amount of items in the budgeted not marked as income
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalExpectedBudget()
        {
            decimal rslt = 0;
            int errNbr = 0;
            errNbr = mybudget.BudgetTableGetTotalBudgetAmt(ref rslt);
            return rslt;
        }

        /// <summary>
        /// This is the difference between income budgeted and income received
        /// </summary>
        /// <returns></returns>
        public decimal GetExpectedIncomeRemaining()
        {
            decimal rslt = 0;
            rslt = GetTotalExpectedIncome() - GetTotalExpectedBudget();
            return rslt;
        }

        /// <summary>
        /// Sum of all Money Received 
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalIncome()
        {
            decimal rslt = 0;
            int errNbr = 0;
            errNbr = myIncome.IncomeTableGetTotalIncomeAmt(ref rslt);
            return rslt;
        }

        /// <summary>
        /// Sum of all items in the Transaction Entries
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalSpent()
        {
            decimal rslt = 0;
            int errNbr = 0;
            errNbr = myTransaction.TransactionTableGetTotalTransactionAmt(ref rslt);
            return rslt;
        }

        /// <summary>
        /// This is the difference between Money received and money spent
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalIncomeRemaining()
        {
            decimal rslt = 0;
            rslt = GetTotalIncome() - GetTotalSpent();
            return rslt;
        }
    }
}
