using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFSScript
{
    /// <summary>
    /// A class for extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Converts a boolean to byte.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static byte ToByte(this bool x)
        {
            if (x)
                return 1;
            else return 0;
        }
    }
}
