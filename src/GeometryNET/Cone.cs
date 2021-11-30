// <copyright file="Cone.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;
using System;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the Cone.
    /// </summary>
    public static class Cone
    {
        /// <summary>
        /// Returns a cone volume.
        /// </summary>
        /// <param name="diameter">Cone base diameter.</param>
        /// <param name="height">Cone height length.</param>
        /// <returns>Cone volume.</returns>
        public static double GetVolumeByDiameter(double diameter, double height)
        {
            if (diameter < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'diameter' or 'height' cannot be negative");
            }

            return (1.0 / 3.0) * Math.PI * Math.Pow(diameter / 2, 2) * height;
        }

        /// <summary>
        /// Returns a cone volume.
        /// </summary>
        /// <param name="radius">Cone base radius.</param>
        /// <param name="height">Cone height length.</param>
        /// <returns>Cone volume.</returns>
        public static double GetVolumeByRadius(double radius, double height)
        {
            if (radius < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'radius' or 'height' cannot be negative");
            }

            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }

        /// <summary>
        /// Returns a cone truncated volume.
        /// </summary>
        /// <param name="diameterOne">Cone one base diameter.</param>
        /// <param name="diameterOther">Cone the other base diameter.</param>
        /// <param name="height">Cone height length.</param>
        /// <returns>Cone truncated volume.</returns>
        public static double GetTruncatedVolumeByDiameter(double diameterOne, double diameterOther, double height)
        {
            if (diameterOne < 0 || diameterOther < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'diameterOne' or 'diameterOther' or 'height' cannot be negative");
            }

            return (1.0 / 3.0) * Math.PI * height * (Math.Pow(diameterOne / 2, 2) + ((diameterOne / 2) * (diameterOther / 2)) + Math.Pow(diameterOther / 2, 2));
        }

        /// <summary>
        /// Returns a cone truncated volume.
        /// </summary>
        /// <param name="radiusOne">Cone truncated one base radius.</param>
        /// <param name="radiusOther">Cone truncated the other base radius.</param>
        /// <param name="height">Cone truncated height length.</param>
        /// <returns>Cone truncated volume.</returns>
        public static double GetTruncatedVolumeByRadius(double radiusOne, double radiusOther, double height)
        {
            if (radiusOne < 0 || radiusOther < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'radiusOne' or 'radiusOther' or 'height' cannot be negative");
            }

            return (1.0 / 3.0) * Math.PI * height * (Math.Pow(radiusOne, 2) + (radiusOne * radiusOther) + Math.Pow(radiusOther, 2));
        }
    }
}
