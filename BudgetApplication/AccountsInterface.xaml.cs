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
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Xml;

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
            public string Item { get; set; }
            public string Amount { get; set; }
            public double DepositWithdrawal { get; set; }

        }
        public AccountsI()
        {
            InitializeComponent();

            var xml = XDocument.Load("C:/Users/Mterrill_Li/Dropbox/C#/Week 7/BudgetApplication/BudgetApplicationRepo/BudgetApplication/Transactions.xml").Root;
            datagridAccount.DataContext = xml;
            

            
            
            /*DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            DataGridTextColumn col3 = new DataGridTextColumn();
            DataGridTextColumn col4 = new DataGridTextColumn();


            datagridAccount.Columns.Add(col1);
            datagridAccount.Columns.Add(col2);
            datagridAccount.Columns.Add(col3);
            datagridAccount.Columns.Add(col4);


            col1.Binding = new Binding("Date");
            col2.Binding = new Binding("Item");
            col3.Binding = new Binding("Amount");
            col4.Binding = new Binding("DepsoitWithdrawal");

            col1.Header = "Date";
            col2.Header = "Item";
            col3.Header = "Amount";
            col4.Header = "Depsoit/Withdrawal";

            datagridAccount.Items.Add(new MyAccountData { Date = "9/1/2015", Item = "Salary", Amount = 5000.00, DepositWithdrawal = Deposit });
            datagridAccount.Items.Add(new MyAccountData { Date = "9/2/2015", Item = "Movie", Amount = 40.00, DepositWithdrawal = Withdrawal});
            datagridAccount.Items.Add(new MyAccountData { Date = "9/2/2015", Item = "Restaurant", Amount = 60.00, DepositWithdrawal = Withdrawal});*/
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
            /*try
            {
                TransactionInformation info = new TransactionInformation();
                info.Date = dateSelection.Text;
                info.Item = txtItem.Text;
                info.Amount = txtAmount.Text;
                info.DepositWithdrawal = depositwithdrawal.Text;
                SaveXLM.SaveData(info, "C:/Users/Mterrill_Li/Dropbox/C#/Week 7/BudgetApplication/BudgetApplicationRepo/BudgetApplication/Transactions.xml");
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            try
            {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:/Users/Mterrill_Li/Dropbox/C#/Week 7/BudgetApplication/BudgetApplicationRepo/BudgetApplication/Transactions.xml");
            XmlNode transactions = doc.CreateElement("Transactions");
            
            XmlNode date = doc.CreateElement("Date");
            date.InnerText = dateSelection.Text;
            transactions.AppendChild(date);
            doc.DocumentElement.AppendChild(transactions);
            
            XmlNode item = doc.CreateElement("Item");
            item.InnerText = txtItem.Text;
            transactions.AppendChild(item);
            doc.DocumentElement.AppendChild(transactions);

            XmlNode amount = doc.CreateElement("Amount");
            amount.InnerText = txtAmount.Text;
            transactions.AppendChild(amount);
            doc.DocumentElement.AppendChild(transactions);

            XmlNode depositwithdrawal = doc.CreateElement("DepositWithdrawal");
            depositwithdrawal.InnerText = txtdepositwithdrawal.Text;
            transactions.AppendChild(depositwithdrawal);
            doc.DocumentElement.AppendChild(transactions);

            doc.Save("C:/Users/Mterrill_Li/Dropbox/C#/Week 7/BudgetApplication/BudgetApplicationRepo/BudgetApplication/Transactions.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddAccount_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void datagridAccount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
