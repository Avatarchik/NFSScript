using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Memory;
using static NFSScript.Memory.GameMemory;
using Addrs = NFSScript.Memory.UndercoverAddresses;
using NFSScript.Math;

namespace NFSScript.Undercover
{
    /// <summary>
    /// A struct that represents the game's UI.
    /// </summary>
    public static class UI
    {
        private const int INVALID_SECRET_CODE_ENTRY_TEXT_MAX_LENGTH = 87;

        /// <summary>
        /// Set the secret code entry message when a player enters a cheat code that is not valid.
        /// </summary>
        /// <param name="msg"></param>
        public static void SetSecretCodeEntryMessage(string msg)
        {
            IntPtr address = (IntPtr)Addrs.UIAddrs.STATIC_UI_INVALID_SECRET_CODE_ENTRY_TEXT;
            ASM.Abolish(address, INVALID_SECRET_CODE_ENTRY_TEXT_MAX_LENGTH);
            memory.WriteStringASCII(address, msg.Substring(0, INVALID_SECRET_CODE_ENTRY_TEXT_MAX_LENGTH));
        }
    }
}
