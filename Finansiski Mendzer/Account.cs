namespace Finansiski_Mendzer
{
    public class Account
    {
        public Account(Group group, string name, decimal amount)
        {
            Group = group;
            Name = name;
            Amount = amount;
        }
        public Account()
        {
        }
        public Group Group { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public string ToCSV()
        {
            //Го враќа објектот во csv формат.
            return string.Format("{0},{1},{2}\n", Group, Name, Amount);
        }
    }
}
