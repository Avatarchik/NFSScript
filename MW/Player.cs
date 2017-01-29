using System;
using System.Collections.Generic;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.MWAddresses;
using NFSScript.Math;

namespace NFSScript.MW
{
    /// <summary>
    /// A struct that represents the game's <see cref="Player"/>.
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
        /// The <see cref="Player"/>'s rotation
        /// </summary>
        public static Quaternion Rotation
        {
            get
            {
                float x = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_X_ROT);
                float y = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_Y_ROT);
                float z = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_Z_ROT);
                float w = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_W_ROT);

                return new Quaternion(x, y, z, w);
            }
            set
            {
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_X_ROT, value.x);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_Y_ROT, value.y);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_Z_ROT, value.z);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_W_ROT, value.w);
            }
        }

        /// <summary>
        /// Sets a value indicating whether the AI controls the <see cref="Player"/>'s car.
        /// </summary>
        public static bool isControlledByAi
        {
            get
            {
                return memory.ReadByte((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_AI_CONTROL) == 1;
            }
        }

        /// <summary>
        /// Force the AI to control the <see cref="Player"/>'s car.
        /// </summary>
        public static void ForceAIControl()
        {
            memory.WriteByte((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_AI_CONTROL, 1);
        }

        /// <summary>
        /// Clear the AI control for the <see cref="Player"/>'s car.
        /// </summary>
        public static void ClearAIControl()
        {
            memory.WriteByte((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_AI_CONTROL, 0);
        }

        /// <summary>
        /// Saves the current <see cref="Player"/>'s current position to TRACKS/HotPositionL2RA.HOT.
        /// </summary>
        /// <param name="b">Valid range is 1-5</param>
        public static void SaveCurrentPositionToHOT(byte b)
        {
            memory.WriteByte((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_HOT_SAVE_POSITION, b);
        }

        /// <summary>
        /// Warps the <see cref="Player"/> to a saved position from TRACKS/HotPositionL2RA.HOT.
        /// </summary>
        /// <param name="b">Valid range is 1-5</param>
        public static void WarpToSavedPositionFromHOT(byte b)
        {
            memory.WriteByte((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_HOT_WARP_TO_SAVED_POSITION, b);
        }

        /// <summary>
        /// A class that represents the <see cref="Player"/>'s car.
        /// </summary>
        public static class Car
        {
            /// <summary>
            /// Returns the <see cref="Player"/>'s car speed.
            /// </summary>
            public static float GetSpeed()
            {
                return memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_SPEED);
            }

            /// <summary>
            /// Returns the car's left and right headlights intensity value.
            /// </summary>
            /// <returns></returns>
            public static Dictionary<string, float> GetCarHeadlightsBrightnessIntensityValue()
            {
                Dictionary<string, float> dic = new Dictionary<string, float>();


                dic.Add("Left", memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_HEADLIGHTS_LEFT));
                dic.Add("Right", memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_HEADLIGHTS_RIGHT));

                return dic;
            }
        }
    }
}
