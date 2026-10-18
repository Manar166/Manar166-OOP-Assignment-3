using Task1.Notification;
using Task1.OrderProcessor;
using Task1.ShippingCalculator;

namespace Part1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShippingStrategy shippingStrategy = new AramexShippingClaculator();
            Console.WriteLine($"Aramex 2kg → {shippingStrategy.Calculate(2)}");

            shippingStrategy = new FedExShippingClaculator();
            Console.WriteLine($"FedEx 2kg → {shippingStrategy.Calculate(2)}");
            Console.WriteLine();



            IEmailService emailService = new SmtpEmailSender();
            IOrderRepository orderRepository = new SqlOrderRepository();
            var processor = new OrderProcess(orderRepository, emailService);
            processor.Process(1001, "customer@example.com");
            Console.WriteLine();


            new UrgentScheduledEmailNotification { SendAt = DateTime.Today.AddHours(18) }
                .Send("customer@example.com", "Your order ships tomorrow");
            new UrgentSmsNotification()
                .Send("+201000000000", "OTP 4821");

        }
    }
}
