using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApplication
{
    public class TransactionInformation
    {
        private string date;
        private string item;
        private string amount;
        private string depositWithdrawal;

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public string Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }
        public string Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        public string DepositWithdrawal
        {
            get
            {
                return depositWithdrawal;
            }
            set
            {
                depositWithdrawal = value;
            }
        }
    }
}
