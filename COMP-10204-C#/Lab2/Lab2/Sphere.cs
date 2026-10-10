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
    /// Represents a sphere, a perfectly round three dimensional shape
    /// where every point on the surface is the same distance, the radius (r),
    /// from the centre.
    /// </summary>
    internal class Sphere : Shape
    {
        public double radius { get; set; }

        /// <summary>
        /// Creates a new Sphere and asks the user for the radius
        /// </summary>
        public Sphere()
        {
            SetData();
        }

        /// <summary>
        /// Reads the radius from the user.
        /// If the input is not a valid number, the exception is displayed
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter Radius: ");
                radius = double.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Calculates the area of the sphere.
        /// return the area as a double
        /// </summary>
        public override double CalculateArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Calculates the volume of the sphere.
        /// return the volume as a double
        /// </summary>
        public override double CalculateVolume()
        {
            return 4.0/3.0 * Math.PI * Math.Pow(radius, 3);
        }

        /// <summary>
        /// Returns a formatted table row for Sphere
        /// name, area, volume and the dimensions.
        /// </summary>
        public override string ToString()
        {
            return $"{"Sphere",-20} {CalculateArea(),-10:F2} {CalculateVolume(),-10:F2} {$"Radius = {radius}",-10}";
        }
    }
}
