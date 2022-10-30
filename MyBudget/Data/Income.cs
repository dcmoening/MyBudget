using System;
using System.ComponentModel;

namespace MyBudget.Data
{
    public class Income : INotifyPropertyChanged
    {
        public Income()
        {
            Id = Guid.NewGuid();
            Budget = null;
            Amount = 0;
        }
        public Income(Income income)
        {
            Id = income.Id;
            Budget = income.Budget;
            Budget.PropertyChanged += (o, e) => { NotifyPropertyChanged(); };
            Amount = income.Amount;
        }
        public Income(Budget budget, string name, decimal amount)
        {
            Id = Guid.NewGuid();
            Budget = budget;
            Amount = amount;
        }

        public Guid Id { get; set; }

        private Budget budget;
        public Budget Budget
        {
            get => budget;
            set
            {
                budget = value;
                NotifyPropertyChanged();
            }
        }

        public string Name
        {
            get
            {
                return Budget == null ? "" : Budget.Name;
            }
        }

        public decimal Amount { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
        }
    }
}