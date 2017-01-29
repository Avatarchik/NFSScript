using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Types;

namespace NFSScript
{
    /// <summary>
    /// Any value type.
    /// </summary>
    public class Any : CustomValueType<Any, byte[]>
    {
        /// <summary>
        /// The length of this variable.
        /// </summary>
        public int Length { get { return value.Length; } }

        private Any(byte[] value) : base(value)
        { }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(byte[] value)
        {
            return new Any(value);
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="custom"></param>
        public static implicit operator byte[] (Any custom)
        {
            return custom.value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(short value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(int value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(long value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(ushort value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(uint value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(ulong value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(char value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(bool value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(float value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(double value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(byte value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(string value)
        {
            return Encoding.ASCII.GetBytes(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Any(char[] value)
        {
            return Encoding.ASCII.GetBytes(value);
        }
    }
}
