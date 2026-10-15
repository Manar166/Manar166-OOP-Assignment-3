using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Notification
{
    public class UrgentEmailNotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"[Email] {to}: [URGENT]{message}");
        }
    }
}
