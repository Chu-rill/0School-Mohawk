using System;
using System.IO;
namespace Lab1;



public class Lab1
{
    Employee[] employee = new Employee[100];
    public static void Main(string[] args)
    {
        
        string path = "/Users/churchill/Developer/0School-Mohawk/COMP-10204-C#/Lab1/Lab1/employees.txt";
        FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
        StreamReader data = new StreamReader(file);
        // Console.WriteLine(data);
        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        // bool running = true;
        // while (running)
        // {
        //     Console.WriteLine("1. Sort by Employee Name");
        //     Console.WriteLine("2. Sort by Employee Number");
        //     Console.WriteLine("3. Sort by Employee Pay rate");
        //     Console.WriteLine("4. Sort by Employee Hours");
        //     Console.WriteLine("5. Sort by Employee Gross Pay");
        //     Console.WriteLine("");
        //     Console.WriteLine("6. Exit");
        //     Console.Write("Enter choice: ");
        //     int choice = Convert.ToInt32(Console.ReadLine());
        //
        //     if (choice == 6)
        //     {
        //         running = false;
        //     }
        // }
    }
}