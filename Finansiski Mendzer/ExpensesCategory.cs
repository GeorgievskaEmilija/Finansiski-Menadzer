using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansiski_Mendzer
{
    class ExpensesCategory : Category
    {
        public ExpensesCategory(string name) : base(name)
        {
        }

        public override string ToCSV()
        {
            string Result = string.Format("0,{0}\n", Name);

            return Result;
        }
    }
}
