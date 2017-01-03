using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFSScript
{
    /// <summary>
    /// 
    /// </summary>
    public struct Locval
    {
        /// <summary>
        /// 
        /// </summary>
        public int value { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public Locval(int value)
        {
            this.value = value;
        }
    }
}
