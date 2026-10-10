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
    ///
    /// Represents a triangle,which is a two dimensional shape defined here by it's
    /// base and it's height.
    /// </summary>
    internal class Triangle : Shape
    {
        public double baseLength {  get; set; }
        public double height { get; set; }

        /// <summary>
        /// Creates a new Triangle and asks the user for it's properties
        /// </summary>
        public Triangle()
        {
            SetData();
        }

        /// <summary>
        /// Reads the base and height from the user.
        /// If any input is not a valid number, the exception is displayed
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the base: ");
                baseLength = double.Parse(Console.ReadLine());
                Console.Write("Enter the height: ");
                height = double.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Calculates the area of the triangle.
        /// return the area as a double
        /// </summary>
        public override double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }

        /// <summary>
        /// A triangle is a 2D shape, so it has no volume
        /// return 0
        /// </summary>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Returns a formatted table row for triangle
        /// name, area , an empty volume column,and the dimensions.
        /// </summary>
        public override string ToString()
        {
            return $"{"Triangle",-20} {CalculateArea(),-10:F2} {"",-10} {$"Base = {baseLength} Height = {height}",-10}";
        }
    }
}
