using System;
using System.Collections.Generic;
using System.IO;

namespace Lab1;

/// <summary>
/// Lab1 console driver: loads employees from a CSV file into an array,
/// then repeatedly menus the user through five different sorts of that
/// array (plus Exit), displaying a formatted table after each sort.
///
/// Main() holds the menu loop and its switch directly; the rest of the
/// work is broken out into small, single-purpose methods: ReadEmployees /
/// ParseEmployeeLine (loading + validation), DisplayMenu (input),
/// SortEmployees (sorting via lambda comparisons) and DisplayTable (output).
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
                    Console.WriteLine("Invalid choice - please enter a number from 1 to 6.");
                    break;
            }
        }
    }

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
    /// Organizez the elements in an array in other based on
    /// the choice selected.
    /// https://sortvisualizer.com/selectionsort/
    /// </summary>
    static void Sort(Employee[] employees, string choice)
    {
        for (int i = 0; i < employees.Length - 1; i++)
        {
            // Real records are loaded from index 0 onward with no gaps,
            // so once we hit a null slot, everything after it is null too.
            if (employees[i] == null)
            {
                break;
            }

            int selected = i;

            for (int j = i + 1; j < employees.Length; j++)
            {
                // Skip unused slots - nothing to compare them against.
                if (employees[j] == null)
                {
                    continue;
                }

                if (choice == "1")
                {
                    if (String.Compare(employees[j].GetName(), employees[selected].GetName()) < 0)
                    {
                        selected = j;
                    }
                }

                // 2. Employee Number - ascending
                else if (choice == "2")
                {
                    if (employees[j].GetNumber() < employees[selected].GetNumber())
                    {
                        selected = j;
                    }
                }

                // 3. Employee Pay Rate - descending
                else if (choice == "3")
                {
                    if (employees[j].GetRate() > employees[selected].GetRate())
                    {
                        selected = j;
                    }
                }

                // 4. Employee Hours - descending
                else if (choice == "4")
                {
                    if (employees[j].GetHours() > employees[selected].GetHours())
                    {
                        selected = j;
                    }
                }

                // 5. Employee Gross Pay - descending
                else if (choice == "5")
                {
                    if (employees[j].GetGross() > employees[selected].GetGross())
                    {
                        selected = j;
                    }
                }
            }

            // Swap
            Employee temp = employees[i];
            employees[i] = employees[selected];
            employees[selected] = temp;
        }
    }

    /// <summary>
    /// Reads employee records from a comma-separated file into an array,
    /// skipping (and reporting) any line that fails to parse instead of
    /// aborting the whole load. The array is trimmed to the number of
    /// valid records actually read, so its Length is the record count.
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
    /// Prints a neatly aligned table of every employee in the array, in
    /// whatever order the array is currently sorted in.
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
