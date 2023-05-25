using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Course_Project
{
    public class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
        public FootballPlayer(string name, int age) : base(name, age)
        {
        }
        public override string ToString()
        {
            return $"FootballPlayer{{number ={ Number}, height ={ Height},age ={ GetAge()}, name ={ GetName()}}}" ;
        }
    }
}