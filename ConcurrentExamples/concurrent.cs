using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentExamples
{
    class Concurrent
    {
        BlockingCollection<int>[] obj1;
        BlockingCollection<int> obj2;
        ConcurrentDictionary<int, string> dict;
        ConcurrentStack<int> stack;
        ConcurrentQueue<int> queue;
        ConcurrentBag<int> cb;
        Concurrent()
        {
            obj1 = new BlockingCollection<int>[3];
            obj2 = new BlockingCollection<int>(8);
            dict = new ConcurrentDictionary<int, string>();
            stack = new ConcurrentStack<int>();
            queue = new ConcurrentQueue<int>();
            cb = new ConcurrentBag<int>();
        }
        public void Blocking_Collections_Example()
        {
            Console.WriteLine("Blocking_Collections_Example");
            obj1[0] = new BlockingCollection<int>(boundedCapacity: 10);
            obj1[1] = new BlockingCollection<int>(boundedCapacity: 10);

            Task t1 = Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 10; ++i)
                {
                    obj1[0].Add(i);
                    Thread.Sleep(100);
                }
                obj1[0].CompleteAdding();
            });
            Console.WriteLine("The elements added in thread 1:");
            foreach (int i in obj1[0].GetConsumingEnumerable())
            {
                Console.WriteLine(i);
            }

            Task t2 = Task.Factory.StartNew(() =>
            {
                for (int i = 11; i <= 20; ++i)
                {
                    obj1[1].Add(i);
                    Thread.Sleep(150);
                }
                obj1[1].CompleteAdding();
            });
            Console.WriteLine("The elements added in thread 2:");
            foreach (int i in obj1[1].GetConsumingEnumerable())
            {
                Console.WriteLine(i);
            }
            while (!obj1[0].IsCompleted ||!obj1[1].IsCompleted )
            {
                int x;
                BlockingCollection<int>.TryTakeFromAny(obj1, out x, TimeSpan.FromSeconds(1));
                if (x != default(int))
                {
                    Console.WriteLine(x);
                }
            }
            obj2.Add(1);
            obj2.Add(2);
            obj2.Add(3);
            obj2.Add(4);
            obj2.Add(5);
            obj2.Add(6);
            obj2.CompleteAdding();
            Console.WriteLine("The elements added:");
            foreach (int x in obj2)
            {
                Console.WriteLine(x);
            }
            int item = obj2.Take();
            Console.WriteLine("The number deleted is "+item);
            Console.WriteLine("Remaining elements:");
            foreach (int x in obj2)
            {
                Console.WriteLine(x);
            }
        }
        public void Concurrent_Dictionary_Example()
        {
            Console.WriteLine("Concurrent_Dictionary_Example");
            string x;
            dict.TryAdd(1, "one");
            dict.TryAdd(2, "two");
            dict.TryAdd(3, "three");
            dict.TryAdd(4, "four");
            dict.TryAdd(5, "five");
            foreach (var i in dict)
            {
                Console.WriteLine(i.Key + ":" + i.Value);
            }
            //The contains key check whether it has a key or not
            Console.WriteLine("This has a key 2 in it:"+dict.ContainsKey(2));
            dict.TryRemove(3,out x);
            Console.WriteLine("The deleted value is "+x);
            Console.WriteLine("Remaining elements:");
            foreach (var i in dict)
            {
                Console.WriteLine(i.Key + ":" + i.Value);
            }
        }
        public void Concurrent_Stack_Example()
        {
            Console.WriteLine("Concurrent_Stack_Example");
            int y;
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            foreach (int x in stack)
            {
                Console.WriteLine(x);
            }
            stack.TryPop(out y);
            Console.WriteLine("The poped value is " + y);
            int[] i = { 6,7,8 };
            stack.PushRange(i);
            foreach (int x in stack)
            {
                Console.WriteLine(x);
            }
            int count = stack.Count;
            Console.WriteLine("The number of elements in stack :" + count);
        }
        public void Concurrent_Queue_Example()
        {
            Console.WriteLine("Concurrent_Queue_Example");
            int y;
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach (int x in queue)
            {
                Console.WriteLine(x);
            }
            queue.TryDequeue(out y);
            Console.WriteLine("The Dequeued value is " + y);
            int count = queue.Count;
            Console.WriteLine("The number of elements in queue :" + count);
        }
        public void Concurrent_Bag_Example()
        {
            Console.WriteLine("Concurrent_Bag_Example");
            int y;
            cb.Add(1);
            cb.Add(2);
            cb.Add(3);
            cb.Add(4);
            cb.Add(5);
            foreach (int x in cb)
            {
                Console.WriteLine(x);
            }
            cb.TryTake(out y);
            Console.WriteLine("The Deleted value is " + y);
            int count=cb.Count;
            Console.WriteLine("The number of elements in bag :" + count);
        }

        static void Main(string[] args)
        {
            Concurrent c = new Concurrent();
            c.Blocking_Collections_Example();
            c.Concurrent_Dictionary_Example();
            c.Concurrent_Stack_Example();
            c.Concurrent_Queue_Example();
            c.Concurrent_Bag_Example();
        }
    }
}
