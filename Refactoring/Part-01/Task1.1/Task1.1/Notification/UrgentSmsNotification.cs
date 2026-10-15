using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Notification
{
    public class UrgentSmsNotification
    {
        public  void Send(string to, string message) =>
         Console.WriteLine($"[sms] {to}: [URGENT]{message}");
    }
}
