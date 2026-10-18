using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.ShippingCalculator
{
    public class DHLShippingClaculator : IShippingStrategy
    {
        public decimal Calculate(decimal weightKg)
        {
            return weightKg * 18m;
        }
    }

}
