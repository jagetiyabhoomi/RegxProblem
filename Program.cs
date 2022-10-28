namespace RegxDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Phone number: ");
            string ph = Console.ReadLine();
            Patterns patterns = new Patterns();
            bool val= patterns.boolvalidate(ph);
            if(val)
            {
                Console.WriteLine("Valid phone number");

             }
            else
            {
                Console.WriteLine("Invalid phone number");
            }
        }
    }
}