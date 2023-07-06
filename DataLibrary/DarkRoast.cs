using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DarkRoast : Beverage
    {
        public double DarkRoastCost = .89;

        public DarkRoast()
        {
            Description = "Dark Roast";
        }

        public override double Cost()
        {
            return DarkRoastCost;
        }
    }
}
