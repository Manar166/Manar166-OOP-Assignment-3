using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.OrderProcessor
{
    public class OrderProcess
    {
        private IOrderRepository repo;
        IEmailService email;

        public OrderProcess(IOrderRepository repo, IEmailService email)
        {
            this.repo = repo;
            this.email = email;
        }

        public void Process(int orderId, string customerEmail)
            {
            
                repo.Save(orderId, DateTime.Now);
                email.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
            }
       
    }
}
