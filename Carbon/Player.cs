using System;
using System.Collections.Generic;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.CarbonAddresses;
using static NFSScript.CarbonFunctions;
using NFSScript.Math;

namespace NFSScript.Carbon
{
    /// <summary>
    /// A class that represents the game's <see cref="Player"/>.
    /// </summary>
    public static class Player
    {
        #region Constant Variables
        private const uint POLICE_IGNORE_PLAYER_ENABLED = 3943023862U;
        private const uint POLICE_IGNORE_PLAYER_DISABLED = 2047198454U;
        #endregion

        /// <summary>
        /// The <see cref="Player"/>'s position
        /// </summary>
        public static Vector3 Position
        {
            get
            {
                int addr = (int)memory.getBaseAddress;
                float x = memory.ReadFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_X_POS);
                float y = memory.ReadFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_Y_POS);
                float z = memory.ReadFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_Z_POS);

                return new Vector3(x, y, z);
            }
            set
            {
                int addr = (int)memory.getBaseAddress;
                memory.WriteFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_X_POS, value.x);
                memory.WriteFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_Y_POS, value.y);
                memory.WriteFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_Z_POS, value.z);
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
        /// Returns the <see cref="Player"/>'s last known position (Read only).
        /// </summary>
        public static Vector3 LastKnownPosition
        {
            get
            {
                float x = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_LAST_KNOWN_POSITION_X);
                float y = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_LAST_KNOWN_POSITION_Y);
                float z = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_LAST_KNOWN_POSITION_Z);

                return new Vector3(x, y, z);
            }
        }

        /// <summary>
        /// <see cref="Player"/>'s cash (Read only).
        /// </summary>
        public static int cash
        {
            get
            {
                int address = memory.ReadInt32((IntPtr)memory.getBaseAddress + Addrs.PlayerAddrs.PNONSTATIC_PLAYER_CASH);
                address = memory.ReadInt32((IntPtr)address + Addrs.PlayerAddrs.POINTER_PLAYER_CASH_1);
                address = memory.ReadInt32((IntPtr)address + Addrs.PlayerAddrs.POINTER_PLAYER_CASH_2);
                address = memory.ReadInt32((IntPtr)address + Addrs.PlayerAddrs.POINTER_PLAYER_CASH_3);
                address = memory.ReadInt32((IntPtr)address + Addrs.PlayerAddrs.POINTER_PLAYER_CASH_4);
                address = memory.ReadInt32((IntPtr)address + Addrs.PlayerAddrs.POINTER_PLAYER_CASH_5);

                return memory.ReadInt32((IntPtr)address);
            }
        }

        /// <summary>
        /// Sets a value indicating whether the <see cref="Player"/> is ignored by the police or not.
        /// </summary>
        public static bool ignoredByPolice
        {
            get
            {
                uint value = memory.ReadUInteger((IntPtr)Addrs.PlayerAddrs.STATIC_POLICE_IGNORE_PLAYER);
                if (value == POLICE_IGNORE_PLAYER_ENABLED)
                    return true;
                else return false;
            }
            set
            {
                if (value)
                    memory.WriteUInteger((IntPtr)Addrs.PlayerAddrs.STATIC_POLICE_IGNORE_PLAYER, POLICE_IGNORE_PLAYER_ENABLED);
                else memory.WriteUInteger((IntPtr)Addrs.PlayerAddrs.STATIC_POLICE_IGNORE_PLAYER, POLICE_IGNORE_PLAYER_DISABLED);
            }
        }

        /// <summary>
        /// Sets a value indicating whether the AI controls the <see cref="Player"/>'s car.
        /// </summary>
        public static bool isControlledByAi
        {
            get
            {
                return _safeGetAIControlValue();
            }
        }

        /// <summary>
        /// Award the <see cref="Player"/> with cash.
        /// </summary>
        /// <param name="value"></param>
        public static void AwardCash(int value)
        {
            int address = memory.ReadInt32((IntPtr)memory.getBaseAddress + Addrs.PlayerAddrs.PNONSTATIC_PLAYER_CASH);
            address = memory.ReadInt32((IntPtr)address + Addrs.PlayerAddrs.POINTER_PLAYER_CASH_1);
            address = memory.ReadInt32((IntPtr)address + Addrs.PlayerAddrs.POINTER_PLAYER_CASH_2);
            address = memory.ReadInt32((IntPtr)address + Addrs.PlayerAddrs.POINTER_PLAYER_CASH_3);
            address = memory.ReadInt32((IntPtr)address + Addrs.PlayerAddrs.POINTER_PLAYER_CASH_4);
            address = memory.ReadInt32((IntPtr)address + Addrs.PlayerAddrs.POINTER_PLAYER_CASH_5);

            memory.WriteInt32((IntPtr)address, Player.cash + value);
        }

        /// <summary>
        /// Force the AI to control the <see cref="Player"/>'s car.
        /// </summary>
        public static void ForceAIControl()
        {
            uint u = memory.ReadUInteger((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_AI_CONTROL);
            memory.WriteByte((IntPtr)u + Addrs.PlayerAddrs.POINTER_PLAYER_AI_CONTROL_POINTER, 1);
        }

        /// <summary>
        /// Clear the AI control for the <see cref="Player"/>'s car.
        /// </summary>
        public static void ClearAIControl()
        {
            uint u = memory.ReadUInteger((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_AI_CONTROL);
            memory.WriteByte((IntPtr)u + Addrs.PlayerAddrs.POINTER_PLAYER_AI_CONTROL_POINTER, 0);
        }

        /// <summary>
        /// Prevent the player from being busted by the cops.
        /// </summary>
        public static void PreventPlayerBeingBusted()
        {
            Function.Call(PREVENT_PLAYER_BEING_BUSTED);
        }

        /// <summary>
        /// Saves the current <see cref="Player"/>'s current position to TRACKS/HotPositionL5RA.HOT.
        /// </summary>
        /// <param name="b">Valid range is 1-5</param>
        public static void SaveCurrentPositionToHOT(byte b)
        {
            memory.WriteByte((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_HOT_SAVE_POSITION, b);
        }

        /// <summary>
        /// Warps the <see cref="Player"/> to a saved position from TRACKS/HotPositionL5RA.HOT.
        /// </summary>
        /// <param name="b">Valid range is 1-5</param>
        public static void WarpToSavedPositionFromHOT(byte b)
        {
            memory.WriteByte((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_HOT_WARP_TO_SAVED_POSITION, b);
        }
        
        internal static bool _safeGetAIControlValue()
        {
            byte skipFEEnabled = memory.ReadByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_DAMAGE_ENABLED);
            byte skipFEAI = memory.ReadByte((IntPtr)Addrs.GameAddrs.STATIC_SKIP_FE_AI_CONTROL_PLAYER);
            uint u = memory.ReadUInteger((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_AI_CONTROL);
            byte aiControl = memory.ReadByte((IntPtr)u + Addrs.PlayerAddrs.POINTER_PLAYER_AI_CONTROL_POINTER);

            if (aiControl == 1)
                return true;

            if (skipFEEnabled == 1)
            {
                if (skipFEAI == 1)
                    return true;
                else if (skipFEAI == 0)
                    return false;
            }

            return false;
        }

        /// <summary>
        /// A class that represents the <see cref="Player"/>'s car.
        /// </summary>
        public static class Car
        {
            /// <summary>
            /// Sets a value indicating whether the car should drift like in-game cutscnes (NIS) using the handbrake. (Unsafe, may crash the game if not called on the proper game state).
            /// </summary>
            public static bool _unsafeEnableAugmentedDriftWithEBrake
            {
                get
                {
                    byte b = memory.ReadByte((IntPtr)Addrs.PlayerAddrs.STATIC_AUGMENTED_DRIFT_WITH_EBRAKE);
                    if (b == 1)
                        return true;
                    else return false;
                }
                set
                {
                    if (value == true)
                        memory.WriteByte((IntPtr)Addrs.PlayerAddrs.STATIC_AUGMENTED_DRIFT_WITH_EBRAKE, 1);
                    else memory.WriteByte((IntPtr)Addrs.PlayerAddrs.STATIC_AUGMENTED_DRIFT_WITH_EBRAKE, 0);
                }
            }

            /// <summary>
            /// Sets the car's left and right headlights intensity value.
            /// </summary>
            /// <param name="left"></param>
            /// <param name="right"></param>
            public static void SetCarHeadlightsBrightnessIntensityValue(float left, float right)
            {
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_HEADLIGHTS_LEFT, left);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_HEADLIGHTS_RIGHT, right);

            }

            /// <summary>
            /// Returns the <see cref="Player"/>'s car speed.
            /// </summary>
            public static float GetSpeed()
            {
                return memory.ReadFloat((IntPtr)memory.getBaseAddress + Addrs.PlayerAddrs.NONSTATIC_PLAYER_SPEED);
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
