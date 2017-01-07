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
    /// A class that represents the game's <see cref="Player"/>.
    /// </summary>
    public static class Player
    {
        /// <summary>
        /// Returns a boolean that indicates whether the <see cref="Player"/> is in pursuit or not.
        /// </summary>
        public static bool isInPursuit
        {
            get
            {
                byte b = memory.ReadByte((IntPtr)Addrs.PlayerAddrs.STATIC_IS_IN_PURSUIT);
                if (b == 1)
                    return true;
                else return false;
            }
        }
        /// <summary>
        /// A class that represents the <see cref="Player"/>'s car.
        /// </summary>
        public static class Car
        {
            /// <summary>
            /// Returns the <see cref="Player"/>'s car current speed in MPH.
            /// </summary>
            /// <returns></returns>
            public static float GetSpeed()
            {
                return memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_SPEED);
            }
        }
    }
}
