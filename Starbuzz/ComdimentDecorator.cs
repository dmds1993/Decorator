using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public abstract class ComdimentDecorator : Beverage
    {
        public abstract new string GetDescription();
    }
}
