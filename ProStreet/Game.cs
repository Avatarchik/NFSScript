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
    /// A struct that represents the main game manager.
    /// </summary>
    public static class Game
    {
        /// <summary>
        /// Returns the current game state.
        /// </summary>
        /// <returns></returns>
        public static GameState GetGameState()
        {
            return (GameState)Enum.Parse(typeof(GameState), memory.ReadByte((IntPtr)Addrs.GenericAddrs.STATIC_GAME_STATE).ToString());
        }

        /// <summary>
        /// Returns true is the gameplay is active.
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
        /// Shows a loading screen.
        /// </summary>
        public static void ShowLoadingScreen()
        {
            Function.Call(Funcs.SHOW_LOADING_SCREEN);
        }

        /// <summary>
        /// Hides a loading screen.
        /// </summary>
        public static void HideLoadingScreen()
        {
            Function.Call(Funcs.HIDE_LOADING_SCREEN);
        }

        /// <summary>
        /// Returns a string with a length of 26 which contains the latest entered code (If the player has entered any).
        /// </summary>
        /// <returns></returns>
        public static string GetEnteredCode()
        {
            return memory.ReadStringASCII((IntPtr)Addrs.GameAddrs.STATIC_ENTERED_CODE, 26);
        }
    }

    /// <summary>
    /// An enum that represents the game state in NFS: ProStreet.
    /// </summary>
    public enum GameState : byte
    {
        /// <summary>
        /// No game state.
        /// </summary>
        None = 0,
        /// <summary>
        /// Loading before going into the FE game state.
        /// </summary>
        LoadingFE = 1,
        /// <summary>
        /// FE game state.
        /// </summary>
        FE = 3,
        /// <summary>
        /// Preloading game state.
        /// </summary>
        PreLoading = 4,
        /// <summary>
        /// Loading game state. (Inconsistent)
        /// </summary>
        Loading = 5,
        /// <summary>
        /// InGame game state.
        /// </summary>
        InGame = 6
    }
}
