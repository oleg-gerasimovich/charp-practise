using System;
using System.Collections;
using System.IO;
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            //System.Int32
            arrayList.Add(45);//box
            arrayList.Add(true);//box
            arrayList.Add("Hello!");//nope
            arrayList.Add(23.45);//box

        }
    }
}
