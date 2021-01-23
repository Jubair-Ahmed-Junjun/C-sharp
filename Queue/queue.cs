using System;
using System.Collections.Generic;

namespace Stack_QueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queueList = new Queue<string>();
            queueList.Enqueue("Jubair Ahmed Junjun");
            queueList.Enqueue("01854xxxxxxxxx");
            queueList.Enqueue("A");
            queueList.Enqueue("B");
            queueList.Enqueue("C");
            foreach(string data in queueList)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine(queueList.Count);
            queueList.Dequeue();
            foreach (string data in queueList)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine(queueList.Count);

            Console.ReadKey();
        }
    }
}
