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
    /// Interaction logic for BudgetInterface.xaml
    /// </summary>
    public partial class BudgetI : System.Windows.Controls.Page
    {
        public struct MyBudgetData
        {
            public string Items { get; set; }
            public double Budgeted { get; set; }
            public double ActualCost { get; set; }
            public double Difference { get; set; }
        }
        public BudgetI()
        {
            InitializeComponent();

            var xml = XDocument.Load("Transactions.xml").Root;
            datagridBudget.DataContext = xml;
            
            /*DataGridTextColumn col1 = new DataGridTextColumn();
            DataGridTextColumn col2 = new DataGridTextColumn();
            DataGridTextColumn col3 = new DataGridTextColumn();
            DataGridTextColumn col4 = new DataGridTextColumn();
            DataGridTextColumn col5 = new DataGridTextColumn();

            datagridBudget.Columns.Add(col1);
            datagridBudget.Columns.Add(col2);
            datagridBudget.Columns.Add(col3);
            datagridBudget.Columns.Add(col4);
            datagridBudget.Columns.Add(col5);

            col1.Binding = new Binding("Categories");
            col2.Binding = new Binding("Items");
            col3.Binding = new Binding("Budgeted");
            col4.Binding = new Binding("ActualCost");
            col5.Binding = new Binding("Difference");

            col1.Header = "Categories";
            col2.Header = "Items";
            col3.Header = "Budgeted";
            col4.Header = "ActualCost";
            col5.Header = "Difference";

            datagridBudget.Items.Add(new MyBudgetData { Categories = "Entertainment", Items = "Movies", Budgeted = 400.00, ActualCost = 300.00, Difference = 100.00 });
            datagridBudget.Items.Add(new MyBudgetData { Categories = "Entertainment", Items = "Restaurant", Budgeted = 400.00, ActualCost = 300.00, Difference = 100.00 });
            datagridBudget.Items.Add(new MyBudgetData { Categories = "Savings Goals", Items = "Vacation", Budgeted = 2000.00, ActualCost = 2000.00, Difference = 0.00 });*/
        }
        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        { 
            try
            {
            XmlDocument doc = new XmlDocument();
            doc.Load("Transactions.xml");
            XmlNode transactions = doc.CreateElement("BudgetOutlook");

            XmlNode itemB = doc.CreateElement("ItemBudgeted");
            itemB.InnerText = txtItemB.Text;
            transactions.AppendChild(itemB);
            doc.DocumentElement.AppendChild(transactions);
            
            XmlNode budgetedCost = doc.CreateElement("BudgetedCost");
            budgetedCost.InnerText = txtBudgeted.Text;
            transactions.AppendChild(budgetedCost);
            doc.DocumentElement.AppendChild(transactions);

            XmlNode actualCost = doc.CreateElement("ActualCost");
            actualCost.InnerText = txtAcutalCost.Text;
            transactions.AppendChild(actualCost);
            doc.DocumentElement.AppendChild(transactions);

            XmlNode difference = doc.CreateElement("Difference");
            difference.InnerText = txtDifference.Text;
            transactions.AppendChild(difference);
            doc.DocumentElement.AppendChild(transactions);

            doc.Save("Transactions.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datagridBudget_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAccountBudget_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBudgetBudget_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReportBudget_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
