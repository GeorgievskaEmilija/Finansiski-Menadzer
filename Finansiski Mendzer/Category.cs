using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansiski_Mendzer
{
    public abstract class Category
    {
        public string Name { get; set; }

        public Category (string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Category)
            {
                Category c = (Category)obj;
                return this.Name.Equals(c.Name);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }

        public abstract string ToCSV();
    }
}
