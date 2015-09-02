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
    /// Interaction logic for AccountsInterface.xaml
    /// </summary>
    public partial class AccountsI : System.Windows.Controls.Page
    {
        public AccountsI()
        {
            InitializeComponent();
        }

        private void btnAccountAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBudgetAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReportsAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPostTransaction_Click(object sender, RoutedEventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
        }
    }
}
