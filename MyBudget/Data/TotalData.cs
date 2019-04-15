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
        public decimal GetTotalExpectedIncomeCurrentMonth()
        {
            decimal rslt = 0;
            int errNbr = 0;
            errNbr = mybudget.BudgetTableGetTotalIncomeAmtCurrentMonth(ref rslt);

            return rslt;
        }

        /// <summary>
        /// This is the sum amount of items in the budgeted not marked as income
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalExpectedBudgetCurrentMonth()
        {
            decimal rslt = 0;
            int errNbr = 0;
            int monthValue = DateTime.Now.Month;
            int yearValue = DateTime.Now.Year;

            errNbr = mybudget.BudgetTableGetTotalBudgetAmtYearMonth(ref rslt, yearValue, monthValue);
            return rslt;
        }

        /// <summary>
        /// This is the difference between income budgeted and income received
        /// </summary>
        /// <returns></returns>
        public decimal GetExpectedIncomeRemainingCurrentMonth()
        {
            decimal rslt = 0;
            rslt = GetTotalExpectedIncomeCurrentMonth() - GetTotalExpectedBudgetCurrentMonth();
            return rslt;
        }

        /// <summary>
        /// Sum of all Money Received 
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalIncomeCurrentMonth()
        {
            decimal rslt = 0;
            int errNbr = 0;
            errNbr = myIncome.IncomeTableGetTotalIncomeAmtCurrentMonth(ref rslt);
            return rslt;
        }

        /// <summary>
        /// Sum of all items in the Transaction Entries
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalSpentCurrentMonth()
        {
            decimal rslt = 0;
            int errNbr = 0;
            errNbr = myTransaction.TransactionTableGetTotalTransactionAmtCurrentMonth(ref rslt);
            return rslt;
        }

        /// <summary>
        /// This is the difference between Money received and money spent
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalIncomeRemainingCurrentMonth()
        {
            decimal rslt = 0;
            rslt = GetTotalIncomeCurrentMonth() - GetTotalSpentCurrentMonth();
            return rslt;
        }
    }
}
