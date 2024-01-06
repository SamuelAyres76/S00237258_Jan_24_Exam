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

        private void GetData()
        {
            List<BudgetItem> budgetItems = new List<BudgetItem>();

            // Creating my income related BudgetItems
            BudgetItem b1 = new BudgetItem(new DateTime(2024, 01, 06), "Grant", 300, true);
            BudgetItem b2 = new BudgetItem(new DateTime(2024, 01, 15), "Bonus", 300, false);
            BudgetItem b3 = new BudgetItem(new DateTime(2024, 01, 25), "Wages", 100, true);

            // Creating my expenses related BudgetItems
            BudgetItem b4 = new BudgetItem(new DateTime(2024, 01, 01), "Rent", 400, true);
            BudgetItem b5 = new BudgetItem(new DateTime(2024, 01, 05), "Flight", 100, false);
            BudgetItem b6 = new BudgetItem(new DateTime(2024, 01, 15), "Netflix", 10, true);
            BudgetItem b7 = new BudgetItem(new DateTime(2024, 01, 20), "Spotify", 8, true);

        }
    }
}
