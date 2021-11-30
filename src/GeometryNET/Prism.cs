// <copyright file="Prism.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using GeometryNET.Exceptions;

namespace GeometryNET
{
    /// <summary>
    /// Geometric parameters of the Cone.
    /// </summary>
    public static class Prism
    {
        /// <summary>
        /// Returns a prism volume.
        /// </summary>
        /// <param name="area">Prism base area.</param>
        /// <param name="height">Prism height length.</param>
        /// <returns>Prism volume.</returns>
        public static double GetVolume(double area, double height)
        {
            if (area < 0 || height < 0)
            {
                throw new GeometryArgumentException("Parameter 'area' or 'height' cannot be negative");
            }

            return area * height;
        }
    }
}
