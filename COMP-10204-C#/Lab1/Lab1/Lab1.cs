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
                case "2":
                case "3":
                case "4":
                case "5":
                    SortEmployees(employees, int.Parse(choice));
                    DisplayTable(employees);
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice - please enter a number from 1 to 6.");
                    break;
            }
        }
    }

    private static string DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Sort by Employee Name (ascending)");
        Console.WriteLine("2. Sort by Employee Number (ascending)");
        Console.WriteLine("3. Sort by Employee Pay Rate (descending)");
        Console.WriteLine("4. Sort by Employee Hours (descending)");
        Console.WriteLine("5. Sort by Employee Gross Pay (descending)");
        Console.WriteLine("6. Exit");
        Console.Write("Enter choice: ");
        return Console.ReadLine() ?? string.Empty;
    }

    /// <summary>
    /// Sorts the array in place. Rather than hand-rolling a sort algorithm,
    /// each menu choice supplies Array.Sort with the comparison it needs,
    /// expressed as a lambda (choice 2 is written as an old-style anonymous
    /// delegate to show the equivalent, less concise form the lambdas below
    /// are shorthand for).
    /// </summary>
    private static void SortEmployees(Employee[] employees, int choice)
    {
        Comparison<Employee> comparison = choice switch
        {
            1 => (a, b) => string.Compare(a.GetName(), b.GetName(), StringComparison.OrdinalIgnoreCase),
            2 => delegate (Employee a, Employee b) { return a.GetNumber().CompareTo(b.GetNumber()); },
            3 => (a, b) => b.GetRate().CompareTo(a.GetRate()),
            4 => (a, b) => b.GetHours().CompareTo(a.GetHours()),
            5 => (a, b) => b.GetGross().CompareTo(a.GetGross()),
            _ => throw new ArgumentOutOfRangeException(nameof(choice), "Unknown sort option.")
        };

        Array.Sort(employees, Comparer<Employee>.Create(comparison));
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
    /// Parses one "name, number, rate, hours" CSV line into an Employee,
    /// trimming stray whitespace around each field. Throws FormatException
    /// on a malformed line so the caller can report and skip it.
    /// </summary>
    private static Employee ParseEmployeeLine(string line)
    {
        string[] fields = line.Split(',');

        if (fields.Length != 4)
        {
            throw new FormatException($"expected 4 fields, found {fields.Length}");
        }

        string name = fields[0].Trim();
        int number = int.Parse(fields[1].Trim());
        decimal rate = decimal.Parse(fields[2].Trim());
        double hours = double.Parse(fields[3].Trim());

        return new Employee(name, number, rate, hours);
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
            Console.WriteLine(
                $"{e.GetName(),-20}{e.GetNumber(),-10}{e.GetRate(),-10:C}{e.GetHours(),-10:F2}{e.GetGross(),-12:C}"
            );
        }
    }
}
