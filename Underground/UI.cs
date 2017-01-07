using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.UGAddresses;
using NFSScript.Math;

namespace NFSScript.Underground
{

    /// <summary>
    /// A class that represents the game's UI.
    /// </summary>
    public static class UI
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
