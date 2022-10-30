using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Data
{
    public class Income
    {
        public Income(Guid budgetId, string name, decimal amount)
        {
            Id = new Guid();
            BudgetId = budgetId;
            Name = name;
            Amount = amount;
        }

        public Guid Id { get; set; }
        public Guid BudgetId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}