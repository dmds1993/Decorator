using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Most Excellent Dark Roast";
        }

        public override double Cost()
        {
            return 2.00;
        }
    }
}
