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
        /// Returns a timer that will move back and foruth.
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float PingPong(float speed, float t)
        {
            return (float)(System.Math.Sin(t * speed) + 1) / 2.0f;
        }
    }
}
