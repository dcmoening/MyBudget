using System;
using System.Windows.Forms;

namespace MyBudget
{
    public class EntryForm : Form
    {
        public event EventHandler BudgetDataChanged;

        protected virtual void OnDataChanged()
        {
            EventHandler handler = BudgetDataChanged;
            handler?.Invoke(this, new EventArgs());
        }
    }
}