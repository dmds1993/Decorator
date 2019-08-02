using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Coffe Expresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
