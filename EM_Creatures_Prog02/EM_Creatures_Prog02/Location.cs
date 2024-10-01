using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_Creatures_Prog02
{  
    public class Location
    {
        public enum locationType
        {
            Tundra,
            Desert,
            Rainforest,
            TropicalIsland,
            UndergroundSea,
            Plains
        }


        public string Name;
        public string Description;
        public List<Creature> Creatures = new List<Creature> { };

        public locationType type = locationType.Tundra;
    }
}
