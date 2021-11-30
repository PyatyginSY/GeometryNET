// <copyright file="Square.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using System;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the square.
    /// </summary>
    public static class Square
    {
        /// <summary>
        /// Returns a square perimeter.
        /// </summary>
        /// <param name="a">Square side length.</param>
        /// <returns>Square perimeter.</returns>
        public static double GetPerimeter(double a)
        {
            if (a < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' cannot be negative");
            }

            return 4 * a;
        }

        /// <summary>
        /// Returns a square area.
        /// </summary>
        /// <param name="a">Square side length.</param>
        /// <returns>Square area.</returns>
        public static double GetArea(double a)
        {
            if (a < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' cannot be negative");
            }

            return Math.Pow(a, 2);
        }
    }
}
