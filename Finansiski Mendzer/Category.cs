using System.Collections.Generic;

namespace Finansiski_Mendzer
{
    public abstract class Category
    {
        //Абстрактна класа Category од која се наследени IncomeCategory и ExpensesCategory
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        //Го враќа објектот во csv формат.
        public abstract string ToCSV();
    }
}
