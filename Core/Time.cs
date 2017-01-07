using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFSScript
{
    /// <summary>
    /// 
    /// </summary>
    public static class Time
    {
        /// <summary>
        /// Returns a float that moves back and foruth.
        /// </summary>
        /// <param name="speed">How fast the ping pong occurs</param>
        /// <param name="t">Factor</param>
        /// <returns></returns>
        public static float PingPong(float speed, float t)
        {
            return (float)(System.Math.Sin(t * speed) + 1) / 2.0f;
        }
    }
}
