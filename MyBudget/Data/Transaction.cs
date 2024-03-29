﻿using System;
using System.ComponentModel;

namespace MyBudget.Data
{
    public class Transaction : INotifyPropertyChanged
    {
        public Transaction()
        {
            Id = Guid.NewGuid();
            Budget = null;
            Amount = 0;
        }
        public Transaction(Transaction transaction)
        {
            Id = transaction.Id;
            Budget = transaction.Budget;
            Budget.PropertyChanged += (o, e) => { NotifyPropertyChanged(); };
            Amount = transaction.Amount;
        }
        public Transaction(Budget budget, string name, decimal amount)
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