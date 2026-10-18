using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.OrderProcessor
{
    public interface IOrderRepository
    {
        public void Save(int orderId, DateTime processedAt);
    }
}
