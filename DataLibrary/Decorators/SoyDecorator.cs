using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Decorators
{
    public class SoyDecorator : CondimentDecorator
    {
        private Beverage _beverage;

        public SoyDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }

        public override string Description => Beverage.Description + ", Soy";

    }
}
