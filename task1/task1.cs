using System;

namespace CSPless4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            short num1 = 12;
            object obj = num1;
            sbyte num2 = (sbyte)(short)obj;

            Console.WriteLine(num2);


        }
    }
}
