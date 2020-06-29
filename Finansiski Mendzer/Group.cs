namespace Finansiski_Mendzer
{
    public class Group
    {
        //Класа која претставува група од која може да се креира еден Account објект.

        public Group(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
