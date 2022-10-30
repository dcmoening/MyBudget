using System;

namespace MyBudget.Data
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid BudgetId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }    
}
