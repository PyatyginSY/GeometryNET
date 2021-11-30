// <copyright file="Сircle.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using System;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the circle.
    /// </summary>
    public static class Сircle
    {
        /// <summary>
        /// Returns a circle perimeter.
        /// </summary>
        /// <param name="diameter">Circle diameter.</param>
        /// <returns>Circle perimeter.</returns>
        public static double GetPerimeterByDiameter(double diameter)
        {
            if (diameter < 0)
            {
                throw new GeometryArgumentException("Parameter 'diameter' cannot be negative");
            }

            return Math.PI * diameter;
        }

        /// <summary>
        /// Returns a circle perimeter.
        /// </summary>
        /// <param name="radius">Circle radius.</param>
        /// <returns>Circle perimeter.</returns>
        public static double GetPerimeterByRadius(double radius)
        {
            if (radius < 0)
            {
                throw new GeometryArgumentException("Parameter 'radius' cannot be negative");
            }

            return 2 * radius * Math.PI;
        }

        /// <summary>
        /// Returns a circle area.
        /// </summary>
        /// <param name="diameter">Circle diameter.</param>
        /// <returns>Circle area.</returns>
        public static double GetAreaByDiameter(double diameter)
        {
            if (diameter < 0)
            {
                throw new GeometryArgumentException("Parameter 'diameter' cannot be negative");
            }

            return Math.PI * Math.Pow(diameter, 2) / 4;
        }

        /// <summary>
        /// Returns a circle area.
        /// </summary>
        /// <param name="radius">Circle radius.</param>
        /// <returns>Circle area.</returns>
        public static double GetAreaByRadius(double radius)
        {
            if (radius < 0)
            {
                throw new GeometryArgumentException("Parameter 'radius' cannot be negative");
            }

            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Returns a circle area.
        /// </summary>
        /// <param name="length">Circle circumference.</param>
        /// <returns>Circle area.</returns>
        public static double GetAreaBycCircumference(double length)
        {
            if (length < 0)
            {
                throw new GeometryArgumentException("Parameter 'length' cannot be negative");
            }

            return Math.Pow(length, 2) / (4 * Math.PI);
        }
    }
}
