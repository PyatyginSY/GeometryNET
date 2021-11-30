// <copyright file="Trapezoid.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using System;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the trapezoid.
    /// </summary>
    public static class Trapezoid
    {
        /// <summary>
        /// Returns a trapezoid perimeter.
        /// </summary>
        /// <param name="a">Trapezoid first base length.</param>
        /// <param name="b">Trapezoid second base length.</param>
        /// <param name="c">Trapezoid first side length.</param>
        /// <param name="d">Trapezoid second side length.</param>
        /// <returns>Trapezoid perimeter.</returns>
        public static double GetPerimeter(double a, double b, double c, double d)
        {
            if (a < 0 || b < 0 || c < 0 || d < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' or 'c' or 'd' cannot be negative");
            }

            return a + b + c + d;
        }

        /// <summary>
        /// Returns a trapezoid isosceles perimeter.
        /// </summary>
        /// <param name="a">Trapezoid isosceles first base length.</param>
        /// <param name="b">Trapezoid isosceles second base length.</param>
        /// <param name="c">Trapezoid isosceles side length.</param>
        /// <returns>Trapezoid isosceles perimeter.</returns>
        public static double GetIsoscelesPerimeter(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' or 'c' cannot be negative");
            }

            return a + b + (2 * c);
        }

        /// <summary>
        /// Returns a trapezoid area.
        /// </summary>
        /// <param name="midline">Trapezoid midline length.</param>
        /// <param name="height">Trapezoid height length.</param>
        /// <returns>Trapezoid area.</returns>
        public static double GetAreaByMidlineAndHeight(double midline, double height)
        {
            if (midline < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'midline' or 'height' cannot be negative");
            }

            return midline * height;
        }

        /// <summary>
        /// Returns a trapezoid area.
        /// </summary>
        /// <param name="a">Trapezoid first diagonal length.</param>
        /// <param name="b">Trapezoid second diagonal length.</param>
        /// <param name="angle">Trapezoid angle between two diagonal.</param>
        /// <returns>Trapezoid area.</returns>
        public static double GetAreaByDiagonalAndAngle(double a, double b, double angle)
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
