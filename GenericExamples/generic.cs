using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericExamples
{
    class generic
    {
            List<int> list;
            Queue<int> queue;
            SortedList<int, String> sortedlist;
            Stack<int> stack;
            HashSet<int> hashset;
            LinkedList<int> linkedlist;
            Dictionary<int, string> dictionary;
            generic()
            {
                list = new List<int>();
                queue = new Queue<int>();
                sortedlist = new SortedList<int, string>();
                stack = new Stack<int>();
                hashset = new HashSet<int>();
                linkedlist = new LinkedList<int>();
                dictionary = new Dictionary<int, string>();
            }
            public void Listoperations()
            {
                list.Add(1);
                list.Add(2);
                list.Add(3);
                list.Add(4);
                list.Add(5);
                list.Add(6);
                Console.WriteLine(list.IndexOf(5));
                Console.WriteLine(list.Count);
                list.RemoveAt(2);
                list.Remove(6);
                foreach (int i in list)
                {
                    Console.WriteLine(i);
                }
            }
            public void QueueOperations()
            {
                queue.Enqueue(1);
                queue.Enqueue(2);
                queue.Enqueue(3);
                queue.Enqueue(4);
                Console.WriteLine(queue.Count);
                Console.WriteLine(queue.Dequeue());
                Console.WriteLine("Elements in queue");
                foreach (int i in queue)
                {
                    Console.WriteLine(i);
                }
            }
            public void SortedlistOperations()
            {
                sortedlist.Add(1, "a");
                sortedlist.Add(2, "ad");
                sortedlist.Add(3, "ay");
                sortedlist.Add(13, "ah");
                sortedlist.Add(14, "ar");
                Console.WriteLine(sortedlist.ContainsKey(14));
                Console.WriteLine("Capacity of sorted List");
                Console.WriteLine(sortedlist.Capacity);
            }
            public void StackOpearations()
            {
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5);
                Console.WriteLine("Total number of elements in the Stack are");
                Console.WriteLine(stack.Count);
                Console.WriteLine("Peek");
                Console.WriteLine(stack.Peek());
                stack.Pop();
            }
            public void HashsetOperations()
            {
                hashset.Add(1);
                hashset.Add(12);
                hashset.Add(14);
                hashset.Add(15);
                hashset.Remove(1);
                Console.WriteLine("Total number of elements in the HashSet are");
                Console.WriteLine(hashset.Count);
                Console.WriteLine("Elements in hashset");
                foreach (int i in hashset)
                {
                    Console.WriteLine(i);
                }
            }
            public void LinkedsetOperations()
            {
                linkedlist.AddFirst(1);
                linkedlist.AddFirst(39);
                linkedlist.AddFirst(35);
                linkedlist.AddFirst(34);
                linkedlist.AddFirst(33);
                linkedlist.AddLast(6);
                Console.WriteLine("Total number of elements in the LinkedList are");
                Console.WriteLine(linkedlist.Count);
                Console.WriteLine("Elements in linkedlist");
                foreach (int i in linkedlist)
                {
                    Console.WriteLine(i);
                }
            }
            public void DictionaryOperations()
            {
                dictionary.Add(1, "a");
                dictionary.Add(17, "b");
                dictionary.Add(16, "ar");
                dictionary.Add(15, "ah");
                dictionary.Add(13, "au");
                Console.WriteLine(dictionary.ContainsKey(4));
                Console.WriteLine("Elements in Dictionary");
                foreach (int i in dictionary.Keys)
                {
                    Console.WriteLine(i);
                }
            }
            public static void Main(string[] args)
            {
            generic obj = new generic();
                obj.DictionaryOperations();
                obj.HashsetOperations();
                obj.LinkedsetOperations();
                obj.Listoperations();
                obj.QueueOperations();
                obj.StackOpearations();
                obj.SortedlistOperations();
            }
        }
    }

