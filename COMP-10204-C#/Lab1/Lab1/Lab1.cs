using System;
using System.Collections.Generic;
using System.IO;


namespace Lab1;

/// <summary>
///I, Churchill Daniel, 000983683 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
/// Lab1 
/// </summary>
internal class Lab1
{
    
    private static void Main(string[] args)
    {
        string path = "/Users/churchill/Developer/0School-Mohawk/COMP-10204-C#/Lab1/Lab1/employees.txt";
        
        Employee[] employees = Read(path);
        
        bool running = true;
        while (running)
        {
            string choice = DisplayMenu();

            switch (choice)
            {
                case "1":
                    Sort(employees,choice);
                    DisplayTable(employees);
                    break;
                case "2":
                    Sort(employees,choice);
                    DisplayTable(employees);
                    break;
                case "3":
                    Sort(employees,choice);
                    DisplayTable(employees);
                    break;
                case "4":
                    Sort(employees,choice);
                    DisplayTable(employees);
                    break;
                case "5":
                    Sort(employees,choice);
                    DisplayTable(employees);
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice please enter a number between 1 to 6.");
                    break;
            }
        }
    }

    /// <summary>
    /// Display's the choice screen for the user to select what
    /// action is to be made
    /// it returns a string 
    /// </summary>
    static string DisplayMenu()
    {
        string choice;
        Console.WriteLine();
        Console.WriteLine("1. Sort by Employee Name");
        Console.WriteLine("2. Sort by Employee Number");
        Console.WriteLine("3. Sort by Employee Pay Rate");
        Console.WriteLine("4. Sort by Employee Hours");
        Console.WriteLine("5. Sort by Employee Gross Pay");
        Console.WriteLine();
        Console.WriteLine("6. Exit");
        Console.Write("Enter choice: ");
        choice =  Console.ReadLine();
        Console.WriteLine();
        return choice;
    }

    /// <summary>
    /// Selection Sort
    /// Organizes the elements in an array in other based on
    /// the choice selected.
    /// https://sortvisualizer.com/selectionsort/
    /// <param name="employees">The array that is to be sorted</param>
    /// <param name="choice">String of the selected choice to determine what type of sorting would be done</param>
    /// </summary>
    static void Sort(Employee[] employees, string choice)
    {
        for (int i = 0; i < employees.Length - 1; i++)
        {
            
            int selected = i;

            for (int j = i + 1; j < employees.Length; j++)
            {
                // break from the loop when it gets to a null slot in the array
                if (employees[j] == null)
                {
                    break;
                }

                if (choice == "1")
                {
                    if (String.Compare(employees[j].GetName(), employees[selected].GetName()) < 0)
                    {
                        selected = j;
                    }
                }


                else if (choice == "2")
                {
                    if (employees[j].GetNumber() < employees[selected].GetNumber())
                    {
                        selected = j;
                    }
                }


                else if (choice == "3")
                {
                    if (employees[j].GetRate() > employees[selected].GetRate())
                    {
                        selected = j;
                    }
                }


                else if (choice == "4")
                {
                    if (employees[j].GetHours() > employees[selected].GetHours())
                    {
                        selected = j;
                    }
                }


                else if (choice == "5")
                {
                    if (employees[j].GetGross() > employees[selected].GetGross())
                    {
                        selected = j;
                    }
                }
            }

            // Swap position make a temp var to store the value of the prevoius value
            Employee temp = employees[i];
            employees[i] = employees[selected];
            employees[selected] = temp;
        }
    }

    /// <summary>
    /// Read method
    /// uses the built-in file IO creates an array of type Employee with a size of 100
    /// and inserts the content of the txt into the array and returns an array
    ///<param name="path">String type to the file path of the txt</param>
    /// </summary>
    static Employee[] Read (string path)
    {
        Employee[] employee = new Employee[100];
        
      
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

        return employee;
    }
    
    /// <summary>
    /// Display's a formatted out-put of the table to show the sort
    /// <param name="employees">The array that is to be displayed</param>
    /// </summary>
    private static void DisplayTable(Employee[] employees)
    {
        Console.WriteLine();
        Console.WriteLine($"{"Name",-20}{"Number",-10}{"Rate",-10}{"Hours",-10}{"Gross Pay",-12}");
        Console.WriteLine(new string('-', 62));

        foreach (Employee e in employees)
        {
            if (e == null)
            {
                break;
            }
            
            Console.WriteLine(
                $"{e.GetName(),-20}{e.GetNumber(),-10}{e.GetRate(),-10:C}{e.GetHours(),-10:F2}{e.GetGross(),-12:C}"
            );
        }
    }
}
