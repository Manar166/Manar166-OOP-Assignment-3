using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Notification
{
    public interface IScadualedNotification
    {
        public DateTime SendAt { get; set; }
    }
}
