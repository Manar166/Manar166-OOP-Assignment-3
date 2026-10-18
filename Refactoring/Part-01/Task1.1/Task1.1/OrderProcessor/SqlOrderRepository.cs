using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.OrderProcessor
{
    public class SqlOrderRepository:IOrderRepository
    {
        public void Save(int orderId, DateTime processedAt) =>
      Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
    }
}
