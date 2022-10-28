namespace RegxDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Email: ");
            string email = Console.ReadLine();
            //Console.WriteLine("Rule 4");
            Patterns patterns = new Patterns();
            bool val= patterns.boolvalidate(email);
            if(val)
            {
                Console.WriteLine("Valid Email");

             }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
    }
}