using RefactoringLab.Part02.Enrollment;
using Task_2.Enrollment;
using Task_2.Reports;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Reports ===");
            var outDir = Path.Combine(Path.GetTempPath(), "refactoring-lab-part02");
            Directory.CreateDirectory(outDir);

            new CsvReportExporter().Export(Path.Combine(outDir, "report.csv"));
            new JsonReportExporter().Export(Path.Combine(outDir, "report.json"));
            new TextReportExporter().Export(Path.Combine(outDir, "report.txt"));
            Console.WriteLine($"Wrote reports to {outDir}");
            Console.WriteLine();





            Console.WriteLine("=== Enrollment ===");
            var studentId = "S100";
            var courseId = "CS201";
            var amount = 1500m;
            var paymentGateway = new PaymentGateway();
            var seatInventory = new SeatInventory();
            var invoiceGenerator = new InvoiceGenerator();
            var emailService = new EmailService();

            
            var enrollmentFacade = new CourseEnrollment(
                paymentGateway,
                seatInventory,
                invoiceGenerator,
                emailService
            );

      

            enrollmentFacade.EnrollStudent(studentId, amount, courseId);
        }
    }
}
