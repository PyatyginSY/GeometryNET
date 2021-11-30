// <copyright file="ParallelogramTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Parallelogram.
    /// </summary>
    public class ParallelogramTests
    {
        /// <summary>
        /// A test for Parallelogram.GetPerimeter.
        /// </summary>
        [Fact]
        public void GetPerimeterParallelogramParametersReturnPerimeter()
        {
            const double FirstSideLength = 3;
            const double SecondSideLength = 5;

            var actual = Parallelogram.GetPerimeter(FirstSideLength, SecondSideLength);

            Assert.Equal(16, actual);
        }

        /// <summary>
        /// A test for Parallelogram.GetPerimeter.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'a' or 'b' cannot be negative")]
        [InlineData(1, -1, "Parameter 'a' or 'b' cannot be negative")]
        public void GetPerimeterParallelogramParametersReturnThrow(double a, double b, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Parallelogram.GetPerimeter(a, b));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Parallelogram.GetAreaBySideAndHeight.
        /// </summary>
        [Fact]
        public void GetAreaBySideAndHeightParallelogramParametersReturnArea()
        {
            const double SideLength = 5;
            const double HeightLength = 4;

            var actual = Parallelogram.GetAreaBySideAndHeight(SideLength, HeightLength);

            Assert.Equal(20, actual);
        }

        /// <summary>
        /// A test for Parallelogram.GetAreaBySideAndHeight.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'a' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'a' or 'height' cannot be negative")]
        public void GetAreaBySideAndHeightParallelogramParametersReturnThrow(double a, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Parallelogram.GetAreaBySideAndHeight(a, height));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Parallelogram.GetAreaBySideAndAngle.
        /// </summary>
        [Fact]
        public void GetAreaBySideAndAngleParallelogramParametersReturnArea()
        {
            const double FirstSideLength = 3;
            const double SecondSideLength = 5;
            const double AngleBetweeTwoSide = 60;

            var actual = Parallelogram.GetAreaBySideAndAngle(FirstSideLength, SecondSideLength, AngleBetweeTwoSide);

            Assert.Equal(12.990381056766578, actual);
        }

        /// <summary>
        /// A test for Parallelogram.GetAreaBySideAndAngle.
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
        public void GetAreaBySideAndAngleParallelogramParametersReturnThrow(double a, double b, double angle, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Parallelogram.GetAreaBySideAndAngle(a, b, angle));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Parallelogram.GetAreaByDiagonal.
        /// </summary>
        [Fact]
        public void GetAreaByDiagonalParallelogramParametersReturnArea()
        {
            const double FirstDiagonalLength = 3;
            const double SecondDiagonalLength = 5;
            const double AngleBetweeTwoDiagonal = 60;

            var actual = Parallelogram.GetAreaByDiagonal(FirstDiagonalLength, SecondDiagonalLength, AngleBetweeTwoDiagonal);

            Assert.Equal(6.4951905283832891, actual);
        }

        /// <summary>
        /// A test for Parallelogram.GetAreaByDiagonal.
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
        public void GetAreaByDiagonalParallelogramParametersReturnThrow(double a, double b, double angle, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Parallelogram.GetAreaByDiagonal(a, b, angle));

            Assert.Equal(expected, actual.Message);
        }
    }
}
