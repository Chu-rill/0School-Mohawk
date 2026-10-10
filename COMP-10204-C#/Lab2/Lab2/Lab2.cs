using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// I, Churchill Daniel, 000983683 certify that this material is my original work.
    /// No other person's work has been used without due acknowledgement.
    /// </summary>
    internal class Lab2
    {

        static List<Shape> shapes = new List<Shape>(); 
        static void Main(string[] args)
        {
            bool running = true;
           
            while (running)
            {
                string choice = DisplayMenu();

                switch (choice)
                {
                    case "A":
                        Rectangle rec = new Rectangle();
                        shapes.Add(rec);
                        break;
                    case "B":
                        Square sqr = new Square();
                        shapes.Add(sqr);
                        break;
                    case "C":
                        Box box = new Box();
                        shapes.Add(box);
                        break;
                    case "D":
                        Cube cube = new Cube();
                        shapes.Add(cube);
                        break;
                    case "E":
                        Ellipse ellipse = new Ellipse();
                        shapes.Add(ellipse);
                        break;
                    case "F":
                        Circle circle = new Circle();
                        shapes.Add(circle);
                        break;
                    case "G":
                        Cylinder cylinder = new Cylinder();
                        shapes.Add(cylinder);
                        break;
                    case "H":
                        Sphere sphere = new Sphere();
                        shapes.Add(sphere);
                        break;
                    case "I":
                        Triangle triangle = new Triangle();
                        shapes.Add(triangle);
                        break;
                    case "J":
                        Tetrahedron tetrahedron = new Tetrahedron();
                        shapes.Add(tetrahedron);
                        break;
                    case "0":
                        Console.WriteLine($"Number of shapes = {Shape.GetCount()}");
                        Console.WriteLine($"{"Shape",-20} {"Area",-10} {"Volume",-10} {"Details",-10}");
                        Console.WriteLine($"{new string('=',12),-20} {new string('=', 5),-10} {new string('=', 5),-10} {new string('=', 20),-10}");
                        foreach( Shape s in shapes)
                        {
                            Console.WriteLine(s.ToString());
                        }
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

        }

        /// <summary>
        /// Display's the prompt to select the type of shape that should be created
        /// </summary>
        public static string DisplayMenu()
        {
            string choice;
            Console.WriteLine("Churchill's Geometry Class:");
            Console.WriteLine($"{"A - Rectangle",-20} {"E - Ellipse",-20} {"I - Triangle",-20}");
            Console.WriteLine($"{"B - Square",-20} {"F - Circle",-20} {"J - Tetrahedron",-20}");
            Console.WriteLine($"{"C - Box",-20} {"G - Cylinder",-20}");
            Console.WriteLine($"{"D - Cube",-20} {"H - Sphere",-20}");
            Console.WriteLine();
            Console.WriteLine("0 - List all shapes and Exit...");
            Console.Write("Enter choice: ");
            choice = Console.ReadLine().ToUpper();
            return choice;
        }
    }
}
