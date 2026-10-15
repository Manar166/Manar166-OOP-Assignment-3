using RefactoringLab.Part02.Enrollment;

namespace Task_2.Enrollment
{
    public class CourseEnrollment
    {
        private readonly PaymentGateway _paymentGateway;
        private readonly SeatInventory _seatInventory;
        private readonly InvoiceGenerator _invoiceGenerator;
        private readonly EmailService _emailService;

        public CourseEnrollment(PaymentGateway paymentGateway,
            SeatInventory seatInventory,
            InvoiceGenerator invoiceGenerator,
            EmailService emailService)
        {
            _paymentGateway = paymentGateway;
            _seatInventory = seatInventory;
            _invoiceGenerator = invoiceGenerator;
            _emailService = emailService;
        }

        public void EnrollStudent(string studentId, decimal amount, string courseId)
        {
            _paymentGateway.Charge(studentId, amount);
            _seatInventory.Reserve(courseId, studentId);
            string invoiceId=_invoiceGenerator.Create(studentId, amount);
            _emailService.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");
        }

    }
}
