using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Lab3
    {
        static void Main(string[] args)
        {
            string DataPath = "..//..//Data.txt";
        }

        static List<Media> Read(string path)
        {
            List<Media> media = new List<Media>();

            try
            {
                StreamReader reader = new StreamReader(path);
                int index = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] explode = line.Split(',');

                    string name = explode[0];
                    int number = int.Parse(explode[1]);
                    decimal rate = decimal.Parse(explode[2]);
                    double hours = double.Parse(explode[3]);

                    Employee e = new Employee(name, number, rate, hours);
                    employee[index] = e;
                    index++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return media;
        }
    }
}
