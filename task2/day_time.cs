using System;
using System.Collections;
namespace CSPless4
{
    class Program
    {
        static void Main(string[] args)
        {
            if(DateTime.Now.Hour >= 9 && DateTime.Now.Hour <=12)
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour <= 15)
            {
                Console.WriteLine("Good day, guys");
            }
            else
            {
                Console.WriteLine("Good evening, guys");
            }


        }
    }
}
