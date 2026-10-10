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
    /// Represents a cylinder which is a three dimensional shape with two identical
    /// circular ends of radius, separated by a height.
    /// </summary>
    internal class Cylinder : Shape
    {
        public double radius { get; set; }
        public double height {  get; set; }

        /// <summary>
        /// Creates a new Cylinder and asks the user for the properties
        /// </summary>
        public Cylinder()
        {
            SetData();
        }

        /// <summary>
        /// Reads the radius and height from the user.
        /// If any input is not a valid number, the exception is displayed
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter radius: ");
                radius = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                height = double.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Calculates the area of the cylinder.
        /// returns the area as a double
        /// </summary>
        public override double CalculateArea()
        {
            return 2 * Math.PI * radius * (radius + height);
        }

        /// <summary>
        /// Calculates the volume of the cylinder.
        /// returns the volume in as a double
        /// </summary>
        public override double CalculateVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        /// <summary>
        /// Returns a formatted table row for Cylinder
        /// name, area, volume and the dimensions.
        /// </summary>
        public override string ToString()
        {

            return $"{"Cylinder",-20} {CalculateArea(),-10:F2} {CalculateVolume(),-10:F2} {$"Radius = {radius}, Height = {height}",-10}";
        }
    }
}
