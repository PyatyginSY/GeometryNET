// <copyright file="RectangleTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Rectangle.
    /// </summary>
    public class RectangleTests
    {
        /// <summary>
        /// A test for Rectangle.GetPerimeter.
        /// </summary>
        [Fact]
        public void GetPerimeterRectangleParametersReturnPerimeter()
        {
            const double WidthLength = 3;
            const double HeightLength = 5;

            var actual = Rectangle.GetPerimeter(WidthLength, HeightLength);

            Assert.Equal(16, actual);
        }

        /// <summary>
        /// A test for Rectangle.GetPerimeter.
        /// </summary>
        /// <param name="width">width.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'width' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'width' or 'height' cannot be negative")]
        public void GetPerimeterRectangleParametersReturnThrow(double width, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Rectangle.GetPerimeter(width, height));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Rectangle.GetArea.
        /// </summary>
        [Fact]
        public void GetAreaRectangleParametersReturnArea()
        {
            const double WidthLength = 3;
            const double HeightLength = 5;

            var actual = Rectangle.GetArea(WidthLength, HeightLength);

            Assert.Equal(15, actual);
        }

        /// <summary>
        /// A test for Rectangle.GetArea.
        /// </summary>
        /// <param name="width">width.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'width' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'width' or 'height' cannot be negative")]
        public void GetAreaRectangleParametersReturnThrow(double width, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Rectangle.GetArea(width, height));

            Assert.Equal(expected, actual.Message);
        }
    }
}
