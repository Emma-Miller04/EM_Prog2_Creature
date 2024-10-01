using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_Creatures_Prog02
{
    internal class Octopus : Creature
    {

        public override string Vocalize()
        {
            //base.Vocalize();

            return $"{Name} goes glub glub glub...";
        }
    }
}
