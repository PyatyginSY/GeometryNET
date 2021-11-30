// <copyright file="СircleTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Сircle.
    /// </summary>
    public class СircleTests
    {
        /// <summary>
        /// A test for Сircle.GetPerimeterByDiameter.
        /// </summary>
        [Fact]
        public void GetPerimeterByDiameterСircleParametersReturnPerimeter()
        {
            const double Diameter = 8;

            var actual = Сircle.GetPerimeterByDiameter(Diameter);

            Assert.Equal(25.132741228718345, actual);
        }

        /// <summary>
        /// A test for Сircle.GetPerimeterByDiameter.
        /// </summary>
        [Fact]
        public void GetPerimeterByDiameterСircleParametersReturnThrow()
        {
            const double Diameter = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Сircle.GetPerimeterByDiameter(Diameter));

            Assert.Equal("Parameter 'diameter' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Сircle.GetPerimeterByRadius.
        /// </summary>
        [Fact]
        public void GetPerimeterByRadiusСircleParametersReturnPerimeter()
        {
            const double Radius = 8;

            var actual = Сircle.GetPerimeterByRadius(Radius);

            Assert.Equal(50.26548245743669, actual);
        }

        /// <summary>
        /// A test for Сircle.GetPerimeterByRadius.
        /// </summary>
        [Fact]
        public void GetPerimeterByRadiusСircleParametersReturnThrow()
        {
            const double Radius = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Сircle.GetPerimeterByRadius(Radius));

            Assert.Equal("Parameter 'radius' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Сircle.GetAreaByDiameter.
        /// </summary>
        [Fact]
        public void GetAreaByDiameterСircleParametersReturnArea()
        {
            const double Diameter = 9;

            var actual = Сircle.GetAreaByDiameter(Diameter);

            Assert.Equal(63.617251235193308, actual);
        }

        /// <summary>
        /// A test for Сircle.GetAreaByDiameter.
        /// </summary>
        [Fact]
        public void GetAreaByDiameterСircleParametersReturnThrow()
        {
            const double Diameter = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Сircle.GetAreaByDiameter(Diameter));

            Assert.Equal("Parameter 'diameter' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Сircle.GetAreaByRadius.
        /// </summary>
        [Fact]
        public void GetAreaByRadiusСircleParametersReturnArea()
        {
            const double Radius = 9;

            var actual = Сircle.GetAreaByRadius(Radius);

            Assert.Equal(254.46900494077323, actual);
        }

        /// <summary>
        /// A test for Сircle.GetAreaByRadius.
        /// </summary>
        [Fact]
        public void GetAreaByRadiusСircleParametersReturnThrow()
        {
            const double Radius = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Сircle.GetAreaByRadius(Radius));

            Assert.Equal("Parameter 'radius' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Сircle.GetAreaBycCircumference.
        /// </summary>
        [Fact]
        public void GetAreaBycCircumferenceСircleParametersReturnArea()
        {
            const double Circumference = 99;

            var actual = Сircle.GetAreaBycCircumference(Circumference);

            Assert.Equal(779.93879862183314, actual);
        }

        /// <summary>
        /// A test for Сircle.GetAreaBycCircumference.
        /// </summary>
        [Fact]
        public void GetAreaBycCircumferenceСircleParametersReturnThrow()
        {
            const double Circumference = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Сircle.GetAreaBycCircumference(Circumference));

            Assert.Equal("Parameter 'length' cannot be negative", actual.Message);
        }
    }
}
