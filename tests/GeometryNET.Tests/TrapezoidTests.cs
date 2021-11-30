// <copyright file="TrapezoidTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Trapezoid.
    /// </summary>
    public class TrapezoidTests
    {
        /// <summary>
        /// A test for Trapezoid.GetPerimeter.
        /// </summary>
        [Fact]
        public void GetPerimeterTrapezoidParametersReturnPerimeter()
        {
            const double FirstBaseLength = 3;
            const double SecondBaseLength = 7;
            const double FirstSideLength = 5;
            const double SecondSideLength = 4;

            var actual = Trapezoid.GetPerimeter(FirstBaseLength, SecondBaseLength, FirstSideLength, SecondSideLength);

            Assert.Equal(19, actual);
        }

        /// <summary>
        /// A test for Trapezoid.GetPerimeter.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="c">c.</param>
        /// <param name="d">d.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, 1, "Parameter 'a' or 'b' or 'c' or 'd' cannot be negative")]
        [InlineData(1, -1, 1, 1, "Parameter 'a' or 'b' or 'c' or 'd' cannot be negative")]
        [InlineData(1, 1, -1, 1, "Parameter 'a' or 'b' or 'c' or 'd' cannot be negative")]
        [InlineData(1, 1, 1, -1, "Parameter 'a' or 'b' or 'c' or 'd' cannot be negative")]
        public void GetPerimeterTrapezoidParametersReturnThrow(double a, double b, double c, double d, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Trapezoid.GetPerimeter(a, b, c, d));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Trapezoid.GetIsoscelesPerimeter.
        /// </summary>
        [Fact]
        public void GetIsoscelesPerimeterTrapezoidIsoscelesParametersReturnPerimeter()
        {
            const double FirstBaseLength = 3;
            const double SecondBaseLength = 7;
            const double SideLength = 5;

            var actual = Trapezoid.GetIsoscelesPerimeter(FirstBaseLength, SecondBaseLength, SideLength);

            Assert.Equal(20, actual);
        }

        /// <summary>
        /// A test for Trapezoid.GetIsoscelesPerimeter.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="c">c.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, "Parameter 'a' or 'b' or 'c' cannot be negative")]
        [InlineData(1, -1, 1, "Parameter 'a' or 'b' or 'c' cannot be negative")]
        [InlineData(1, 1, -1, "Parameter 'a' or 'b' or 'c' cannot be negative")]
        public void GetIsoscelesPerimeterTrapezoidIsoscelesParametersReturnThrow(double a, double b, double c, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Trapezoid.GetIsoscelesPerimeter(a, b, c));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Trapezoid.GetAreaByMidlineAndHeight.
        /// </summary>
        [Fact]
        public void GetAreaByMidlineAndHeightTrapezoidParametersReturnArea()
        {
            const double MidlineLength = 3;
            const double HeightLength = 7;

            var actual = Trapezoid.GetAreaByMidlineAndHeight(MidlineLength, HeightLength);

            Assert.Equal(21, actual);
        }

        /// <summary>
        /// A test for Trapezoid.GetAreaByMidlineAndHeight.
        /// </summary>
        /// <param name="midline">midline.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'midline' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'midline' or 'height' cannot be negative")]
        public void GetAreaByMidlineAndHeightTrapezoidParametersReturnThrow(double midline, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Trapezoid.GetAreaByMidlineAndHeight(midline, height));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Trapezoid.GetAreaByDiagonalAndAngle.
        /// </summary>
        [Fact]
        public void GetAreaByDiagonalAndAngleTrapezoidParametersReturnArea()
        {
            const double FirstDiagonalLength = 3;
            const double SecondDiagonalLength = 5;
            const double AngleBetweeTwoDiagonal = 60;

            var actual = Trapezoid.GetAreaByDiagonalAndAngle(FirstDiagonalLength, SecondDiagonalLength, AngleBetweeTwoDiagonal);

            Assert.Equal(6.4951905283832891, actual);
        }

        /// <summary>
        /// A test for Trapezoid.GetAreaByDiagonalAndAngle.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="angle">angle.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, "Parameter 'a' or 'b' or 'angle' cannot be negative")]
        [InlineData(1, -1, 1, "Parameter 'a' or 'b' or 'angle' cannot be negative")]
        [InlineData(1, 1, -1, "Parameter 'a' or 'b' or 'angle' cannot be negative")]
        [InlineData(1, 1, 180.1, "Parameter 'angle' cannot be more than 180")]
        public void GetAreaByDiagonalAndAngleTrapezoidParametersReturnThrow(double a, double b, double angle, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Trapezoid.GetAreaByDiagonalAndAngle(a, b, angle));

            Assert.Equal(expected, actual.Message); 
        }
    }
}
