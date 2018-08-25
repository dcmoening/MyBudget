using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget
{
    //https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-bind-objects-to-windows-forms-datagridview-controls
    public class BudgetTableEntry
    {
        private string _budgetName;

        public string BudgetName
        {
            get { return _budgetName; }
            set { _budgetName = value; }
        }

        private string _budgetAmt;

        public string BudgetAmt
        {
            get { return _budgetAmt; }
            set { _budgetAmt = value; }
        }

        private string _budgetSpent;

        public string BudgetSpent
        {
            get { return _budgetSpent; }
            set { _budgetSpent = value; }
        }

        private string _budgetRemaining;

        public string  BudgetRemaining
        {
            get { return _budgetRemaining; }
            set { _budgetRemaining = value; }
        }

        public BudgetTableEntry(string Name, string  Amount, string Spent, string Remaining)
        {
            _budgetName = Name;
            _budgetAmt = Amount;
            _budgetSpent = Spent;
            _budgetRemaining = Remaining;
        }

    }
}
