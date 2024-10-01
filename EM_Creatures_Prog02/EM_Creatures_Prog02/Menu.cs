using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static EM_Creatures_Prog02.Library;

namespace EM_Creatures_Prog02
{
    public class Menu
    {
        public void LoadMenu()
        {
            World world = new World();
            Print(world.ShowLocations());

        }
    }
}
