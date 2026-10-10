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
    /// Represents a square which inherits from the rectangle class, whose four sides are equal
    /// Square has no constructor it inherits from  rectangle, the constructor calls SetData(), which is overridden,
    /// The square version runs and asks for one side only.
    /// </summary>
    internal class Square : Rectangle
    {

        /// <summary>
        /// Reads the length from the user (side).
        /// If the input is not a valid number, the exception is displayed.
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the length: ");
                double side = double.Parse(Console.ReadLine());
                length = side;
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Calculates the area of the square.
        /// return the area of the square in double
        /// </summary>
        public override double CalculateArea()
        {
            return Math.Pow(length, 2);
        }

        /// <summary>
        /// Returns a formatted table row for square
        /// name, area , an empty volume column,and the dimensions.
        /// </summary>
        public override string ToString()
        {
            return $"{"Square",-20} {CalculateArea(),-10:F2} {"",-10} {$"length = {length}",-10}";
        }
    }
}
