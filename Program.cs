namespace RegxDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Email Address: ");
            string email = Console.ReadLine();
            Patterns patterns = new Patterns();
            bool val= patterns.boolvalidate(email);
            if(val)
            {
                Console.WriteLine("Valid email address");

             }
            else
            {
                Console.WriteLine("Invalid email address");
            }
        }
    }
}