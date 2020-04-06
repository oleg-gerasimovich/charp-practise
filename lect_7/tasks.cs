using System;
using System.IO;
using System.Configuration;

namespace CSPpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Task_1()
            {
                //we can't creat empty array;
            }
            Task_1();

            static void Task_2()
            {
                object[] array = new object[3];
                array[0] = 32;
                array[1] = 'A';
                array[2] = "Hello";
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }

                array[0] = (int)array[0] + 10;
                array[2] = (string)array[2] + ", guys";

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Task_2();

            static void Task_3()
            {
                int[] array = new int[13];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(100);
                }

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }


            }
            Task_3();
        }
    }
}
