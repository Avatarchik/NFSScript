using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.ProStreetAddresses;
using NFSScript.Math;

namespace NFSScript.ProStreet
{
    /// <summary>
    /// A struct that represents the game's UI.
    /// </summary>
    public static class UI
    {
        private const int INVALID_CODE_ENTRY_TEXT_MAX_LENGTH = 108;

        /// <summary>
        /// Set the code entry message when a player enters a cheat code that is not valid.
        /// </summary>
        /// <param name="msg"></param>
        public static void SetCodeEntryMessage(string msg)
        {
            int addr = memory.ReadInt32((IntPtr)memory.getBaseAddress + Addrs.UIAddrs.PNONSTATIC_UI_INVALID_CODE_ENTRY_TEXT);
            addr = memory.ReadInt32((IntPtr)addr + Addrs.UIAddrs.POINTER_UI_INVALID_CODE_ENTRY_TEXT_1);
            addr = memory.ReadInt32((IntPtr)addr + Addrs.UIAddrs.POINTER_UI_INVALID_CODE_ENTRY_TEXT_2);
            addr = memory.ReadInt32((IntPtr)addr + Addrs.UIAddrs.POINTER_UI_INVALID_CODE_ENTRY_TEXT_3);
            addr = memory.ReadInt32((IntPtr)addr + Addrs.UIAddrs.POINTER_UI_INVALID_CODE_ENTRY_TEXT_4);
            IntPtr final = (IntPtr)addr + Addrs.UIAddrs.POINTER_UI_INVALID_CODE_ENTRY_TEXT_5;
            ASM.Abolish(final, INVALID_CODE_ENTRY_TEXT_MAX_LENGTH);
            memory.WriteStringASCII(final, msg.Substring(0, INVALID_CODE_ENTRY_TEXT_MAX_LENGTH));
        }

        /// <summary>
        /// Returns the point of where the game's cursor is located on screen. (Fairly accurate)
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
