using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class Soy : ComdimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            Description = $"{beverage.GetDescription()} Soy";
        }

        public override double Cost()
        {
            return .35 + beverage.Cost(); 
        }

        public override string GetDescription()
        {
            return $"{Description} {beverage.GetDescription()}";
        }
    }
}
