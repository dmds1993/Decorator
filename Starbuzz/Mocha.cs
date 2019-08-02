using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class Mocha : ComdimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            Description = $"{beverage.GetDescription()} Mocha";
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}
