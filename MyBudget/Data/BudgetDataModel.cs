using System.Collections.Generic;
using System.ComponentModel;

namespace MyBudget.Data
{
    public class BudgetDataModel
    {
        
        public BindingList<Budget> Budgets { get; set; } = new BindingList<Budget>();
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public List<Income> Incomes { get; set; } = new List<Income>();
    }
}
