using System;
using System.Collections;
namespace CSPless5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            String str = Convert.ToString(Console.ReadLine());
            Console.WriteLine(str);
            int count1 = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    count1++;
                }

            }
            Console.WriteLine(count1);

        }
    }
}
