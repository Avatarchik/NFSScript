using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.ProStreetAddresses;
using Funcs = NFSScript.ProStreetFunctions;
using NFSScript.Math;

namespace NFSScript.ProStreet
{
    /// <summary>
    /// A class that represents the game's <see cref="Player"/>.
    /// </summary>
    public static class Player
    {
        /// <summary>
        /// The <see cref="Player"/>'s position
        /// </summary>
        public static Vector3 Position
        {
            get
            {
                float x = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_POS_X);
                float y = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_POS_Y);
                float z = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_POS_Z);

                return new Vector3(x, y, z);
            }
            set
            {
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_POS_X, value.x);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_POS_Y, value.y);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_POS_Z, value.z);
            }
        }

        /// <summary>
        /// <see cref="Player"/>'s cash (Read only).
        /// </summary>
        public static int Cash
        {
            get
            {
                int addr = memory.ReadInt32((IntPtr)memory.getBaseAddress + Addrs.PlayerAddrs.NON_STATIC_PLAYER_CASH);
                return memory.ReadInt32((IntPtr)addr + Addrs.PlayerAddrs.POINTER_NON_STATIC_PLAYER_CASH);
            }
        }

        /// <summary>
        /// Award the <see cref="Player"/> with cash.
        /// </summary>
        /// <param name="value">The amount of cash to award.</param>
        public static void AwardCash(int value)
        {
            int addr = memory.ReadInt32((IntPtr)memory.getBaseAddress + Addrs.PlayerAddrs.NON_STATIC_PLAYER_CASH);
            memory.WriteInt32((IntPtr)addr + Addrs.PlayerAddrs.POINTER_NON_STATIC_PLAYER_CASH, value);
        }

        /// <summary>
        /// Force the AI to control the <see cref="Player"/>'s car.
        /// </summary>
        public static void ForceAIControl()
        {
            Function.Call(Funcs.FORCE_AI_CONTROL);
        }

        /// <summary>
        /// Clear the AI control for the <see cref="Player"/>'s car.
        /// </summary>
        public static void ClearAIControl()
        {
            Function.Call(Funcs.CLEAR_AI_CONTROL);
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
