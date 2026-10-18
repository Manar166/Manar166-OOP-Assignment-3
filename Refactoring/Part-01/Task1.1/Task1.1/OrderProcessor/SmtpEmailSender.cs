using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.OrderProcessor
{
    public class SmtpEmailSender:IEmailService
    {
        public void Send(string to, string body) =>
      Console.WriteLine($"[SMTP] to={to} body={body}");
    }
}
