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
    /// Represents an ellipse, a two-dimensional oval shape defined by it's two semi-axes.
    /// it inherits from the Shape class
    /// </summary>
    internal class Ellipse : Shape
    {
        public double semiAxisA {  get; set; }
        public double semiAxisB {  get; set; }

        /// <summary>
        /// Creates a new Ellipse and asks the user for the properties
        /// </summary>
        public Ellipse()
        {
            SetData();
        }

        /// <summary>
        /// Get's the two semi-axes (a and b) from the user.
        /// If the input is not a valid number, the exception is displayed
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("first semi-axis (a): ");
                semiAxisA = double.Parse(Console.ReadLine());
                Console.Write("second semi-axis (b): ");
                semiAxisB = double.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Calculates the area of the ellipse.
        /// returns the area as a double
        /// </summary>
        /// <returns>.</returns>
        public override double CalculateArea()
        {
            return Math.PI * semiAxisA * semiAxisB;
        }

        /// <summary>
        /// An ellipse is a 2D shape, so it has no volume
        /// return 0
        /// </summary>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Returns a formatted table row for ellipse
        /// name, area , an empty volume column,and the dimensions.
        /// </summary>
        public override string ToString()
        {
            return $"{"Ellipse",-20} {CalculateArea(),-10:F2} {"",-10} {$"SemiAxisB = {semiAxisA}, SemiAxisB = {semiAxisB}",-10}";
        }
    }
}
