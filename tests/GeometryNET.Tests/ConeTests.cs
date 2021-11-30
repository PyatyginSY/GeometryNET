// <copyright file="ConeTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Cone.
    /// </summary>
    public class ConeTests
    {
        /// <summary>
        /// A test for Cone.GetVolumeByDiameter.
        /// </summary>
        [Fact]
        public void GetVolumeByDiameterConeParametersReturnVolume()
        {
            const double BaseDiameter = 8;
            const double HeightLength = 5;

            var actual = Cone.GetVolumeByDiameter(BaseDiameter, HeightLength);

            Assert.Equal(83.7758040957278, actual);
        }

        /// <summary>
        /// A test for Cone.GetVolumeByDiameter.
        /// </summary>
        /// <param name="diameter">diameter.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'diameter' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'diameter' or 'height' cannot be negative")]
        public void GetVolumeByDiameterConeParametersReturnThrow(double diameter, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Cone.GetVolumeByDiameter(diameter, height));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Cone.GetVolumeByRadius.
        /// </summary>
        [Fact]
        public void GetVolumeByRadiusConeParametersReturnVolume()
        {
            const double BaseRadius = 8;
            const double HeightLength = 5;

            var actual = Cone.GetVolumeByRadius(BaseRadius, HeightLength);

            Assert.Equal(335.10321638291123, actual);
        }

        /// <summary>
        /// A test for Cone.GetVolumeByRadius.
        /// </summary>
        /// <param name="radius">radius.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'radius' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'radius' or 'height' cannot be negative")]
        public void GetVolumeByRadiusConeParametersReturnThrow(double radius, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Cone.GetVolumeByRadius(radius, height));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Cone.GetTruncatedVolumeByDiameter.
        /// </summary>
        [Fact]
        public void GetTruncatedVolumeByDiameterConeParametersReturnVolume()
        {
            const double OneBaseDiameter = 2;
            const double OtherBaseDiameter = 10;
            const double HeightLength = 5;

            var actual = Cone.GetTruncatedVolumeByDiameter(OneBaseDiameter, OtherBaseDiameter, HeightLength);

            Assert.Equal(162.31562043547262, actual);
        }

        /// <summary>
        /// A test for Cone.GetTruncatedVolumeByDiameter.
        /// </summary>
        /// <param name="diameterOne">diameterOne.</param>
        /// <param name="diameterOther">diameterOther.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, "Parameter 'diameterOne' or 'diameterOther' or 'height' cannot be negative")]
        [InlineData(1, -1, 1, "Parameter 'diameterOne' or 'diameterOther' or 'height' cannot be negative")]
        [InlineData(1, 1, -1, "Parameter 'diameterOne' or 'diameterOther' or 'height' cannot be negative")]
        public void GetTruncatedVolumeByDiameterConeParametersReturnThrow(double diameterOne, double diameterOther, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Cone.GetTruncatedVolumeByDiameter(diameterOne, diameterOther, height));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Cone.GetTruncatedVolumeByRadius.
        /// </summary>
        [Fact]
        public void GetTruncatedVolumeByRadiusConeParametersReturnVolume()
        {
            const double OneBaseRadius = 1;
            const double OtherBaseRadius = 5;
            const double HeightLength = 2;

            var actual = Cone.GetTruncatedVolumeByRadius(OneBaseRadius, OtherBaseRadius, HeightLength);

            Assert.Equal(64.926248174189055, actual);
        }

        /// <summary>
        /// A test for Cone.GetTruncatedVolumeByRadius.
        /// </summary>
        /// <param name="radiusOne">radiusOne.</param>
        /// <param name="radiusOther">radiusOther.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, "Parameter 'radiusOne' or 'radiusOther' or 'height' cannot be negative")]
        [InlineData(1, -1, 1, "Parameter 'radiusOne' or 'radiusOther' or 'height' cannot be negative")]
        [InlineData(1, 1, -1, "Parameter 'radiusOne' or 'radiusOther' or 'height' cannot be negative")]
        public void GetTruncatedVolumeByRadiusConeParametersReturnThrow(double radiusOne, double radiusOther, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Cone.GetTruncatedVolumeByRadius(radiusOne, radiusOther, height));

            Assert.Equal(expected, actual.Message);
        }
    }
}
