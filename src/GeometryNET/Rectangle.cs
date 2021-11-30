// <copyright file="Rectangle.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the rectangle.
    /// </summary>
    public static class Rectangle
    {
        /// <summary>
        /// Returns a rectangle perimeter.
        /// </summary>
        /// <param name="width">Rectangle width length.</param>
        /// <param name="height">Rectangle height length.</param>
        /// <returns>Rectangle perimeter.</returns>
        public static double GetPerimeter(double width, double height)
        {
            if (width < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'width' or 'height' cannot be negative");
            }

            return 2 * (width + height);
        }

        /// <summary>
        /// Returns a rectangle area.
        /// </summary>
        /// <param name="width">Rectangle width length.</param>
        /// <param name="height">Rectangle height length.</param>
        /// <returns>Rectangle area.</returns>
        public static double GetArea(double width, double height)
        {
            if (width < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'width' or 'height' cannot be negative");
            }

            return width * height;
        }
    }
}
