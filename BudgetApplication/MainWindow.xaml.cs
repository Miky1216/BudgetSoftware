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

namespace BudgetApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Controls.Page
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnAccount_Click(object sender, RoutedEventArgs e)
        {
            AccountsInterface accountInterface = new AccountsInterface();
            
            
        }

        private void btnBudget_Click(object sender, RoutedEventArgs e)
        {
            BudgetInterface budgetInterface = new BudgetInterface();
            
        }

        private void btnReports_Click(object sender, RoutedEventArgs e)
        {
            ReportsInterface reportInterface = new ReportsInterface();
            
        }
    }
}
