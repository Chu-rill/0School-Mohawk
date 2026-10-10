/*
Class: Shape.cs
Author: Nicholas J. Corkigian
Date: May 15, 2026
Purpose: This abstract class is the base class of an object hierarchy
that describes many other two-dimensional and three-dimensional
shapes.
As it is an abstract class, there can be no instances of it.
This code is not to be altered.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lab2
{
    /// <summary>
    /// Serves as the abstract base class for geometric shapes, providing a common interface for calculating area, volume,
    /// and managing shape data.
    /// </summary>
    /// <remarks>Derive from <see cref="Shape"/> to implement specific types of shapes, such as circles,
    /// rectangles, or three-dimensional solids. Subclasses must provide implementations for calculating area and volume,
    /// as well as for setting shape-specific data.</remarks>
    public abstract class Shape
    {
        private static int count = 0; // Number of instantiated shapes
        /// <summary>
        /// All this constructor does is increment the number of Shape instances.
        /// </summary>
        public Shape()
        {
            count++;
        }
        /// <summary>
        /// Calculate the Shape's area.
        /// </summary>
        /// <returns>The area of the shape if 2D or the surface area if 3D.</returns>
        /// <remarks>Subclasses must provide an implementation for this method to calculate the area specific to the shape type.</remarks>
        public abstract double CalculateArea();
        /// <summary>
        /// Calculate the Shape's volume.
        /// </summary>
        /// <returns>Volume of the shape if 3D, otherwise 0 can be returned.</returns>
        /// <remarks>Subclasses must provide an implementation for this method to calculate the volume specific to the shape type.</remarks>
        public abstract double CalculateVolume();
        /// <summary>
        /// Prompts the user for all specific dimensions (length, width, radius, side,etc) of the shape.
        /// </summary>
        /// <remarks>Subclasses must provide an implementation for this method to gather shape-specific data from the user.</remarks>
        public abstract void SetData();
        /// <summary>
        /// Used for printing Shape data to the console. This method is overridden in each subclass to provide the appropriate information.
        /// </summary>
        /// <returns>A formatted string reprsentation of the shape, suitable for printing in a table.</returns>
        /// <remarks>Subclasses must provide an implementation for this method to return a string representation of the shape's data.</remarks>
        public override string ToString()
        {
            return "";
        }
        /// <summary>
        /// Retrieves the current number of Shape instances.
        /// </summary>
        /// <returns>An integer representing the current number of instantiated shape objects.</returns>
        /// <remarks>This static method allows external code to access the count of instantiated shapes, which is maintained by the constructor.</remarks>
        public static int GetCount()
        {
            return count;
        }
    }
}