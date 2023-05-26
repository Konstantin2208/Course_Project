using Course_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Project
{

    public class Team
    {
       
        private Couch couch;
        private List<FootballPlayer> players;
        private double averageAge;
        public Couch Couch
        {
            get { return couch; }
            set { couch = value; }
        }
        public List<FootballPlayer> Players
        {
            get { return players; }
            set { players = value; }
        }
        public double AverageAge
        {
            get { return averageAge; }
            set { averageAge = value; }
        }
        public override string ToString()
        {
            return $"Team{{couch ={couch}, players ={players},averageAge ={averageAge}}}";
        }
    }
}
