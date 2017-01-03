using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Memory;
using static NFSScript.Memory.GameMemory;
using Addrs = NFSScript.Memory.UG2Addresses;
using NFSScript.Math;

namespace NFSScript.Underground2
{

    /// <summary>
    /// A struct that represents the game's UI.
    /// </summary>
    public struct UI
    {
        /// <summary>
        /// Returns the point of where the game's cursor is located on screen.
        /// </summary>
        public static Point cursorPosition
        {
            get
            {
                ushort x = memory.ReadUShort((IntPtr)Addrs.UIAddrs.STATIC_CURSOR_POS_X);
                ushort y = memory.ReadUShort((IntPtr)Addrs.UIAddrs.STATIC_CURSOR_POS_Y);

                return new Point(x, y);
            }
        }
    }
}
