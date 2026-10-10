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
    /// Represents a regular tetrahedron, a three-dimensional shape made of
    /// four identical triangles, where every edge has the same length.
    /// </summary>
    internal class Tetrahedron : Shape
    {
        public double length {  get; set; }

        /// <summary>
        /// Creates a new Tetrahedron and asks the user the length.
        /// </summary>
        public Tetrahedron()
        {
            SetData();
        }

        /// <summary>
        /// Reads the edge length from the user.
        /// If the input is not a valid number, the exception is displayed
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Length: ");
                length = double.Parse(Console.ReadLine());
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Calculates the area of the tetrahedron.
        /// returns the area as a double
        /// </summary>

        public override double CalculateArea()
        {
            return Math.Sqrt(3) * length * length;
        }

        /// <summary>
        /// Calculates the volume of the tetrahedron.
        /// returns the volume as a double
        /// </summary>
        public override double CalculateVolume()
        {
            return Math.Pow(length, 3) / (6 * Math.Sqrt(2));
        }

        /// <summary>
        /// Returns a formatted table row for Tetrahedron
        /// name, area, volume and the dimensions.
        /// </summary>
        public override string ToString()
        {
            return $"{"Sphere",-20} {CalculateArea(),-10:F2} {CalculateVolume(),-10:F2} {$"Length = {length}",-10}";
        }
           
    }
}
