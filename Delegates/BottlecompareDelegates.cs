using System;
using System.Collections.Generic;

namespace Delegates
{
        public class Bottle : IComparable<Bottle>
        {
            public int manufactureid { get; set; }
            public string company { get; set; }
            public double cost { get; set; }
        public int CompareTo(Bottle other)
            {
                if (this.manufactureid < other.manufactureid)
                {
                    return -1;
                }
                else if (this.manufactureid > other.manufactureid)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class Demo
        {

            private static int CompareBottle(Bottle x, Bottle y)
            {
                return x.cost.CompareTo(y.cost);
            }
            static void Main(string[] args)
            {
            Bottle b1 = new Bottle { manufactureid = 1125, company = "company1", cost = 490.97 };
            Bottle b2 = new Bottle { manufactureid = 2153, company = "company2", cost = 469.18 };
            Bottle b3 = new Bottle { manufactureid = 1030, company = "company3", cost = 510.79 };
                List<Bottle> bottles = new List<Bottle>() { b1, b2, b3 };
            bottles.Sort();
                Console.WriteLine("sorted by manufactureid");
                foreach (Bottle bb in bottles)
            {
                    Console.WriteLine(bb.manufactureid + " " + bb.company + " " + bb.cost);



                }
                Comparison<Bottle> mydel = new Comparison<Bottle>(CompareBottle);
            bottles.Sort(mydel);
                Console.WriteLine("sorted by cost");
                foreach (Bottle emp in bottles)
                {
                    Console.WriteLine(emp.manufactureid + " " + emp.company + " " + emp.cost);



                }
            }
        }
    }

