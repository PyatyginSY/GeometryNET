// <copyright file="SphereTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Sphere.
    /// </summary>
    public class SphereTests
    {
        /// <summary>
        /// A test for Sphere.GetVolumeByDiameter.
        /// </summary>
        [Fact]
        public void GetVolumeByDiameterSphereParametersReturnVolume()
        {
            const double Diameter = 8;

            var actual = Sphere.GetVolumeByDiameter(Diameter);

            Assert.Equal(268.082573106329, actual);
        }

        /// <summary>
        /// A test for Sphere.GetVolumeByDiameter.
        /// </summary>
        [Fact]
        public void GetVolumeByDiameterSphereParametersReturnThrow()
        {
            const double Diameter = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Sphere.GetVolumeByDiameter(Diameter));

            Assert.Equal("Parameter 'diameter' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Sphere.GetVolumeByRadius.
        /// </summary>
        [Fact]
        public void GetVolumeByRadiusSphereParametersReturnVolume()
        {
            const double Radius = 8;

            var actual = Sphere.GetVolumeByRadius(Radius);

            Assert.Equal(2144.6605848506319, actual);
        }

        /// <summary>
        /// A test for Sphere.GetVolumeByRadius.
        /// </summary>
        [Fact]
        public void GetVolumeByRadiusSphereParametersReturnThrow()
        {
            const double Radius = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Sphere.GetVolumeByRadius(Radius));

            Assert.Equal("Parameter 'radius' cannot be negative", actual.Message);
        }
    }
}
