using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    internal class Decaf : Beverage
    {
        public double DecafCost = .89;

        public Decaf()
        {
            Description = "Decaf";    
        }

        public override double Cost()
        {
            return DecafCost;
        }
    }
}
