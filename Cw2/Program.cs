using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;


namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var path = @"C:\Users\vinve\Desktop\APBD\Zajęcia 2\dane.csv";
            var lines = File.ReadLines(path);
            var set = new HashSet<Student>(new OwnComparer());
            var cleanedSet = new HashSet<Student>(new OwnComparer());
            var logArray = new List<Student>();
            foreach (var line in lines)
            {
                string[] dane = line.Split(',');
               
                if (dane.Length != 9)
                {
                    // line do loga
                }
                else
                { 
                    Student nextStudent = new Student(dane[0], dane[1], dane[2], dane[3], dane[4], dane[5], dane[6], dane[7], dane[8]);
                    if (!set.Add(nextStudent))
                    {
                        logArray.Add(nextStudent);                    }
                   
                }
                

            }
            
            foreach (Student i in set)
            {
                if (i.IfStudent())
                {
                    Console.WriteLine(i.fathersName);
                    logArray.Add(i);
                }
                else
                {
                    cleanedSet.Add(i);
                }
               
              
            }
Console.WriteLine(cleanedSet.Count());
            Console.WriteLine(logArray.Count());
            var today = DateTime.Today.ToShortDateString();
        }
    }
}

