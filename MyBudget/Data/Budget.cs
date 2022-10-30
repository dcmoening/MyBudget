using System;
using System.ComponentModel;

namespace MyBudget.Data
{
    public class Budget : INotifyPropertyChanged
    {
        public Budget ShallowCopy()
        {
            return (Budget)this.MemberwiseClone();
        }

        public Budget(Budget budget)
        {
            Id = budget.Id;
            Name = budget.Name;
            Amount = budget.Amount;
            isIncome = budget.isIncome;
        }
        public Budget()
        {
            Id = Guid.NewGuid();
            Name = "";
            Amount = 0;
            IsIncome = false;
        }

        public Budget(string name, decimal amount, bool isIncome)
        {
            Id = Guid.NewGuid();
            Name = name;
            Amount = amount;
            IsIncome = isIncome;
        }

        public Guid Id { get; set; }
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if(name != value)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private decimal amount;
        public decimal Amount
        {
            get => amount;
            set
            {
                if(amount != value)
                {
                    amount = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private bool isIncome;

        public bool IsIncome
        {
            get => isIncome;
            set
            {
                if(isIncome != value)
                {
                    isIncome = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        

        private void NotifyPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
        }
    }
}
