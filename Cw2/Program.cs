using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var path = @args[0]; //@"C:\Users\vinve\Desktop\APBD\Zajęcia 2\dane.csv";
                var pathtoSave = @args[1];
                var typeFile = args[2];

                var lines = File.ReadLines(path);
                var set = new HashSet<Student>(new OwnComparer());
                var cleanedSet = new HashSet<Student>(new OwnComparer());
                using (StreamWriter toLogWriter = new StreamWriter(@"./log.txt"))

                {
                    Console.WriteLine(@".");
                    foreach (var line in lines)
                    {
                        string[] dane = line.Split(',');

                        if (dane.Length != 9)
                        {
                            toLogWriter.WriteLine(line);
                        }
                        else
                        {
                            Student nextStudent = new Student(dane[0], dane[1], dane[2], dane[3], dane[4], dane[5], dane[6], dane[7], dane[8]);
                            if (!set.Add(nextStudent))
                            {
                                toLogWriter.WriteLine(nextStudent.ToString());

                            }

                        }


                    }

                    foreach (Student i in set)
                    {
                        if (i.IfStudent())
                        {
                            toLogWriter.WriteLine(i.ToString());

                        }
                        else
                        {
                            cleanedSet.Add(i);
                        }


                    }

                    XmlRootAttribute xm = new XmlRootAttribute();


                    xm.ElementName = "uczelnia " + "createdAt " + DateTime.Today.ToShortDateString() + " Author Natalia Kowalska";

                    XmlSerializer serializer = new XmlSerializer(typeof(HashSet<Student>), xm);



                    try
                    {
                        StreamWriter streamWriter = new StreamWriter(pathtoSave);


                        serializer.Serialize(streamWriter, cleanedSet);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        // obsluga wyjatkow
                    }



                }
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Za malo argumentow");
            }catch(ArgumentException e)
            {
                Console.WriteLine("Podana sciezka jest niepoprawna");
            }catch(FileNotFoundException e)
            {
                Console.WriteLine("Plik nie istnieje");
            }
        }
    }

}