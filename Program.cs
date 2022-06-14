using System;

namespace StringReducer
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Type a string:");
            string input = Console.ReadLine();

            try
            {
                string inputReduced = StringReducer.Reduce(input);

                Console.Write("String inputed by user: {0}", input);
                Console.WriteLine("String reduced: {0}", inputReduced);
                Console.WriteLine("String reduced size: {0} character(s)", inputReduced.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();            
        }
    }
}
