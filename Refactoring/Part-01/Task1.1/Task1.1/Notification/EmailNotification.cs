namespace Task1.Notification
{
    public class EmailNotification : INotefication
    {
        public void Send(string to, string message)
        {

            Console.WriteLine($"[email] {to}: {message}"); 
        }
    }
}
