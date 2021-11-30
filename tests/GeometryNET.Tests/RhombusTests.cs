// <copyright file="RhombusTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Rhombus.
    /// </summary>
    public class RhombusTests
    {
        /// <summary>
        /// A test for Rhombus.GetPerimeter.
        /// </summary>
        [Fact]
        public void GetPerimeterRhombusParametersReturnPerimeter()
        {
            const double SideLength = 5;

            var actual = Rhombus.GetPerimeter(SideLength);

            Assert.Equal(20, actual);
        }

        /// <summary>
        /// A test for Rhombus.GetPerimeter.
        /// </summary>
        [Fact]
        public void GetPerimeterRhombusParametersReturnThrow()
        {
            const double SideLength = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Rhombus.GetPerimeter(SideLength));

            Assert.Equal("Parameter 'a' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Rhombus.GetAreaBySideAndHeight.
        /// </summary>
        [Fact]
        public void GetAreaBySideAndHeightRhombusParametersReturnArea()
        {
            const double SideLength = 5;
            const double HeightLength = 3;

            var actual = Rhombus.GetAreaBySideAndHeight(SideLength, HeightLength);

            Assert.Equal(15, actual);
        }

        /// <summary>
        /// A test for Rhombus.GetAreaBySideAndHeight.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'a' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'a' or 'height' cannot be negative")]
        public void GetAreaBySideAndHeightRhombusParametersReturnThrow(double a, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Rhombus.GetAreaBySideAndHeight(a, height));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Rhombus.GetAreaBySideAndAngle.
        /// </summary>
        [Fact]
        public void GetAreaBySideAndAngleRhombusParametersReturnArea()
        {
            const double SideLength = 5;
            const double AngleBetweenTwoSide = 60;

            var actual = Rhombus.GetAreaBySideAndAngle(SideLength, AngleBetweenTwoSide);

            Assert.Equal(21.650635094610966, actual);
        }

        /// <summary>
        /// A test for Rhombus.GetAreaBySideAndAngle.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="angle">angle.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'a' or 'angle' cannot be negative")]
        [InlineData(1, -1, "Parameter 'a' or 'angle' cannot be negative")]
        [InlineData(1, 180.1, "Parameter 'angle' cannot be more than 180")]
        public void GetAreaBySideAndAngleRhombusParametersReturnThrow(double a, double angle, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Rhombus.GetAreaBySideAndAngle(a, angle));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Rhombus.GetAreaByDiagonal.
        /// </summary>
        [Fact]
        public void GetAreaByDiagonalRhombusParametersReturnArea()
        {
            const double FirstDiagonalLength = 5;
            const double SecondDiagonalLength = 4;

            var actual = Rhombus.GetAreaByDiagonal(FirstDiagonalLength, SecondDiagonalLength);

            Assert.Equal(10, actual);
        }

        /// <summary>
        /// A test for Rhombus.GetAreaByDiagonal.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'a' or 'b' cannot be negative")]
        [InlineData(1, -1, "Parameter 'a' or 'b' cannot be negative")]
        public void GetAreaByDiagonalRhombusParametersReturnThrow(double a, double b, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Rhombus.GetAreaByDiagonal(a, b));

            Assert.Equal(expected, actual.Message);
        }
    }
}
