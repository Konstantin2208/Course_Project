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
      
        private int number;
        private double height;

        public FootballPlayer(string name, int age) : base(name, age)
        {
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public override string ToString()
        {
            return $"FootballPlayer{{number={number}, height={height}, age={Age}, name={Name}}}";
        }
    }
}

  
