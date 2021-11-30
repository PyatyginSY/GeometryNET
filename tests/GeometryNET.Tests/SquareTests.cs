// <copyright file="SquareTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Square.
    /// </summary>
    public class SquareTests
    {
        /// <summary>
        /// A test for Square.GetPerimeter.
        /// </summary>
        [Fact]
        public void GetPerimeterSquareParametersReturnPerimeter()
        {
            const double SideLength = 6;

            var actual = Square.GetPerimeter(SideLength);

            Assert.Equal(24, actual);
        }

        /// <summary>
        /// A test for Square.GetPerimeter.
        /// </summary>
        [Fact]
        public void GetPerimeterSquareParametersReturnThrow()
        {
            const double a = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Square.GetPerimeter(a));

            Assert.Equal("Parameter 'a' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Square.GetArea.
        /// </summary>
        [Fact]
        public void GetAreaSquareParametersReturnArea()
        {
            const double SideLength = 6;

            var actual = Square.GetArea(SideLength);

            Assert.Equal(36, actual);
        }

        /// <summary>
        /// A test for Square.GetArea.
        /// </summary>
        [Fact]
        public void GetAreaSquareParametersReturnThrow()
        {
            const double a = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Square.GetArea(a));

            Assert.Equal("Parameter 'a' cannot be negative", actual.Message);
        }
    }
}
