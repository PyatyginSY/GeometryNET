// <copyright file="EllipsoidTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Ellipsoid.
    /// </summary>
    public class EllipsoidTests
    {
        /// <summary>
        /// A test for Ellipsoid.GetVolume.
        /// </summary>
        [Fact]
        public void GetVolumeEllipsoidParametersReturnVolume()
        {
            const double HalfAxisHeight = 1;
            const double HalfAxisWidth = 2;
            const double HalfAxisDeflection = 3;

            var actual = Ellipsoid.GetVolume(HalfAxisHeight, HalfAxisWidth, HalfAxisDeflection);

            Assert.Equal(25.132741228718345, actual);
        }

        /// <summary>
        /// A test for Ellipsoid.GetVolume.
        /// </summary>
        /// <param name="halfAxisHeight">halfAxisHeight.</param>
        /// <param name="halfAxisWidth">halfAxisWidth.</param>
        /// <param name="halfAxisDeflection">halfAxisDeflection.</param>
        [Theory]
        [InlineData(-1, 1, 1, "Parameter 'halfAxisHeight' or 'halfAxisWidth'or 'halfAxisDeflection' cannot be negative")]
        [InlineData(1, -1, 1, "Parameter 'halfAxisHeight' or 'halfAxisWidth'or 'halfAxisDeflection' cannot be negative")]
        [InlineData(1, 1, -1, "Parameter 'halfAxisHeight' or 'halfAxisWidth'or 'halfAxisDeflection' cannot be negative")]
        public void GetVolumeEllipsoidParametersReturnThrow(double halfAxisHeight, double halfAxisWidth, double halfAxisDeflection, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Ellipsoid.GetVolume(halfAxisHeight, halfAxisWidth, halfAxisDeflection));

            Assert.Equal(expected, actual.Message);
        }
    }
}
