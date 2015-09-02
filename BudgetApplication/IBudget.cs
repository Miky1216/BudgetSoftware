using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApplication
{
    interface IBudget
    {
        void ChangeName();

        void CreateItem();

        void GetName();
    }
}
