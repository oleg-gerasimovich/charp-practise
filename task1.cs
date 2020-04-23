using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello guys!";
            string @string = str.OnlyFiveSimbolds(str);
            Console.WriteLine(@string);
        }
    }


    public static class STHWithString
    {
        public static string OnlyFiveSimbolds(this string str, string message)
        {


            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == 5)
                {
                    str = str.Remove(5, str.Length - message.Length);
                    message = str.Insert(5, "...");
                }

            }
            return message;
        }
    }
}
