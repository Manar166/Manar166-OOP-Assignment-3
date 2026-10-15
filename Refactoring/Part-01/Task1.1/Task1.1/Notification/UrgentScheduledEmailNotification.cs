using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Notification
{
    internal class UrgentScheduledEmailNotification : INotefication , IScadualedNotification
    {
        //public UrgentScheduledEmailNotification(DateTime sendAt)
        //{
        //    SendAt = sendAt;
        //}

        public DateTime SendAt { get; set; }

        public void Send(string to, string message)
        {
            Console.WriteLine($"[email scheduled {SendAt:g}] {to}: [URGENT] {message}");
        }
   

    
    }
}
