using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.OrderProcessor
{
    public interface IEmailService
    {
        public void Send(string to, string body);
    }
}
