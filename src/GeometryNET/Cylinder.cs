// <copyright file="Cylinder.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using System;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the Cylinder.
    /// </summary>
    public static class Cylinder
    {
        /// <summary>
        /// Returns a cylinder volume.
        /// </summary>
        /// <param name="diameter">Cylinder base diameter.</param>
        /// <param name="height">Cylinder height length.</param>
        /// <returns>Cylinder volume.</returns>
        public static double GetVolumeByDiameter(double diameter, double height)
        {
            if (diameter < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'diameter' or 'height' cannot be negative");
            }

            return Math.PI * Math.Pow(diameter / 2, 2) * height;
        }

        /// <summary>
        /// Returns a cylinder volume.
        /// </summary>
        /// <param name="radius">Cylinder base radius.</param>
        /// <param name="height">Cylinder height length.</param>
        /// <returns>Cylinder volume.</returns>
        public static double GetVolumeByRadius(double radius, double height)
        {
            if (radius < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'radius' or 'height' cannot be negative");
            }

            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }
}
