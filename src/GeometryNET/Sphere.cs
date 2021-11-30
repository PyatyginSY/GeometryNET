// <copyright file="Sphere.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using System;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the sphere.
    /// </summary>
    public static class Sphere
    {
        /// <summary>
        /// Returns a sphere volume.
        /// </summary>
        /// <param name="diameter">Sphere diameter.</param>
        /// <returns>Sphere volume.</returns>
        public static double GetVolumeByDiameter(double diameter)
        {
            if (diameter < 0)
            {
                throw new GeometryArgumentException("Parameter 'diameter' cannot be negative");
            }

            return (4.0 / 3.0) * Math.PI * Math.Pow(diameter / 2, 3);
        }

        /// <summary>
        /// Returns a sphere volume.
        /// </summary>
        /// <param name="radius">Sphere radius.</param>
        /// <returns>Sphere volume.</returns>
        public static double GetVolumeByRadius(double radius)
        {
            if (radius < 0)
            {
                throw new GeometryArgumentException("Parameter 'radius' cannot be negative");
            }

            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }
}
