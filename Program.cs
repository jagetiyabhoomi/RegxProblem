namespace RegxDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Password: ");
            string pass = Console.ReadLine();
            Console.WriteLine("Rule 3");
            Patterns patterns = new Patterns();
            bool val= patterns.boolvalidate(pass);
            if(val)
            {
                Console.WriteLine("Valid password");

             }
            else
            {
                Console.WriteLine("Invalid password");
            }
        }
    }
}