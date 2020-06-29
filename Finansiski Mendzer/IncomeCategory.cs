namespace Finansiski_Mendzer
{
    internal class IncomeCategory : Category
    {
        //Класа која претставува приходна категорија.

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
