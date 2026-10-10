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
    /// Represents a circle, a special ellipse whose two semi-axes are equal.
    /// Circle has no constructor it inherits from  Ellipse, the constructor calls SetData(), which is overridden,
    /// The Circle version runs and asks for the radius
    /// </summary>
    internal class Circle : Ellipse
    {
        private double radius;

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
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// returns the area as a double
        /// </summary>
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Returns a formatted table row for Circle
        /// name, area , an empty volume column,and the dimensions.
        /// </summary>
        public override string ToString()
        {

            return $"{"Circle",-20} {CalculateArea(),-10:F2} {"",-10} {$"Radius = {radius}",-10}";
        }
    }
}
