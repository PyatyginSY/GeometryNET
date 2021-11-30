// <copyright file="Parallelogram.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using System;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the Parallelogram.
    /// </summary>
    public static class Parallelogram
    {
        /// <summary>
        /// Returns a parallelogram perimeter.
        /// </summary>
        /// <param name="a">Parallelogram first side length.</param>
        /// <param name="b">Parallelogram second side length.</param>
        /// <returns>Parallelogram perimeter.</returns>
        public static double GetPerimeter(double a, double b)
        {
            if (a < 0 || b < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' cannot be negative");
            }

            return 2 * (a + b);
        }

        /// <summary>
        /// Returns a parallelogram area.
        /// </summary>
        /// <param name="a">Parallelogram side length.</param>
        /// <param name="height">Parallelogram side height.</param>
        /// <returns>Parallelogram area.</returns>
        public static double GetAreaBySideAndHeight(double a, double height)
        {
            if (a < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'height' cannot be negative");
            }

            return a * height;
        }

        /// <summary>
        /// Returns a parallelogram area.
        /// </summary>
        /// <param name="a">Parallelogram first side length.</param>
        /// <param name="b">Parallelogram second side length.</param>
        /// <param name="angle">Parallelogram angle between two side.</param>
        /// <returns>Parallelogram area.</returns>
        public static double GetAreaBySideAndAngle(double a, double b, double angle)
        {
            if (a < 0 || b < 0 || angle < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' or 'angle' cannot be negative");
            }

            if (angle > 180)
            {
                throw new GeometryArgumentException("Parameter 'angle' cannot be more than 180");
            }

            return a * b * Math.Sin(Math.PI * angle / 180.0);
        }

        /// <summary>
        /// Returns a parallelogram area.
        /// </summary>
        /// <param name="a">Parallelogram first diagonal length.</param>
        /// <param name="b">Parallelogram second diagonal length.</param>
        /// <param name="angle">Parallelogram angle between two diagonal.</param>
        /// <returns>Parallelogram area.</returns>
        public static double GetAreaByDiagonal(double a, double b, double angle)
        {
            if (a < 0 || b < 0 || angle < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' or 'angle' cannot be negative");
            }

            if (angle > 180)
            {
                throw new GeometryArgumentException("Parameter 'angle' cannot be more than 180");
            }

            return 0.5 * a * b * Math.Sin(Math.PI * angle / 180.0);
        }
    }
}
