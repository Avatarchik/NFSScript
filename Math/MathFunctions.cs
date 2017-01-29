using System;

namespace NFSScript.Math
{
    /// <summary>
    /// Math functions!
    /// </summary>
    public static class Mathf
    {
        /// <summary>
        /// Returns 3.14159265358979, you know... PI.
        /// </summary>
        public const float PI = 3.14159265358979323846f;

        /// <summary>
        /// Degrees-to-radians conversion constant (Read only).
        /// </summary>
        public static float Deg2Rad = (PI * 2) / 360;

        /// <summary>
        /// Radians-to-degrees conversion constant (Read only).
        /// </summary>
        public static float Rad2Deg = 360 / (PI * 2);

        /// <summary>
        /// A small floating point value, a VERY small floating point value.
        /// </summary>
        public const float Epsilon = 1.192093E-07F;

        /// <summary>
        /// 
        /// </summary>
        public const float SingleMileToKM = 1.609344f;

        /// <summary>
        /// Returns a converted value from miles per hour to kilometers per hour.
        /// </summary>
        /// <param name="mph">The miles per hour value to convert.</param>
        /// <returns></returns>
        public static float ToKPH(float mph)
        {
            return mph * SingleMileToKM;
        }

        /// <summary>
        /// Returns a converted value from kilometers per hour to miles per hour.
        /// </summary>
        /// <param name="kph">The kilometers per hour value to convert.</param>
        /// <returns></returns>
        public static float ToMPH(float kph)
        {
            return kph / SingleMileToKM;
        }

        /// <summary>
        /// 
        /// </summary>
        public static float ByteToFloat(byte b)
        {
            return b / byte.MaxValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public static byte FloatToByte(float f)
        {
            float b = f * byte.MaxValue;
            if (b > byte.MaxValue)
                b = byte.MaxValue;
            else if (b < byte.MinValue)
                b = byte.MinValue;
            return (byte)b;
        }
    }
}
