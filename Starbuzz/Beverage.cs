using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public abstract class Beverage
    {
        public string Description = "Unknow Beverage";

        public abstract double Cost();

        public string GetDescription()
        {
            return Description;
        }
    }
}
