using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastEngine
{
    class BasicBlastObject
    {
        private string name;
        private string element;
        private bool physicalBlast;
        private bool energyBlast;

        public string Name
        {
            get => name;
            protected set => name = value;
        }
        public string Element
        {
            get => element;
            protected set => element = value;
        }

        // blast can only be one of the two types, so when one is true, the other is false
        public bool PhysicalBlast
        {
            get => physicalBlast;
            protected set
            {
                if (value == true)
                {
                    physicalBlast = true;
                    energyBlast = false;
                }
                else
                {
                    physicalBlast = false;
                    energyBlast = true;
                }
            }
        }
        public bool EnergyBlast
        {
            get => energyBlast;
            protected set
            {
                if (value == true)
                {
                    energyBlast = true;
                    physicalBlast = false;
                }
                else
                {
                    energyBlast = false;
                    physicalBlast = true;
                }
            }
        }

        public BasicBlastObject (string name, string element, bool physicalBlast, bool energyBlast)
        {
            this.Name = name;
            this.Element = element;
            this.PhysicalBlast = physicalBlast;
            this.EnergyBlast = energyBlast;
        }
    }
}
