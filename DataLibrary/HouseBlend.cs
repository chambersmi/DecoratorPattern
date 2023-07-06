using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class HouseBlend : Beverage
    {
        double HouseBlendCost = .89;

        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return HouseBlendCost;
        }
    }
}
