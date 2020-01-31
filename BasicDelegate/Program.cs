using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BasicDelegate
{
    class Program
    {
    

            public static void Main(string[] args)
            {
                List<students> list = new List<students>();
                list.Add(new students() { name = "sree", marks = 80 });
                list.Add(new students() { name = "sanvi", marks = 40 });
                list.Add(new students() { name = "sritha", marks = 50 });
                list.Add(new students() { name = "sreekar", marks = 60 });

                delegates d = new delegates(promotelogic);
                students.promote(list, d);

            }

            public static bool promotelogic(students s)
            {
                if (s.marks > 51)
                    return true;
                else
                    return false;
            }
        }
        public delegate bool delegates(students s);
        public class students
        {
            public string name { get; set; }
            public int marks { get; set; }
            public static void promote(List<students> list, delegates IsEligible)
            {
                foreach (students student in list)
                {
                    if (IsEligible(student))
                    {
                        Console.WriteLine(student.name + "promoted");

                    }
                }
            }

        }
    }

