using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Math;
using NFSScript.MW;
using NFSScript.Carbon;
namespace NFSScript
{
    /// <summary>
    /// A base class for a camera.
    /// </summary>
    public class BaseCamera
    {
        /// <summary>
        /// Gets or sets the position of this <see cref="BaseCamera"/>.
        /// </summary>
        public virtual Vector3 Position { get; }

        /// <summary>
        /// Gets or sets the rotation of this <see cref="BaseCamera"/>.
        /// </summary>
        public virtual Quaternion Rotation { get; }

        /// <summary>
        /// Gets or sets the FOV for this <see cref="BaseCamera"/>.
        /// </summary>
        public virtual float FOV { get; set; }
    }

    /// <summary>
    /// An enum for cars level of detail.
    /// </summary>
    public enum CarsLOD : byte
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// Low level of detail.
        /// </summary>
        Low = 1,
        /// <summary>
        /// Medium level of detail.
        /// </summary>
        Medium = 2,
        /// <summary>
        /// High level of detail.
        /// </summary>
        High = 3,
        /// <summary>
        /// Default level of detail.
        /// </summary>
        Default = 4
    }
}
