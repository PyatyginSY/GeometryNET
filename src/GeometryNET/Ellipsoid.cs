// <copyright file="Ellipsoid.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using System;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the Ellipsoid.
    /// </summary>
    public static class Ellipsoid
    {
        /// <summary>
        /// Returns a ellipsoid volume.
        /// </summary>
        /// <param name="halfAxisHeight">Ellipsoid height half-axis.</param>
        /// <param name="halfAxisWidth">Ellipsoid width half-axis.</param>
        /// <param name="halfAxisDeflection">Ellipsoid deflection half-axis.</param>
        /// <returns>Ellipsoid volume.</returns>
        public static double GetVolume(double halfAxisHeight, double halfAxisWidth, double halfAxisDeflection)
        {
            if (halfAxisHeight < 0 || halfAxisWidth < 0 || halfAxisDeflection < 0)
            {
                throw new GeometryArgumentException("Parameter 'halfAxisHeight' or 'halfAxisWidth'or 'halfAxisDeflection' cannot be negative");
            }

            return (4.0 / 3.0) * Math.PI * halfAxisHeight * halfAxisWidth * halfAxisDeflection;
        }
    }
}
