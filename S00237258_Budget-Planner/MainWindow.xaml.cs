using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S00237258_Budget_Planner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Q1(f)
        private void GetData()
        {
            List<BudgetItem> budgetItems = new List<BudgetItem>();

            // Creating my income related BudgetItems
            BudgetItem b1 = new BudgetItem(new DateTime(2024, 01, 06), "Grant", 300, true, true);
            BudgetItem b2 = new BudgetItem(new DateTime(2024, 01, 15), "Bonus", 300, false, true);
            BudgetItem b3 = new BudgetItem(new DateTime(2024, 01, 25), "Wages", 100, true, true);

            // Creating my expenses related BudgetItems
            BudgetItem b4 = new BudgetItem(new DateTime(2024, 01, 01), "Rent", 400, true, false);
            BudgetItem b5 = new BudgetItem(new DateTime(2024, 01, 05), "Flight", 100, false, false);
            BudgetItem b6 = new BudgetItem(new DateTime(2024, 01, 15), "Netflix", 10, true, false);
            BudgetItem b7 = new BudgetItem(new DateTime(2024, 01, 20), "Spotify", 8, true, false);

            budgetItems.Add(b1);
            budgetItems.Add(b2);
            budgetItems.Add(b3);
            budgetItems.Add(b4);
            budgetItems.Add(b5);
            budgetItems.Add(b6);
            budgetItems.Add(b7);

            SortBudgetItemsByIncomeOrExpense(budgetItems);
            getTotal(budgetItems);
        }

        // Q1(g)
        private void SortBudgetItemsByIncomeOrExpense(List<BudgetItem> budgetItems)
        {
            // Sort the budget items list by income or an expense.
            List<BudgetItem> incomeItems = budgetItems.Where(x => x.Income).OrderBy(x => x.Amount).ToList();
            List<BudgetItem> expenseItems = budgetItems.Where(x => !x.Income).OrderBy(x => x.Amount).ToList();

            // Add the new sorted budget items.
            lstbx_income.ItemsSource = incomeItems;
            lstbx_expenses.ItemsSource = expenseItems;
        }

        // Q1(h)
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

        }

        // Q1(i)
        private void btn_remove_Click(object sender, RoutedEventArgs e)
        {
            // Get the item from the listbox
            BudgetItem selectedBudget = lstbx_income.SelectedItem as BudgetItem;

            // Ensure an item is selected.
            if (selectedBudget != null)
            {
                // Remove entry
                lstbx_income.ItemsSource = null;
            }
        }

        // Q1(j) (note: out of time, this adds expenses instead of subtracting them).
        private void getTotal(List<BudgetItem> budgetItems)
        {
            double total = 0;

            // Get all of the prices together
            BudgetItem selectedBudget = lstbx_income.SelectedItem as BudgetItem;

            // Add prices up
            for (int i = 0; i < budgetItems.Count; i++) 
            {
                total = (total + budgetItems[i].Amount);
            }
        }
    }
}
