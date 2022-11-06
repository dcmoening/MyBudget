using System;
using System.ComponentModel;

namespace MyBudget.Data
{
    public class Entry : INotifyPropertyChanged
    {
        public Entry()
        {
            Id = Guid.NewGuid();
            Budget = null;
            Amount = 0;
        }

        public Entry(Entry entry)
        {
            Id = entry.Id;
            Budget = entry.Budget;
            Amount = entry.Amount;
            Budget.PropertyChanged += (o, e) => { NotifyPropertyChanged(); };
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
        protected void NotifyPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
        }
    }
}