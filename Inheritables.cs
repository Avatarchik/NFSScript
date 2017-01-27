using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Math;

namespace NFSScript
{
    /// <summary>
    /// A class that represents a dynamic (physics) game object in the game world.
    /// </summary>
    public abstract class EAGLPhysicsObject
    {
        /// <summary>
        /// Dynamic game object gravity values.
        /// </summary>
        public abstract Vector3 GravityValues { get; set; }

        /// <summary>
        /// The position of the defined dynamic object ID.
        /// </summary>
        public abstract Vector3 Position { get; set; }

        /// <summary>
        /// The rotation of the defined dynamic object ID.
        /// </summary>
        public abstract Quaternion Rotation { get; set; }

        /// <summary>
        /// The ID of the <see cref="EAGLPhysicsObject"/>.
        /// </summary>
        public abstract byte ID { get; set; }
    }
}
