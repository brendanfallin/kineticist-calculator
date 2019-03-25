using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastEngine
{
    class FireInfusionDictionary
    {
        public static BasicBlastObject BasicFire = new BasicBlastObject("Basic Fire Blast", "fire", false, true);
        public static InfusionObject FanOfFlames = new InfusionObject("Fan of Flames", 1, "fire", true, false,
            new List<BasicBlastObject>() { BasicFire, blueFlame }, false, true, "dex", 0.5, 1.0);
        public static InfusionObject 
        // declare all infusions in the constructor
        public InfusionDictionary()
        {

        }

        // unsure whether to declare all infusions in the dictionary, to use getters, 
        // to use a hashmap, etc. leaning towards getters and declaring all infusions in the constructor
    }
}
