using System;

namespace CSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("с какого номера хотете начать? ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 0)
            {
                UniqueItem.counter = number;
            }
            UniqueItem uniqueItem1 = new UniqueItem();
            UniqueItem uniqueItem2 = new UniqueItem();
            UniqueItem uniqueItem3 = new UniqueItem();
            UniqueItem uniqueItem4 = new UniqueItem();

            UniqueItem.CounterOfUsers();
        }

        class UniqueItem
        {

            public static int counter = default;

            public UniqueItem()
            {
                counter++;

            }

            public static void CounterOfUsers()
            {
                Console.WriteLine($"Создано {counter} id-шек");
            }
        }
    }

}
