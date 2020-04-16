using System;

namespace CSP
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem uniqueItem1 = new UniqueItem();
            UniqueItem uniqueItem2 = new UniqueItem();
            UniqueItem uniqueItem3 = new UniqueItem();
            UniqueItem uniqueItem4 = new UniqueItem();

            UniqueItem.CounterOfUsers();
        }

        class UniqueItem
        {

            private static int counter = default;

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
