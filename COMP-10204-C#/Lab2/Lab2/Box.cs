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
    /// Represents the Box class that inherits from the Shape class,it is a three dimensional shape
    /// it has 3 properties length, width and height.
    /// </summary>
    internal class Box : Shape
    {
        public double length {  get; set; }
        public double width {  get; set; }
        public double height {  get; set; }

        /// <summary>
        /// Creates a new Box and asks the user for properties.
        /// </summary>
        public Box()
        {
            SetData();
        }

        /// <summary>
        /// Reads the length, width and height from the user.
        /// If any input is not a valid number, the exception is displayed
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Length: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Enter the Width: ");
                width = double.Parse(Console.ReadLine());
                Console.Write("Enter the height: ");
                height = double.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Calculates the total area of the box.
        /// Returns the surface area in double
        /// </summary>
        public override double CalculateArea()
        {
            return 2 * (length * width + length * height + width * height);
        }

        /// <summary>
        /// Calculates the volume of the box.
        /// Returns the volume in double
        /// </summary>
        public override double CalculateVolume()
        {
            return length * width * height;
        }

        /// <summary>
        /// Returns a formatted table row for Box
        /// name, area, volume and the dimensions.
        /// </summary>
        public override string ToString()
        {
            return $"{"Box",-20} {CalculateArea(),-10:F2} {CalculateVolume(),-10:F2} {$"length = {length}, width = {width}, height = {height}",-10}";
        }
    }
}
