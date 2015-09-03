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
        
        private string itemBudgeted;
        private string budgetedCost;
        private string actualCost;
        private string difference;
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
        public string ItemBudgeted
        {
            get
            {
                return itemBudgeted;
            }
            set
            {
                itemBudgeted = value;
            }
        }
        public string BudgetedCost
        {
            get
            {
                return budgetedCost;
            }
            set
            {
                budgetedCost = value;
            }
        }
        public string ActualCost
        {
            get
            {
                return actualCost;
            }
            set
            {
                actualCost = value;
            }
        }
        public string Difference
        {
            get
            {
                return difference;
            }
            set
            {
                difference = value;
            }
        }
    }
}
