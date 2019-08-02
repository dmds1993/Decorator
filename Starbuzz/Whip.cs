using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class Whip : ComdimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            Description = $"{beverage.GetDescription()} Whip";
        }
        public override string  GetDescription()
        {
            return $"Description {beverage.GetDescription()}";
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}
