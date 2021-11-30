// <copyright file="Triangle.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using System;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the triangle.
    /// </summary>
    public static class Triangle
    {
        /// <summary>
        /// Returns a triangle perimeter.
        /// </summary>
        /// <param name="a">Triangle first side length.</param>
        /// <param name="b">Triangle second side length.</param>
        /// <param name="c">Triangle third side length.</param>
        /// <returns>Triangle perimeter.</returns>
        public static double GetPerimeterByThreeSide(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' or 'c' cannot be negative");
            }

            if ((a + b <= c) || a + c <= b || b + c <= a)
            {
                throw new GeometryArgumentException("Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter");
            }

            return a + b + c;
        }

        /// <summary>
        /// Returns a triangle equilateral perimeter.
        /// </summary>
        /// <param name="a">Triangle equilateral side length.</param>
        /// <returns>Triangle equilateral perimeter.</returns>
        public static double GetEquilateralPerimeterBySide(double a)
        {
            if (a < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' cannot be negative");
            }

            return 3 * a;
        }

        /// <summary>
        /// Returns a triangle area.
        /// </summary>
        /// <param name="a">Triangle one side length adjacent to a angle.</param>
        /// <param name="b">Triangle the other side length is adjacent to the angle.</param>
        /// <param name="angle">Triangle angle between two side.</param>
        /// <returns>Triangle area.</returns>
        public static double GetAreaByTwoSideAndAngle(double a, double b, double angle)
        {
            if (a < 0 || b < 0 || angle < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' or 'angle' cannot be negative");
            }

            if (angle >= 180)
            {
                throw new GeometryArgumentException("Parameter 'angle' cannot be greater than or equal 180");
            }

            return 0.5 * a * b * Math.Sin(Math.PI * angle / 180.0);
        }

        /// <summary>
        /// Returns a triangle area.
        /// </summary>
        /// <param name="a">Triangle base length.</param>
        /// <param name="h">Triangle height length.</param>
        /// <returns>Triangle area.</returns>
        public static double GetAreaByBaseAndHeight(double a, double h)
        {
            if (a < 0 || h < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'h' cannot be negative");
            }

            return 0.5 * a * h;
        }

        /// <summary>
        /// Returns a triangle area.
        /// </summary>
        /// <param name="a">Triangle one side length adjacent to the angles.</param>
        /// <param name="angleAlpha">Triangle first angle adjacent to one side.</param>
        /// <param name="angleBetta">Triangle second angle adjacent to one side.</param>
        /// <returns>Triangle area.</returns>
        public static double GetAreaBySideAndTwoAngle(double a, double angleAlpha, double angleBetta)
        {
            if (a < 0 || angleAlpha < 0 || angleBetta < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'angleAlpha' or 'angleBetta' cannot be negative");
            }

            if (angleAlpha + angleBetta >= 180)
            {
                throw new GeometryArgumentException("Parameter 'angleAlpha + angleBetta'  cannot be greater than or equal 180");
            }

            return Math.Pow(a, 2) / 2 * (Math.Sin(Math.PI * angleAlpha / 180.0) * Math.Sin(Math.PI * angleBetta / 180.0)) / Math.Sin(Math.PI * (180 - (angleAlpha + angleBetta)) / 180.0);
        }

        /// <summary>
        /// Returns a triangle area.
        /// </summary>
        /// <param name="a">Triangle first side length.</param>
        /// <param name="b">Triangle second side length.</param>
        /// <param name="c">Triangle third side length.</param>
        /// <param name="radius">Triangle circumscribed circle radius.</param>
        /// <returns>Triangle area.</returns>
        public static double GetAreaByCircumscribedСircleAndTreeSide(double a, double b, double c, double radius)
        {
            if (a < 0 || b < 0 || c < 0 || radius < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' or 'c' or 'radius' cannot be negative");
            }

            if ((a + b <= c) || a + c <= b || b + c <= a)
            {
                throw new GeometryArgumentException("Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter");
            }

            return (a * b * c) / (4 * radius);
        }

        /// <summary>
        /// Returns a triangle area.
        /// </summary>
        /// <param name="a">Triangle first side length.</param>
        /// <param name="b">Triangle second side length.</param>
        /// <param name="c">Triangle third side length.</param>
        /// <param name="radius">Triangle inscribed circle radius.</param>
        /// <returns>Triangle area.</returns>
        public static double GetAreaByInscribedСircleAndTreeSide(double a, double b, double c, double radius)
        {
            if (a < 0 || b < 0 || c < 0 || radius < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' or 'c' or 'radius' cannot be negative");
            }

            if ((a + b <= c) || a + c <= b || b + c <= a)
            {
                throw new GeometryArgumentException("Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter");
            }

            return radius * (a + b + c) / 2;
        }

        /// <summary>
        /// Returns a triangle area.
        /// </summary>
        /// <param name="a">Triangle first side length.</param>
        /// <param name="b">Triangle second side length.</param>
        /// <param name="c">Triangle third side length.</param>
        /// <returns>Triangle area.</returns>
        public static double GetAreaByHeron(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' or 'c' cannot be negative");
            }

            if ((a + b <= c) || a + c <= b || b + c <= a)
            {
                throw new GeometryArgumentException("Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter");
            }

            var semiPerimeter = GetPerimeterByThreeSide(a, b, c) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
        }

        /// <summary>
        /// Returns a triangle equilateral area.
        /// </summary>
        /// <param name="radius">Triangle equilateral circumscribed circle radius.</param>
        /// <returns>Triangle equilateral area.</returns>
        public static double GetEquilateralAreaByCircumscribedСircle(double radius)
        {
            if (radius < 0)
            {
                throw new GeometryArgumentException("Parameter 'radius' cannot be negative");
            }

            return (3 * Math.Sqrt(3) * Math.Pow(radius, 2)) / 4;
        }

        /// <summary>
        /// Returns a triangle equilateral area.
        /// </summary>
        /// <param name="radius">Triangle equilateral inscribed circle radius.</param>
        /// <returns>Triangle equilateral area.</returns>
        public static double GetEquilateralAreaByInscribedСircle(double radius)
        {
            if (radius < 0)
            {
                throw new GeometryArgumentException("Parameter 'radius' cannot be negative");
            }

            return 3 * Math.Sqrt(3) * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Returns a triangle equilateral area.
        /// </summary>
        /// <param name="a">Triangle equilateral side length.</param>
        /// <returns>Triangle equilateral area.</returns>
        public static double GetEquilateralAreaBySide(double a)
        {
            if (a < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' cannot be negative");
            }

            return (Math.Sqrt(3) * Math.Pow(a, 2)) / 4;
        }

        /// <summary>
        /// Returns a triangle equilateral area.
        /// </summary>
        /// <param name="height">Triangle equilateral height length.</param>
        /// <returns>Triangle equilateral area.</returns>
        public static double GetEquilateralAreaByHeight(double height)
        {
            if (height < 0)
            {
                throw new GeometryArgumentException("Parameter 'height' cannot be negative");
            }

            return Math.Pow(height, 2) / Math.Sqrt(3);
        }

        /// <summary>
        /// Returns a triangle right area.
        /// </summary>
        /// <param name="a">Triangle right one side length adjacent to a right angle.</param>
        /// <param name="b">Triangle right the other side length is adjacent to the right angle.</param>
        /// <returns>Triangle right area.</returns>
        public static double GetRightAreaByTwoCathetus(double a, double b)
        {
            if (a < 0 || b < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' cannot be negative");
            }

            return 0.5 * a * b;
        }

        /// <summary>
        /// Returns a triangle right area.
        /// </summary>
        /// <param name="hypotenuse">Triangle right hypotenuse length.</param>
        /// <param name="angle">Triangle right angle adjacent to hypotenuse.</param>
        /// <returns>Triangle right area.</returns>
        public static double GetRightAreaByHypotenuseAndAngle(double hypotenuse, double angle)
        {
            if (hypotenuse < 0 || angle < 0)
            {
                throw new GeometryArgumentException("Parameter 'hypotenuse' or 'angle' cannot be negative");
            }

            if (angle >= 90)
            {
                throw new GeometryArgumentException("Parameter 'angle' cannot be greater than or equal 90");
            }

            return 0.25 * Math.Pow(hypotenuse, 2) * Math.Sin(2 * Math.PI * angle / 180.0);
        }

        /// <summary>
        /// Returns a triangle right area.
        /// </summary>
        /// <param name="сathetus">Triangle right сathetus length.</param>
        /// <param name="angle">Triangle right angle adjacent to сathetus.</param>
        /// <returns>Triangle right area.</returns>
        public static double GetRightAreaByCathetusAndAngle(double сathetus, double angle)
        {
            if (сathetus < 0 || angle < 0)
            {
                throw new GeometryArgumentException("Parameter 'сathetus' or 'angle' cannot be negative");
            }

            if (angle >= 90)
            {
                throw new GeometryArgumentException("Parameter 'angle' cannot be greater than or equal 90");
            }

            return 0.5 * Math.Pow(сathetus, 2) * Math.Tan(Math.PI * angle / 180.0);
        }

        /// <summary>
        /// Returns a triangle right area.
        /// </summary>
        /// <param name="hypotenuse">Triangle right hypotenuse length.</param>
        /// <param name="radius">Triangle inscribed circle radius.</param>
        /// <returns>Triangle right area.</returns>
        public static double GetRightAreaByInscribedСircleAndHypotenuse(double hypotenuse, double radius)
        {
            if (hypotenuse < 0 || radius < 0)
            {
                throw new GeometryArgumentException("Parameter 'hypotenuse' or 'radius' cannot be negative");
            }

            return radius * (radius + hypotenuse);
        }

        /// <summary>
        /// Returns a triangle isosceles area.
        /// </summary>
        /// <param name="a">Triangle isosceles side length.</param>
        /// <param name="b">Triangle isosceles base length.</param>
        /// <returns>Triangle isosceles area.</returns>
        public static double GetIsoscelesAreaByBaseAndSide(double a, double b)
        {
            if (a < 0 || b < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'b' cannot be negative");
            }

            return b / 4 * Math.Sqrt((4 * Math.Pow(a, 2)) - Math.Pow(b, 2));
        }

        /// <summary>
        /// Returns a triangle isosceles area.
        /// </summary>
        /// <param name="b">Triangle isosceles base length.</param>
        /// <param name="height">Triangle isosceles height length.</param>
        /// <returns>Triangle isosceles area.</returns>
        public static double GetIsoscelesAreaByBaseAndHeight(double b, double height)
        {
            if (b < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'b' or 'height' cannot be negative");
            }

            return 0.5 * b * height;
        }

        /// <summary>
        /// Returns a triangle isosceles area.
        /// </summary>
        /// <param name="a">Triangle isosceles side length.</param>
        /// <param name="angle">Triangle isosceles angle between two side.</param>
        /// <returns>Triangle isosceles area.</returns>
        public static double GetIsoscelesAreaBySideAndAngle(double a, double angle)
        {
            if (a < 0 || angle < 0)
            {
                throw new GeometryArgumentException("Parameter 'a' or 'angle' cannot be negative");
            }

            if (angle >= 90)
            {
                throw new GeometryArgumentException("Parameter 'angle' cannot be greater than or equal 90");
            }

            return 0.5 * Math.Pow(a, 2) * Math.Sin(Math.PI * angle / 180.0);
        }

        /// <summary>
        /// Returns a triangle isosceles area.
        /// </summary>
        /// <param name="b">Triangle isosceles base length.</param>
        /// <param name="angle">Triangle isosceles angle between two side.</param>
        /// <returns>Triangle isosceles area.</returns>
        public static double GetIsoscelesAreaByBaseAndAngle(double b, double angle)
        {
            if (b < 0 || angle < 0)
            {
                throw new GeometryArgumentException("Parameter 'b' or 'angle' cannot be negative");
            }

            if (angle >= 90)
            {
                throw new GeometryArgumentException("Parameter 'angle' cannot be greater than or equal 90");
            }

            return Math.Pow(b, 2) / (4 * Math.Tan((Math.PI * angle / 180.0) / 2));
        }
    }
}
