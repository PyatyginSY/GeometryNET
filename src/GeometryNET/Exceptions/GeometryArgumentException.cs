// <copyright file="GeometryArgumentException.cs" company="Pyatygin S.Y.">
// Copyright (c) Pyatygin S.Y.. All rights reserved.
// </copyright>

using System;

namespace GeometryNET.Exceptions
{
    /// <summary>
    /// The exception that is thrown when one of the arguments provided to a method is not valid.
    /// </summary>
    public class GeometryArgumentException : ArgumentException
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryArgumentException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public GeometryArgumentException(string message)
            : base(message)
        {
        }
    }
}
