namespace RegxDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Last Name: ");
            string Lname = Console.ReadLine();
            Patterns patterns = new Patterns();
            bool val= patterns.boolvalidate(Lname);
            if(val)
            {
                Console.WriteLine("Valid Lname");

             }
            else
            {
                Console.WriteLine("Invalid Lname");
            }
        }
    }
}