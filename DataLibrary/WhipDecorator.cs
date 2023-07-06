using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class WhipDecorator : CondimentDecorator
    {

        public WhipDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }



        public override double Cost()
        {
            return Beverage.Cost() + .10;
        }

        public override string Description => Beverage.Description + ", Whip";

    }
}
