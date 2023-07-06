using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class Espresso : Beverage
    {
        double EspressoCost = 1.99;

        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return EspressoCost;
        }
    }
}
