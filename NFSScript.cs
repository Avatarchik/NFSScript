using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFSScript
{
    /// <summary>
    /// 
    /// </summary>
    public static class NFSScript
    {
        /// <summary>
        /// 
        /// </summary>
        public static NFSGame currentLoadedNFSGame;   
    }

    /// <summary>
    /// 
    /// </summary>
    public enum NFSGame : byte
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,
        /// <summary>
        /// 
        /// </summary>
        Underground = 1,
        /// <summary>
        /// 
        /// </summary>
        Underground2 = 2,
        /// <summary>
        /// 
        /// </summary>
        MW = 3,
        /// <summary>
        /// 
        /// </summary>
        Carbon = 4,
        /// <summary>
        /// 
        /// </summary>
        ProStreet = 5,
        /// <summary>
        /// 
        /// </summary>
        Undercover = 6,
        /// <summary>
        /// 
        /// </summary>
        Undetermined = 7
    }
}
