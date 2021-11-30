// <copyright file="PrismTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Prism.
    /// </summary>
    public class PrismTests
    {
        /// <summary>
        /// A test for Prism.GetVolume.
        /// </summary>
        [Fact]
        public void GetVolumePrismParametersReturnVolume()
        {
            const double BaseArea = 31;
            const double HeightLength = 5;

            var actual = Prism.GetVolume(BaseArea, HeightLength);

            Assert.Equal(155, actual);
        }

        /// <summary>
        /// A test for Prism.GetVolume.
        /// </summary>
        /// <param name="area">area.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'area' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'area' or 'height' cannot be negative")]
        public void GetVolumePrismParametersReturnThrow(double area, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Prism.GetVolume(area, height));

            Assert.Equal(expected, actual.Message);
        }
    }
}
