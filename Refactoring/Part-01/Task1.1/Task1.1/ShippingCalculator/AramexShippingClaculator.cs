using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.ShippingCalculator
{
    public class AramexShippingClaculator : IShippingStrategy
    {
        public decimal Calculate(decimal weightKg)
        {
            return weightKg * 12m;
        }
    }
}
