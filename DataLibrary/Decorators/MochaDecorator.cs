using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Decorators
{
    public class MochaDecorator : CondimentDecorator
    {

        public MochaDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return Beverage.Cost() + .20;
        }

        public override string Description => Beverage.Description + ", Mocha";
    }
}
