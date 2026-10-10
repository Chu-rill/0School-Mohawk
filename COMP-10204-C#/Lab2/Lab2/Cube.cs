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
    /// Cube has no constructor it inherits from  box, the constructor calls SetData(), which is overridden,
    /// The cube version runs and asks for one side only.
    /// </summary>
    internal class Cube : Box
    {
        /// <summary>
        /// Reads the side length from the user
        /// If the input is not a valid number, the exception is displayed
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the length: ");
                length = double.Parse(Console.ReadLine());
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Calculates the area of the cube.
        /// A cube has 6 identical side.
        /// returns the area in a double
        /// </summary
        public override double CalculateArea()
        {
            return 6 * Math.Pow(length, 2);
        }

        /// <summary>
        /// Calculates the volume of the cube.
        /// returns the volume in a double
        /// </summary>
        public override double CalculateVolume()
        {
            return length * length * length;
        }

        /// <summary>
        /// Returns a formatted table row for Cube
        /// name, area, volume and the dimensions.
        /// </summary>
        public override string ToString()
        {
            return $"{"Cube",-20} {CalculateArea(),-10:F2} {CalculateVolume(),-10:F2} {$"length = {length}",-15}";
        }
    }
}
