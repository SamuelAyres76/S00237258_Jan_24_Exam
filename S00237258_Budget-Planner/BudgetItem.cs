using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00237258_Budget_Planner
{
    internal class BudgetItem : IComparable<BudgetItem>
    {
        // Name
        public string Name { get; set; }

        // Amount
        public double Amount { get; set; }

        // ItemType
        public enum ItemType
        {
            Income,
            Expense
        }

        // Date
        public DateTime Date { get; set; }

        // Recurring
        public bool Recurring { get; set; }


        public BudgetItem(DateTime date, string name, double amount, bool recurring)
        {
            Date = date;
            Name = name;
            Amount = amount;
            Recurring = recurring;
        }

        // Sorting by date
        public int CompareTo(BudgetItem other)
        {
            return other.Date.CompareTo(this.Date);
        }
    }
}
