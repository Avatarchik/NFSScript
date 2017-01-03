using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using NFSScript.Math;

namespace NFSScript
{
    /// <summary>
    /// Representation of RGBA colors in 32 bit format.
    /// </summary>
    public struct Color32
    {
        /// <summary>
        /// Alpha value of the color
        /// </summary>
        public byte a { get; set; }

        /// <summary>
        /// Blue value of the color
        /// </summary>
        public byte b { get; set; }

        /// <summary>
        /// Green value of the color
        /// </summary>
        public byte g { get; set; }

        /// <summary>
        /// Red value of the color
        /// </summary>
        public byte r { get; set; }

        /// <summary>
        /// Constructs a new Color32 with given RGB values.
        /// </summary>
        public Color32(byte r, byte g, byte b)
        {
            this.a = byte.MaxValue;
            this.b = b;
            this.g = g;
            this.r = r;
        }

        /// <summary>
        /// Constructs a new Color32 with given RGBA values.
        /// </summary>
        public Color32(byte r, byte g, byte b, byte a)
        {
            this.a = a;
            this.b = b;
            this.g = g;
            this.r = r;
        }

        /// <summary>
        /// Converts the current 32-bit color to color with floating point values.
        /// </summary>
        public Color ToColor()
        {
            return new Color(Mathf.ByteToFloat(r), Mathf.ByteToFloat(g), Mathf.ByteToFloat(b), Mathf.ByteToFloat(a));
        }

        /// <summary>
        /// Returns a color32 from hex
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static Color32 FromHex(string hex)
        {
            try
            {
                int argb = int.Parse(hex.Replace("#", "").Replace("0x", ""), NumberStyles.HexNumber);
                return new Color32((byte)((argb & -16777216) >> 0x18),
                                      (byte)((argb & 0xff0000) >> 0x10),
                                      (byte)((argb & 0xff00) >> 8),
                                      (byte)(argb & 0xff));
            }
            catch
            {
                throw new Exception(string.Format("{0} {1}", hex, "is not a valid color"));
            }
        }
    }
}
