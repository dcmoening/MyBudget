using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyBudget.Data
{
    public class BudgetDataModel
    {
        
        public BindingList<Budget> Budgets { get; set; } = new BindingList<Budget>();
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public List<Income> Incomes { get; set; } = new List<Income>();
    }
}
