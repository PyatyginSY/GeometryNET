// <copyright file="Rhombus.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using System;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the rhombus.
    /// </summary>
    public static class Rhombus
    {
        /// <summary>
        /// Returns a rhombus perimeter.
        /// </summary>
        /// <param name="a">Rhombus side length.</param>
        /// <returns>Rhombus perimeter.</returns>
        public static double GetPerimeter(double a)
        {
            if (a < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' cannot be negative");
            }

            return 4 * a;
        }

        /// <summary>
        /// Returns a rhombus area.
        /// </summary>
        /// <param name="a">Rhombus side length.</param>
        /// <param name="height">Rhombus height length.</param>
        /// <returns>Rhombus area.</returns>
        public static double GetAreaBySideAndHeight(double a, double height)
        {
            if (a < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'height' cannot be negative");
            }

            return a * height;
        }

        /// <summary>
        /// Returns a rhombus area.
        /// </summary>
        /// <param name="a">Rhombus side length.</param>
        /// <param name="angle">Rhombus angle between two side.</param>
        /// <returns>Rhombus area.</returns>
        public static double GetAreaBySideAndAngle(double a, double angle)
        {
            if (a < 0 || angle < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'angle' cannot be negative");
            }

            if (angle > 180)
            {
                throw new GeometryArgumentException("Parameter 'angle' cannot be more than 180");
            }

            return Math.Pow(a, 2) * Math.Sin(Math.PI * angle / 180.0);
        }

        /// <summary>
        /// Returns a rhombus area.
        /// </summary>
        /// <param name="a">Rhombus first diagonal length.</param>
        /// <param name="b">Rhombus second diagonal length.</param>
        /// <returns>Rhombus area.</returns>
        public static double GetAreaByDiagonal(double a, double b)
        {
            if (a < 0 || b < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' cannot be negative");
            }

            return (a * b) / 2;
        }
    }
}
