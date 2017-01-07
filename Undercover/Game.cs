using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.UndercoverAddresses;
using NFSScript.Math;

namespace NFSScript.Undercover
{
    /// <summary>
    ///  A struct that represents the main game manager.
    /// </summary>
    public static class Game
    {
        /// <summary>
        /// Returns the amount of seconds it takes to render a frame
        /// </summary>
        public static float lastFrameTime
        {
            get
            {
                return memory.ReadFloat((IntPtr)Addrs.GenericAddrs.STATIC_LAST_FRAME_TIME);
            }
        }

        /// <summary>
        /// Returns a boolean that indicates whether the game is paused or not.
        /// </summary>
        public static bool isGamePaused
        {
            get
            {
                byte b = memory.ReadByte((IntPtr)Addrs.GameAddrs.STATIC_IS_GAME_NOT_PAUSED);
                if (b == 0)
                    return true;
                else return false;
            }
        }

        /// <summary>
        /// Returns a string with a length of 27 which contains the latest entered code (If the player has entered any).
        /// </summary>
        /// <returns></returns>
        public static string GetSecretCodeField()
        {
            return memory.ReadStringASCII((IntPtr)Addrs.GameAddrs.STATIC_GET_SECRET_CODE_FIELD, 27);
        }
    }
}
