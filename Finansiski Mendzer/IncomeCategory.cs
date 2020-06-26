using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansiski_Mendzer
{
    class IncomeCategory : Category
    {
        public IncomeCategory(string name) : base(name)
        {
        }

        public override string ToCSV()
        {
            string Result = string.Format("1,{0}\n", Name);

            return Result;
        }
    }
}
