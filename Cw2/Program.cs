using System;
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

            foreach(var line in lines)
            {
                string[] dane = line.Split(',');
                //Console.WriteLine(dane.Length);
                foreach(var et in dane)
                {
                 if(et == "")
                    {
                        throw new Exception("Nope");
                    }   
                    
                }
            }
            var today = DateTime.Today.ToShortDateString();
        }
    }
}
