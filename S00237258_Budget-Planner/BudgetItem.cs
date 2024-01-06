using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00237258_Budget_Planner
{
    internal class BudgetItem : IComparable<BudgetItem>
    {
        // Properties
        /* -------------------------------------------------------------------- */

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

        // Income or Expense (for sorting)
        public bool Income { get; set; }

        /* -------------------------------------------------------------------- */

        public BudgetItem(DateTime date, string name, double amount, bool recurring, bool Income)
        {
            Date = date;
            Name = name;
            Amount = amount;
            Recurring = recurring;
            Income = Income;
        }

        // Sorting by date
        public int CompareTo(BudgetItem other)
        {
            return other.Date.CompareTo(this.Date);
        }
    }
}
