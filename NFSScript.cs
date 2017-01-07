using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFSScript
{
    /// <summary>
    /// A class for NFSScript related funcions and variables.
    /// </summary>
    public static class NFSScript
    {
        /// <summary>
        /// 
        /// </summary>
        public static NFSGame currentLoadedNFSGame;   
    }

    /// <summary>
    /// NFSGame enum.
    /// </summary>
    public enum NFSGame : byte
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// The game Need for Speed: Underground.
        /// </summary>
        Underground = 1,
        /// <summary>
        /// The game Need for Speed: Underground 2.
        /// </summary>
        Underground2 = 2,
        /// <summary>
        /// The game Need for Speed: Most Wanted.
        /// </summary>
        MW = 3,
        /// <summary>
        /// The game Need for Speed: Carbon.
        /// </summary>
        Carbon = 4,
        /// <summary>
        /// The game Need for Speed: ProStreet.
        /// </summary>
        ProStreet = 5,
        /// <summary>
        /// The game Need for Speed: Undercover.
        /// </summary>
        Undercover = 6,
        /// <summary>
        /// Undetermined game.
        /// </summary>
        Undetermined = 7
    }
}
