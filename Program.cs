namespace RegxDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the First Name: ");
            string Fname = Console.ReadLine();
            Patterns patterns = new Patterns();
            bool val= patterns.boolvalidate(Fname);
            if(val)
            {
                Console.WriteLine("Valid Fname");

             }
            else
            {
                Console.WriteLine("Invalid Fname");
            }
        }
    }
}