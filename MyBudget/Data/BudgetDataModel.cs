using System.Collections.Generic;
using System.ComponentModel;

namespace MyBudget.Data
{
    public class BudgetDataModel
    {
        
        public BindingList<Budget> Budgets { get; set; } = new BindingList<Budget>();
        public BindingList<Transaction> Transactions { get; set; } = new BindingList<Transaction>();
        public BindingList<Income> Incomes { get; set; } = new BindingList<Income>();
    }
}
