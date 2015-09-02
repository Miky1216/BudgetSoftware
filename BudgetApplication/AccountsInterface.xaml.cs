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
        public struct MyAccountData
        {
            public string Date { get; set; }
            public string MoneyType { get; set; }
            public string Item { get; set; }
            public double MoneyIn { get; set; }
            public double MoneyOut { get; set; }
        }
        public AccountsI()
        {
            InitializeComponent();
            DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            DataGridTextColumn col3 = new DataGridTextColumn();
            DataGridTextColumn col4 = new DataGridTextColumn();
            DataGridTextColumn col5 = new DataGridTextColumn();

            datagridAccount.Columns.Add(col1);
            datagridAccount.Columns.Add(col2);
            datagridAccount.Columns.Add(col3);
            datagridAccount.Columns.Add(col4);
            datagridAccount.Columns.Add(col5);

            col1.Binding = new Binding("Date");
            col2.Binding = new Binding("MoneyType");
            col3.Binding = new Binding("Item");
            col4.Binding = new Binding("MoneyIn");
            col5.Binding = new Binding("MoneyOut");

            col1.Header = "Date";
            col2.Header = "Money Type";
            col3.Header = "Item";
            col4.Header = "Money In";
            col5.Header = "Money Out";

            datagridAccount.Items.Add(new MyAccountData { Date = "9/1/2015", MoneyType = "Income", Item = "Salary", MoneyIn = 5000.00, MoneyOut = 0.00 });
            datagridAccount.Items.Add(new MyAccountData { Date = "9/2/2015", MoneyType = "Expense", Item = "Movie", MoneyIn = 0.00, MoneyOut = 40.00 });
            datagridAccount.Items.Add(new MyAccountData { Date = "9/2/2015", MoneyType = "Expense", Item = "Restaurant", MoneyIn = 0.00, MoneyOut = 60.00 });
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
        private void btnPostTransaction_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnAddAccount_Click_1(object sender, RoutedEventArgs e)
        {
            AccountType addAccountType = new AccountType();
            addAccountType.Show();
        }

        private void datagridAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
