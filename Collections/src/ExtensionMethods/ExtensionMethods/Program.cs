namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            string phone2 = "01012345678";
            Console.WriteLine(phone2.IsValidEgyptianPhone());

            string phone3 = "+201512345678";
            Console.WriteLine(phone3.IsValidEgyptianPhone());


            string phone4 = "01312345678";
            Console.WriteLine(phone4.IsValidEgyptianPhone());


            string phone5 = "0101234567";
            Console.WriteLine(phone5.IsValidEgyptianPhone());
            

            string phone6 = "0101234567a";
            Console.WriteLine(phone6.IsValidEgyptianPhone());

            //string phone = "";
            //Console.WriteLine(phone.IsValidEgyptianPhone());






        }
    }
}
