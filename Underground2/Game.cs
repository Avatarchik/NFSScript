using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.UG2Addresses;
using NFSScript.Math;

namespace NFSScript.Underground2
{
    /// <summary>
    /// A class that represents the main game manager.
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
        /// Returns a value indicating whether the game is active or not.
        /// </summary>
        public static bool isGameplayActive
        {
            get
            {
                byte b = memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_GAMEPLAY_ACTIVE);
                if (b == 1)
                    return true;
                else return false;
            }
        }
        
        /// <summary>
        /// Returns a value that indicates whether the game is in replay mode or not.
        /// </summary>
        public static bool isInReplayMode
        {
            get {
                byte b = memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_IS_REPLAY_MODE);
                if (b == 1) return true;
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

        /// <summary>
        /// A struct that represents the game's world.
        /// </summary>
        public struct World
        {
            /// <summary>
            ///  The neon brightness value for cars present at the game's world.
            /// </summary>
            public static float carsNeonBrightness
            {
                get { return memory.ReadFloat((IntPtr)Addrs.WorldAddrs.STATIC_WORLD_CARS_NEON_BRIGHTNESS); }
                set { memory.WriteFloat((IntPtr)Addrs.WorldAddrs.STATIC_WORLD_CARS_NEON_BRIGHTNESS, value); }
            }
        }
    }

    /// <summary>
    /// The game's flow manager class.
    /// </summary>
    public class GameFlowManager
    {
        /// <summary>
        /// The address where the main GameFlowManager is located at.
        /// </summary>
        public static IntPtr address { get { return (IntPtr)Addrs.GenericAddrs.STATIC_GAME_STATE; } }

        private int gameStateValue;

        /// <summary>
        /// The main GameFlowManager.
        /// </summary>
        public static GameFlowManager TheGameFlowManager { get { return new GameFlowManager(memory.ReadInt32(address)); } }

        /// <summary>
        /// Instantiate a GameFlowManager class.
        /// </summary>
        /// <param name="gameStateValue"></param>
        private GameFlowManager(int gameStateValue)
        {
            this.gameStateValue = gameStateValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        public static implicit operator int(GameFlowManager instance)
        {
            if (instance == null)
            {
                return -1;
            }
            return instance.gameStateValue;
        }

        /// <summary>
        /// Returns the game state value string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return gameStateValue.ToString();
        }
    }
}
