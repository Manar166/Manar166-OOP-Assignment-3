using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.ShippingCalculator
{
    public interface IShippingStrategy
    {
        public decimal Calculate(decimal weightKg);

    }
}
