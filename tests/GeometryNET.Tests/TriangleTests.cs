// <copyright file="TriangleTests.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using Xunit;

namespace GeometryNET.Tests
{
    /// <summary>
    /// Tests class Triangle.
    /// </summary>
    public class TriangleTests
    {
        /// <summary>
        /// A test for Triangle.GetPerimeterByThreeSide.
        /// </summary>
        [Fact]
        public void GetPerimeterByThreeSideTriangleParametersReturnPerimeter()
        {
            const double FirstSideLength = 3;
            const double SecondSideLength = 5;
            const double ThirdSideLength = 7;

            var actual = Triangle.GetPerimeterByThreeSide(FirstSideLength, SecondSideLength, ThirdSideLength);

            Assert.Equal(15, actual);
        }

        /// <summary>
        /// A test for Triangle.GetPerimeterByThreeSide.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="c">c.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, "Parameter 'a' or 'b' or 'c' cannot be negative")]
        [InlineData(1, -1, 1, "Parameter 'a' or 'b' or 'c' cannot be negative")]
        [InlineData(1, 1, -1, "Parameter 'a' or 'b' or 'c' cannot be negative")]
        [InlineData(1, 1, 3, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        [InlineData(1, 3, 1, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        [InlineData(3, 1, 1, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        public void GetPerimeterByThreeSideTriangleParametersReturnThrow(double a, double b, double c, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetPerimeterByThreeSide(a, b, c));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetEquilateralPerimeterBySide.
        /// </summary>
        [Fact]
        public void GetEquilateralPerimeterBySideTriangleParametersReturnPerimeter()
        {
            const double SideLength = 3;

            var actual = Triangle.GetEquilateralPerimeterBySide(SideLength);

            Assert.Equal(9, actual);
        }

        /// <summary>
        /// A test for Triangle.GetEquilateralPerimeterBySide.
        /// </summary>
        [Fact]
        public void GetEquilateralPerimeterBySideTriangleParametersReturnThrow()
        {
            const double a = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetEquilateralPerimeterBySide(a));

            Assert.Equal("Parameter 'a' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetAreaByTwoSideAndAngle.
        /// </summary>
        [Fact]
        public void GetAreaByTwoSideAndAngleTriangleParametersReturnArea()
        {
            const double OneSideLength = 3;
            const double OtherSideLength = 5;
            const double AngleBetweeTwoSide = 30;

            var actual = Triangle.GetAreaByTwoSideAndAngle(OneSideLength, OtherSideLength, AngleBetweeTwoSide);

            Assert.Equal(3.7499999999999996, actual);
        }

        /// <summary>
        /// A test for Triangle.GetAreaByTwoSideAndAngle.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="angle">angle.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, "Parameter 'a' or 'b' or 'angle' cannot be negative")]
        [InlineData(1, -1, 1, "Parameter 'a' or 'b' or 'angle' cannot be negative")]
        [InlineData(1, 1, -1, "Parameter 'a' or 'b' or 'angle' cannot be negative")]
        [InlineData(1, 1, 180, "Parameter 'angle' cannot be greater than or equal 180")]
        public void GetAreaByTwoSideAndAngleTriangleParametersReturnThrow(double a, double b, double angle, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetAreaByTwoSideAndAngle(a, b, angle));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetAreaByBaseAndHeight.
        /// </summary>
        [Fact]
        public void GetAreaByBaseAndHeightTriangleParametersReturnArea()
        {
            const double BaseLength = 3;
            const double HeightLength = 5;

            var actual = Triangle.GetAreaByBaseAndHeight(BaseLength, HeightLength);

            Assert.Equal(7.5, actual);
        }

        /// <summary>
        /// A test for Triangle.GetAreaByBaseAndHeight.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="h">h.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'a' or 'h' cannot be negative")]
        [InlineData(1, -1, "Parameter 'a' or 'h' cannot be negative")]
        public void GetAreaByBaseAndHeightTriangleParametersReturnThrow(double a, double h, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetAreaByBaseAndHeight(a, h));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetAreaBySideAndTwoAngle.
        /// </summary>
        [Fact]
        public void GetAreaBySideAndTwoAngleTriangleParametersReturnArea()
        {
            const double SideLength = 5;
            const double FirstAngle = 35;
            const double SecondAngle = 50;

            var actual = Triangle.GetAreaBySideAndTwoAngle(SideLength, FirstAngle, SecondAngle);

            Assert.Equal(5.5132927656155752, actual);
        }

        /// <summary>
        /// A test for Triangle.GetAreaBySideAndTwoAngle.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="angleAlpha">angleAlpha.</param>
        /// <param name="angleBetta">angleBetta.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, "Parameter 'a' or 'angleAlpha' or 'angleBetta' cannot be negative")]
        [InlineData(1, -1, 1, "Parameter 'a' or 'angleAlpha' or 'angleBetta' cannot be negative")]
        [InlineData(1, 1, -1, "Parameter 'a' or 'angleAlpha' or 'angleBetta' cannot be negative")]
        [InlineData(1, 179, 1, "Parameter 'angleAlpha + angleBetta'  cannot be greater than or equal 180")]
        public void GetAreaBySideAndTwoAngleTriangleParametersReturnThrow(double a, double angleAlpha, double angleBetta, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetAreaBySideAndTwoAngle(a, angleAlpha, angleBetta));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetAreaByCircumscribedСircleAndTreeSide.
        /// </summary>
        [Fact]
        public void GetAreaByCircumscribedСircleAndTreeSideTriangleParametersReturnArea()
        {
            const double FirstSideLength = 3;
            const double SecondSideLength = 5;
            const double ThirdSideLength = 7;
            const double CircumscribedCircleRadius = 20;

            var actual = Triangle.GetAreaByCircumscribedСircleAndTreeSide(FirstSideLength, SecondSideLength, ThirdSideLength, CircumscribedCircleRadius);

            Assert.Equal(1.3125, actual);
        }

        /// <summary>
        /// A test for Triangle.GetAreaByCircumscribedСircleAndTreeSide.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="c">c.</param>
        /// <param name="radius">radius.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, 1, "Parameter 'a' or 'b' or 'c' or 'radius' cannot be negative")]
        [InlineData(1, -1, 1, 1, "Parameter 'a' or 'b' or 'c' or 'radius' cannot be negative")]
        [InlineData(1, 1, -1, 1, "Parameter 'a' or 'b' or 'c' or 'radius' cannot be negative")]
        [InlineData(1, 1, 1, -1, "Parameter 'a' or 'b' or 'c' or 'radius' cannot be negative")]
        [InlineData(1, 1, 3, 1, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        [InlineData(1, 3, 1, 1, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        [InlineData(3, 1, 1, 1, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        public void GetAreaByCircumscribedСircleAndTreeSideTriangleParametersReturnThrow(double a, double b, double c, double radius, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetAreaByCircumscribedСircleAndTreeSide(a, b, c, radius));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetAreaByInscribedСircleAndTreeSide.
        /// </summary>
        [Fact]
        public void GetAreaByInscribedСircleAndTreeSideTriangleParametersReturnArea()
        {
            const double FirstSideLength = 3;
            const double SecondSideLength = 5;
            const double ThirdSideLength = 7;
            const double InscribedСircleRadius = 20;

            var actual = Triangle.GetAreaByInscribedСircleAndTreeSide(FirstSideLength, SecondSideLength, ThirdSideLength, InscribedСircleRadius);

            Assert.Equal(150, actual);
        }

        /// <summary>
        /// A test for Triangle.GetAreaByInscribedСircleAndTreeSide.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="c">c.</param>
        /// <param name="radius">radius.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, 1, "Parameter 'a' or 'b' or 'c' or 'radius' cannot be negative")]
        [InlineData(1, -1, 1, 1, "Parameter 'a' or 'b' or 'c' or 'radius' cannot be negative")]
        [InlineData(1, 1, -1, 1, "Parameter 'a' or 'b' or 'c' or 'radius' cannot be negative")]
        [InlineData(1, 1, 1, -1, "Parameter 'a' or 'b' or 'c' or 'radius' cannot be negative")]
        [InlineData(1, 1, 3, 1, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        [InlineData(1, 3, 1, 1, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        [InlineData(3, 1, 1, 1, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        public void GetAreaByInscribedСircleAndTreeSideTriangleParametersReturnThrow(double a, double b, double c, double radius, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetAreaByInscribedСircleAndTreeSide(a, b, c, radius));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetAreaByHeron.
        /// </summary>
        [Fact]
        public void GetAreaByHeronTriangleParametersReturnArea()
        {
            const double FirstSideLength = 3;
            const double SecondSideLength = 5;
            const double ThirdSideLength = 7;

            var actual = Triangle.GetAreaByHeron(FirstSideLength, SecondSideLength, ThirdSideLength);

            Assert.Equal(6.49519052838329, actual);
        }

        /// <summary>
        /// A test for Triangle.GetAreaByHeron.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="c">c.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, 1, "Parameter 'a' or 'b' or 'c' cannot be negative")]
        [InlineData(1, -1, 1, "Parameter 'a' or 'b' or 'c' cannot be negative")]
        [InlineData(1, 1, -1, "Parameter 'a' or 'b' or 'c' cannot be negative")]
        [InlineData(1, 1, 3, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        [InlineData(1, 3, 1, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        [InlineData(3, 1, 1, "Parameter 'a + b' or 'a + c' or 'b + c' cannot be less than the third parameter")]
        public void GetAreaByHeronTriangleParametersReturnThrow(double a, double b, double c, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetAreaByHeron(a, b, c));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetEquilateralAreaByCircumscribedСircle.
        /// </summary>
        [Fact]
        public void GetEquilateralAreaByCircumscribedСircleTriangleParametersReturnArea()
        {
            const double CircumscribedCircleRadius = 20;

            var actual = Triangle.GetEquilateralAreaByCircumscribedСircle(CircumscribedCircleRadius);

            Assert.Equal(519.6152422706632, actual);
        }

        /// <summary>
        /// A test for Triangle.GetEquilateralAreaByCircumscribedСircle.
        /// </summary>
        [Fact]
        public void GetEquilateralAreaByCircumscribedСircleTriangleParametersReturnThrow()
        {
            const double CircumscribedCircleRadius = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetEquilateralAreaByCircumscribedСircle(CircumscribedCircleRadius));

            Assert.Equal("Parameter 'radius' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetEquilateralAreaByInscribedСircle.
        /// </summary>
        [Fact]
        public void GetEquilateralAreaByInscribedСircleTriangleParametersReturnArea()
        {
            const double InscribedCircleRadius = 20;

            var actual = Triangle.GetEquilateralAreaByInscribedСircle(InscribedCircleRadius);

            Assert.Equal(2078.4609690826528, actual);
        }

        /// <summary>
        /// A test for Triangle.GetEquilateralAreaByInscribedСircle.
        /// </summary>
        [Fact]
        public void GetEquilateralAreaByInscribedСircleTriangleParametersReturnThrow()
        {
            const double InscribedCircleRadius = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetEquilateralAreaByInscribedСircle(InscribedCircleRadius));

            Assert.Equal("Parameter 'radius' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetEquilateralAreaBySide.
        /// </summary>
        [Fact]
        public void GetEquilateralAreaBySideTriangleParametersReturnArea()
        {
            const double SideLength = 9;

            var actual = Triangle.GetEquilateralAreaBySide(SideLength);

            Assert.Equal(35.074028853269766, actual);
        }

        /// <summary>
        /// A test for Triangle.GetEquilateralAreaBySide.
        /// </summary>
        [Fact]
        public void GetEquilateralAreaBySideTriangleParametersReturnThrow()
        {
            const double SideLength = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetEquilateralAreaBySide(SideLength));

            Assert.Equal("Parameter 'a' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetEquilateralAreaByHeight.
        /// </summary>
        [Fact]
        public void GetEquilateralAreaByHeightTriangleParametersReturnArea()
        {
            const double HeightLength = 9;

            var actual = Triangle.GetEquilateralAreaByHeight(HeightLength);

            Assert.Equal(46.765371804359688, actual);
        }

        /// <summary>
        /// A test for Triangle.GetEquilateralAreaByHeight.
        /// </summary>
        [Fact]
        public void GetEquilateralAreaByHeightTriangleParametersReturnTrow()
        {
            const double HeightLength = -1;

            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetEquilateralAreaByHeight(HeightLength));

            Assert.Equal("Parameter 'height' cannot be negative", actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetRightAreaByTwoCathetus.
        /// </summary>
        [Fact]
        public void GetRightAreaByTwoCathetusTriangleParametersReturnArea()
        {
            const double OneCathetusLength = 9;
            const double TheOtherCathetusLength = 13;

            var actual = Triangle.GetRightAreaByTwoCathetus(OneCathetusLength, TheOtherCathetusLength);

            Assert.Equal(58.5, actual);
        }

        /// <summary>
        /// A test for Triangle.GetRightAreaByTwoCathetus.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'a' or 'b' cannot be negative")]
        [InlineData(1, -1, "Parameter 'a' or 'b' cannot be negative")]
        public void GetRightAreaByTwoCathetusTriangleParametersReturnThrow(double a, double b, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetRightAreaByTwoCathetus(a, b));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetRightAreaByHypotenuseAndAngle.
        /// </summary>
        [Fact]
        public void GetRightAreaByHypotenuseAndAngleTriangleParametersReturnArea()
        {
            const double HypotenuseLength = 9;
            const double Angle = 13;

            var actual = Triangle.GetRightAreaByHypotenuseAndAngle(HypotenuseLength, Angle);

            Assert.Equal(8.8770157224788182, actual);
        }

        /// <summary>
        /// A test for Triangle.GetRightAreaByHypotenuseAndAngle.
        /// </summary>
        /// <param name="hypotenuse">hypotenuse.</param>
        /// <param name="angle">angle.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'hypotenuse' or 'angle' cannot be negative")]
        [InlineData(1, -1, "Parameter 'hypotenuse' or 'angle' cannot be negative")]
        [InlineData(1, 90, "Parameter 'angle' cannot be greater than or equal 90")]
        public void GetRightAreaByHypotenuseAndAngleTriangleParametersReturnThrow(double hypotenuse, double angle, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetRightAreaByHypotenuseAndAngle(hypotenuse, angle));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetRightAreaByCathetusAndAngle.
        /// </summary>
        [Fact]
        public void GetRightAreaByCathetusAndAngleTriangleParametersReturnArea()
        {
            const double CathetusLength = 9;
            const double Angle = 13;

            var actual = Triangle.GetRightAreaByCathetusAndAngle(CathetusLength, Angle);

            Assert.Equal(9.3501617405853068, actual);
        }

        /// <summary>
        /// A test for Triangle.GetRightAreaByCathetusAndAngle.
        /// </summary>
        /// <param name="сathetus">сathetus.</param>
        /// <param name="angle">angle.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'сathetus' or 'angle' cannot be negative")]
        [InlineData(1, -1, "Parameter 'сathetus' or 'angle' cannot be negative")]
        [InlineData(1, 90, "Parameter 'angle' cannot be greater than or equal 90")]
        public void GetRightAreaByCathetusAndAngleTriangleParametersReturnThrow(double сathetus, double angle, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetRightAreaByCathetusAndAngle(сathetus, angle));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetRightAreaByInscribedСircleAndHypotenuse.
        /// </summary>
        [Fact]
        public void GetRightAreaByInscribedСircleAndHypotenuseTriangleParametersReturnArea()
        {
            const double HypotenuseLength = 9;
            const double InscribedCircleRadius = 13;

            var actual = Triangle.GetRightAreaByInscribedСircleAndHypotenuse(HypotenuseLength, InscribedCircleRadius);

            Assert.Equal(286, actual);
        }

        /// <summary>
        /// A test for Triangle.GetRightAreaByInscribedСircleAndHypotenuse.
        /// </summary>
        /// <param name="hypotenuse">hypotenuse.</param>
        /// <param name="radius">radius.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'hypotenuse' or 'radius' cannot be negative")]
        [InlineData(1, -1, "Parameter 'hypotenuse' or 'radius' cannot be negative")]
        public void GetRightAreaByInscribedСircleAndHypotenuseTriangleParametersReturnThrow(double hypotenuse, double radius, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetRightAreaByInscribedСircleAndHypotenuse(hypotenuse, radius));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetIsoscelesAreaByBaseAndSide.
        /// </summary>
        [Fact]
        public void GetIsoscelesAreaByBaseAndSideTriangleParametersReturnArea()
        {
            const double SideLength = 9;
            const double BaseLength = 13;

            var actual = Triangle.GetIsoscelesAreaByBaseAndSide(SideLength, BaseLength);

            Assert.Equal(40.462173693463384, actual);
        }

        /// <summary>
        /// A test for Triangle.GetIsoscelesAreaByBaseAndSide.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">b.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'a' or 'b' cannot be negative")]
        [InlineData(1, -1, "Parameter 'a' or 'b' cannot be negative")]
        public void GetIsoscelesAreaByBaseAndSideTriangleParametersReturnThrow(double a, double b, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetIsoscelesAreaByBaseAndSide(a, b));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetIsoscelesAreaByBaseAndHeight.
        /// </summary>
        [Fact]
        public void GetIsoscelesAreaByBaseAndHeightTriangleParametersReturnArea()
        {
            const double BaseLength = 13;
            const double HeightLength = 9;

            var actual = Triangle.GetIsoscelesAreaByBaseAndHeight(BaseLength, HeightLength);

            Assert.Equal(58.5, actual);
        }

        /// <summary>
        /// A test for Triangle.GetIsoscelesAreaByBaseAndHeight.
        /// </summary>
        /// <param name="b">b.</param>
        /// <param name="height">height.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'b' or 'height' cannot be negative")]
        [InlineData(1, -1, "Parameter 'b' or 'height' cannot be negative")]
        public void GetIsoscelesAreaByBaseAndHeightTriangleParametersReturnThrow(double b, double height, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetIsoscelesAreaByBaseAndHeight(b, height));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetIsoscelesAreaBySideAndAngle.
        /// </summary>
        [Fact]
        public void GetIsoscelesAreaBySideAndAngleTriangleParametersReturnArea()
        {
            const double SideLength = 13;
            const double Angle = 9;

            var actual = Triangle.GetIsoscelesAreaBySideAndAngle(SideLength, Angle);

            Assert.Equal(13.218712295899508, actual);
        }

        /// <summary>
        /// A test for Triangle.GetIsoscelesAreaBySideAndAngle.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="angle">angle.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'a' or 'angle' cannot be negative")]
        [InlineData(1, -1, "Parameter 'a' or 'angle' cannot be negative")]
        [InlineData(1, 90, "Parameter 'angle' cannot be greater than or equal 90")]
        public void GetIsoscelesAreaBySideAndAngleTriangleParametersReturnThrow(double a, double angle, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetIsoscelesAreaBySideAndAngle(a, angle));

            Assert.Equal(expected, actual.Message);
        }

        /// <summary>
        /// A test for Triangle.GetIsoscelesAreaByBaseAndAngle.
        /// </summary>
        [Fact]
        public void GetIsoscelesAreaByBaseAndAngleTriangleParametersReturnArea()
        {
            const double BaseLength = 13;
            const double AngleBetweeSideAndBase = 25;

            var actual = Triangle.GetIsoscelesAreaByBaseAndAngle(BaseLength, AngleBetweeSideAndBase);

            Assert.Equal(190.57743427972193, actual);
        }

        /// <summary>
        /// A test for Triangle.GetIsoscelesAreaByBaseAndAngle.
        /// </summary>
        /// <param name="b">a.</param>
        /// <param name="angle">angle.</param>
        /// <param name="expected">expected.</param>
        [Theory]
        [InlineData(-1, 1, "Parameter 'b' or 'angle' cannot be negative")]
        [InlineData(1, -1, "Parameter 'b' or 'angle' cannot be negative")]
        [InlineData(1, 90, "Parameter 'angle' cannot be greater than or equal 90")]
        public void GetIsoscelesAreaByBaseAndAngleTriangleParametersReturnThrow(double b, double angle, string expected)
        {
            var actual = Assert.Throws<GeometryArgumentException>(() => Triangle.GetIsoscelesAreaByBaseAndAngle(b, angle));

            Assert.Equal(expected, actual.Message);
        }
    }
}
