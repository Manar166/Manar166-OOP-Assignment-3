using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Notification
{
    public interface INotefication
    {
        void Send(string to, string message);
    }
}
