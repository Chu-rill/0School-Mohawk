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
    /// Rectangle class inherits from the Shape class to perform the 
    /// </summary>
    internal class Rectangle : Shape
    {
        public double length {  get; set; }
        public double width {  get; set; }

        /// <summary>
        /// Creates a new Rectangle and calls the SetData method
        /// </summary>
        public Rectangle()
        {
            SetData();
        }

        /// <summary>
        /// Reads the length and width from the user.
        /// If the input is not a valid number, the exception is displayed.
        /// </summary>
        public override void SetData()
        {
            try
            {
                Console.Write("Enter the Length: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Enter the Width: ");
                width = double.Parse(Console.ReadLine());
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }

        /// <summary>
        /// Calculates the area of the rectangle.
        /// returns the area in a double.
        /// </summary
        public override double CalculateArea()
        {
            return length * width;
        }

        /// <summary>
        /// A rectangle is a 2D shape, so it has no volume
        /// return 0
        /// </summary>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Returns a formatted table row for rectangle
        /// name, area , an empty volume column,and the dimensions.
        /// </summary>
        public override string ToString()
        {
            return $"{"Rectangle",-20} {CalculateArea(),-10:F2} {"",-10} {$"length = {length}, width = {width}",-10}";
        }
    }
}
