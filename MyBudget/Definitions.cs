/*
 * Definitions for commonly  used structures and data types
 */

using System;
using System.Collections.Generic;

struct BudgetEntry
{
    private string name;
    private float amount;

    public float Amount { get => amount; set => amount = value; }
    public string Name { get => name; set => name = value; }

    public override bool Equals(object obj)
    {
        BudgetEntry other = (BudgetEntry)obj;
        return other.name == name && other.amount == amount;
    }

    public override int GetHashCode()
    {
        return name.GetHashCode() + amount.GetHashCode();
    }

    public override string ToString()
    {
        return "BudgetEntry{" + name + "," + amount.ToString() + "}";
    }
}


class Budget
{
    private string name;
    private float amount;
    private float spent;
    private float remaining;

    private List<BudgetEntry> entries;

    public float BudgetAmount { get => amount; set => amount = value; }
    public float BudgetSpent { get => spent; }
    public float BudgetRemaining { get => remaining; }

    public void AddEntry(BudgetEntry entry)
    {
        entries.Add(entry);

        spent += entry.Amount;
        remaining = amount - spent;
    }

    public override int GetHashCode()
    {
        int hash = name.GetHashCode() + amount.GetHashCode() + spent.GetHashCode() + remaining.GetHashCode();
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return "Budget{" + "" +
            "Amount:" + amount.ToString() +
            ",Spent:" + spent.ToString() + 
            ",Remaining:" + remaining.ToString() + 
            "}";
    }
}
