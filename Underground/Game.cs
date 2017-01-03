using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Memory;
using static NFSScript.Memory.GameMemory;
using Addrs = NFSScript.Memory.UGAddresses;
using NFSScript.Math;

namespace NFSScript.Underground
{
    /// <summary>
    /// A class that represents the main game manager.
    /// </summary>
    public static class Game
    {
        /// <summary>
        /// Returns the amount of seconds it takes to render a frame (I have no idea if this is the correct address though..)
        /// </summary>
        public static float lastFrameTime
        {
            get
            {
                return memory.ReadFloat((IntPtr)Addrs.GenericAddrs.STATIC_LAST_FRAME_TIME);
            }
        }

        /// <summary>
        /// Returns for how long the gameplay is active.
        /// </summary>
        public static float gameplayTimer
        {
            get
            {
                return memory.ReadFloat((IntPtr)Addrs.GenericAddrs.STATIC_GAMEPLAY_ACTIVE_TIMER);
            }
        }

        /// <summary>
        /// Returns a value indicating whether the game world is or not.
        /// </summary>
        public static bool isGameWorldLoaded {
            get
            {
                byte b = memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_GAME_WORLD_LOADED);
                if (b == 1)
                    return true;
                else return false;
            }
        }

        /// <summary>
        /// Returns a value indicating whether the game is active or not.
        /// </summary>
        public static bool isGameplayActive
        {
            get {
                byte b = memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_GAMEPLAY_ACTIVE);
                if (b == 1)
                    return true;
                else return false;
            }
        }

        /// <summary>
        /// Returns the text field for cheats, useful if you want to implement custom cheats.
        /// </summary>
        /// <returns></returns>
        public static char[] GetCheatField()
        {
            return memory.ReadStringASCII((IntPtr)Addrs.GenericAddrs.STATIC_CHEAT_INPUT_FIELD, 32).ToCharArray();
        }
    }
}
