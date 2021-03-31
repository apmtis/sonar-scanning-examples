using System;
namespace SomeConsoleApplication
{
    public class Program
    {

        public const bool AlwaysReturnsTrue = true;
        static void Main(string[] args)
        {
            var iAmTrue = true;
            if (iAmTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();
        }

        public static object Passthrough(object obj)
        {
            return obj;
        }
    }
}
