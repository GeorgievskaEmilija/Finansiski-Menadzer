namespace Finansiski_Mendzer
{
    internal class ExpensesCategory : Category
    {
        //Класа која претставува потрошувачка категорија.

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
