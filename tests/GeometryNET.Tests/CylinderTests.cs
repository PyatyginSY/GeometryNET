// <copyright file="CylinderTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Cylinder.
    /// </summary>
    public class CylinderTests
    {
        /// <summary>
        /// A test for Cylinder.GetVolumeByDiameter.
        /// </summary>
        [Fact]
        public void GetVolumeByDiameterCylinderParametersReturnVolume()
        {
            const double BaseDiameter = 8;
            const double HeightLength = 5;

            var actual = Cylinder.GetVolumeByDiameter(BaseDiameter, HeightLength);

            Assert.Equal(251.32741228718345, actual);
        }

        /// <summary>
        /// A test for Cylinder.GetVolumeByDiameter.
        /// </summary>
        /// <param name="diameter">diameter.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'diameter' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'diameter' or 'height' cannot be negative")]
        public void GetVolumeByDiameterCylinderParametersReturnThrow(double diameter, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Cylinder.GetVolumeByDiameter(diameter, height));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Cylinder.GetVolumeByRadius.
        /// </summary>
        [Fact]
        public void GetVolumeByRadiusCylinderParametersReturnVolume()
        {
            const double BaseRadius = 8;
            const double HeightLength = 5;

            var actual = Cylinder.GetVolumeByRadius(BaseRadius, HeightLength);

            Assert.Equal(1005.3096491487338, actual);
        }

        /// <summary>
        /// A test for Cylinder.GetVolumeByRadius.
        /// </summary>
        /// <param name="radius">radius.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'radius' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'radius' or 'height' cannot be negative")]
        public void GetVolumeByRadiusCylinderParametersReturnThrow(double radius, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Cylinder.GetVolumeByRadius(radius, height));

            Assert.Equal(expected, actual.Message);
        }
    }
}
