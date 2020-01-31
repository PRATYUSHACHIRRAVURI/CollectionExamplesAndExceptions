using System;
using System.Collections.Specialized;

namespace Specialized
{
    class Specialized
    {

            ListDictionary listdictionary;
            HybridDictionary hybridDictionary;
            OrderedDictionary orderedDictionary;
            StringDictionary stringDictionary;
            StringCollection stringCollection;

            Specialized()
            {
                listdictionary = new ListDictionary();
                hybridDictionary = new HybridDictionary();
                orderedDictionary = new OrderedDictionary();
                stringDictionary = new StringDictionary();
                stringCollection = new StringCollection();
            }
            public void ListDictionaryOperations()
            {
                listdictionary.Add(2, "a");
                listdictionary.Add(23, "ad");
                listdictionary.Add(25, "ah");
                listdictionary.Add(26, "ak");
                Console.WriteLine("Number of Elements in ListDictionary");
                Console.WriteLine(listdictionary.Count);
                Console.WriteLine("Elements in ListDictionary");
                foreach (int i in listdictionary.Keys)
                {
                    Console.WriteLine(i);
                }
            }
            public void HybridDictionaryOperations()
            {
                hybridDictionary.Add(2, "ao");
                hybridDictionary.Add(52, "at");
                hybridDictionary.Add(82, "at");
                hybridDictionary.Add(28, "wa");
                hybridDictionary.Add(29, "ar");

                Console.WriteLine("Number of Elements in Hybrid Dictionary");
                Console.WriteLine(hybridDictionary.Count);
                Console.WriteLine("Elements in HybridDictionary");
                foreach (int i in hybridDictionary.Keys)
                {
                    Console.WriteLine(i);
                }
            }
            public void OrderedDictionaryOperations()
            {
                orderedDictionary.Add(2, "ao");
                orderedDictionary.Add(52, "at");
                orderedDictionary.Add(82, "at");
                orderedDictionary.Add(28, "wa");
                orderedDictionary.Add(29, "ar");

                orderedDictionary.Insert(2, 34, "ry");
                orderedDictionary.Remove(52);
                Console.WriteLine("Elements in OrderedDictionary");
                foreach (int i in orderedDictionary.Keys)
                {
                    Console.WriteLine(i);
                }
            }
            public void StringCollectionOperations()
            {
                stringCollection.Add("a");
                stringCollection.Add("b");
                stringCollection.Add("aa");
                stringCollection.Add("db");
                stringCollection.Add("ag");
                stringCollection.Add(null);
                stringCollection.Add("a");
                stringCollection.Add("b");
                stringCollection.Remove("ag");
                Console.WriteLine("Number of Elements in StringCollection");
                Console.WriteLine(stringCollection.Count);
                Console.WriteLine("Elements in StringCollection");
                foreach (string s in stringCollection)
                {
                    Console.WriteLine(s);
                }
            }
            public void StringDictionaryOperations()
            {
                stringDictionary.Add("a", "s");
                stringDictionary.Add("ag", "sy");
                stringDictionary.Add("da", "sh");
                stringDictionary.Add("an", "sd");
                stringDictionary.Add("sa", "sk");
                Console.WriteLine("Number of Elements in StringDictionary");
                Console.WriteLine(stringDictionary.Count);
                Console.WriteLine("Elements in StringCollection");
                foreach (string i in stringDictionary.Keys)
                {
                    Console.WriteLine(i);
                }

            }
            static void Main(string[] args)
            {
            Specialized obj = new Specialized();
                obj.ListDictionaryOperations();
                obj.HybridDictionaryOperations();
                obj.OrderedDictionaryOperations();
                obj.StringCollectionOperations();
                obj.StringDictionaryOperations();
            }
        }
    }

