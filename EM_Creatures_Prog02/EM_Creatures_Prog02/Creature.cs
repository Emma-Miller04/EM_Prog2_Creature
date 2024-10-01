using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_Creatures_Prog02
{
    public class Creature
    {
        public enum Cuteness
        {
            ScaryCute,
            SweetCute,
            CuddlyCute,
            ExtraCute
        }
        
        public string Name;
        public int numberOfLegs;
        public List<Item> Diet = new List<Item>();
        public Cuteness cutenessType = Cuteness.SweetCute;
        

        public void Swim()
        {

        }

        public void Eat(Item item) 
        {

        }

        public void Move()
        {

        }

        public virtual string Vocalize()
        {
            return $"{Name} makes a noise.";
        }
    }
}
