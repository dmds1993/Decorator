using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffe";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
