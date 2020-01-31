using System;
using System.Collections;

namespace CollectionExamples
{
    class collections
    {
        ArrayList arrayList;
        Hashtable hashtable;
        Stack stack;
        Queue queue;
        collections()
        {
            arrayList = new ArrayList();
            hashtable = new Hashtable();
            stack = new Stack();
            queue = new Queue();
        }
        public void ArrayList_Example()

        {
            Console.WriteLine("ArrayList_Example");

           arrayList.Add(1);

            arrayList.Clear();

            arrayList.Add(1.9);

            arrayList.Add("324");

            arrayList.Add(false);

            arrayList.AddRange(arrayList);

            Console.WriteLine("Last  index of 1.9 = " + arrayList.LastIndexOf(1.9));

            foreach (var i in arrayList)

            {

                Console.WriteLine(i);

            }

        }
        public void hashTable_Example()

        {
            Console.WriteLine("hashTable_Example");
            hashtable.Add(1, "one");

            hashtable.Add(2.01, "Two.Zero");

            hashtable.Add("Three", 3);

            foreach (DictionaryEntry i in hashtable)

            {

                Console.WriteLine(i.Key + " -- " + i.Value);

            }

        }

        public void stack_example()

        {
            Console.WriteLine("stack_example");
            stack.Push(1);

            stack.Push("Hi");

            stack.Push("Hello ");

            Console.WriteLine("Peeked " + stack.Peek());

            Console.WriteLine("Popped " + stack.Pop());

            foreach (var i in stack)

            {

                Console.WriteLine(i);

            }

        }

        public void queue_example()

        {
            Console.WriteLine("queue_example");
            queue.Enqueue(1);

            queue.Enqueue("Hi");

            queue.Enqueue("Hello ");

            Console.WriteLine("Peeked " + queue.Peek());

            Console.WriteLine("Dequeue " + queue.Dequeue());

            foreach (var i in queue)

            {

                Console.WriteLine(i);

            }

        }
        static void Main(string[] args)
        {
            collections cl = new collections();
            cl.ArrayList_Example();
            cl.hashTable_Example();
            cl.stack_example();
            cl.queue_example();
        }
    }
}
