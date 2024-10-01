using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EM_Creatures_Prog02.Library;

namespace EM_Creatures_Prog02
{
    public class World
    {
       public List<Location> locations = new List<Location>();

        public World()
        {

            locations.Add(new Location()
            {
                Name = "Tundra One",
                Description = "The first known location with tundra.",
                type = Location.locationType.Tundra,
                Creatures = new List<Creature>
                {
                    new Creature()
                    {
                        Name = "Laura",
                        cutenessType = Creature.Cuteness.SweetCute,
                        numberOfLegs = 4,
                    },
                    new Creature()
                    {
                        Name = "Berry",
                        cutenessType = Creature.Cuteness.ScaryCute,
                        numberOfLegs = 8,
                    },
                    new Creature()
                    {
                        Name = "Johnathan",
                        cutenessType = Creature.Cuteness.ExtraCute,
                        numberOfLegs = 2,
                    }
                }
            });
            locations.Add(new Location()
            {
                Name = "Tundra Two",
                Description = "The second known location with tundra.",
                type = Location.locationType.Tundra
            });
            locations.Add(new Location()
            {
                Name = "Desert School of Witchcraft and Wizzardry",
                Description = "Hogwarts in the desert.",
                type = Location.locationType.Desert
            });
        }

        public string ShowLocations()
        {
            string output = "";
            foreach(Location l in locations)
            {
                output += $"{l.Name} ({l.Description})\n";
            }
            return output;
        }   
        
        public void LocationMenu()
        {
            Print("Choose a location to visit.");
            Print(ShowLocations());
            string input = Console.ReadLine();

            
        }
    }
}
