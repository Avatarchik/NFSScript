using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.MWAddresses;
using NFSScript.Math;

namespace NFSScript.MW
{
    /// <summary>
    /// A class representing the <see cref="Network"/> in the game.
    /// </summary>
    public static class Network
    {
        private const int NETWORK_LOBBY_IP_LENGTH = 32;

        /// <summary>
        /// The network's lobby IP (A string with a length of 32).
        /// </summary>
        public static string lobbyIP
        {
            get { return _readNetworkLobbyIP(); }
            set { _setNetworkLobbyIP(value); }
        }

        /// <summary>
        /// The network's lobby port.
        /// </summary>
        public static ushort lobbyPort
        {
            get { return _readNetworkLobbyPort(); }
            set { _setNetworkLobbyPort(value); }
        }

        /// <summary>
        /// A value that indicates whether the network debug is enabled or not.
        /// </summary>
        public static bool debug
        {
            get { return _readIsNetworkDebug(); }
            set { _setIsNetworkDebug(value); }
        }

        internal static bool _readIsNetworkDebug()
        {
            return memory.ReadByte((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_DEBUG) == 1;
        }

        internal static void _setIsNetworkDebug(bool value)
        {
            byte b = 0;
            if (value)
                b = 1;

            memory.WriteByte((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_DEBUG, b);
        }

        internal static ushort _readNetworkLobbyPort()
        {
            return memory.ReadUShort((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_LOBBY_PORT);
        }

        internal static void _setNetworkLobbyPort(ushort port)
        {
            memory.WriteUShort((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_LOBBY_PORT, port);
        }

        internal static string _readNetworkLobbyIP()
        {
            IntPtr address = (IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_LOBBY_IP;
            return memory.ReadStringASCII(address, NETWORK_LOBBY_IP_LENGTH);
        }

        internal static void _setNetworkLobbyIP(string ip)
        {
            IntPtr address = (IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_LOBBY_IP;
            ASM.Abolish(address, NETWORK_LOBBY_IP_LENGTH);
            memory.WriteStringASCII(address, ip.Substring(0, NETWORK_LOBBY_IP_LENGTH));
        }

        /// <summary>
        /// A class for the <see cref="Network"/>'s <see cref="GameRoom"/>.
        /// </summary>
        public static class GameRoom
        {
            /// <summary>
            /// Get the players in the current game room.
            /// </summary>
            public static Player[] players { get { return _readPlayers(); } }

            internal static Player[] _readPlayers()
            {
                Player[] players = new Player[4];
                players[0] = new Player(0);
                players[1] = new Player(1);
                players[2] = new Player(2);
                players[3] = new Player(3);

                return players;
            }

            /// <summary>
            /// A class for player's own host game.
            /// </summary>
            public static class HostGame
            {
                /// <summary>
                /// The minimum amount of laps in the player's own host game.
                /// </summary>
                public static byte minimumLaps { get { return _readMinLaps(); } set { _setMinLaps(value); } }

                /// <summary>
                /// The maximum amount of laps in the player's own host game.
                /// </summary>
                public static byte maximumLaps { get { return _readMaxLaps(); } set { _setMaxLaps(value); } }

                internal static byte _readMaxLaps()
                {
                    return memory.ReadByte((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_HOST_MAX_LAPS_1);
                }

                internal static byte _readMinLaps()
                {
                    return memory.ReadByte((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_HOST_MIN_LAPS_1);
                }

                internal static void _setMaxLaps(byte laps)
                {
                    memory.WriteByte((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_HOST_MAX_LAPS_1, laps);
                    memory.WriteByte((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_HOST_MAX_LAPS_2, laps);
                }

                internal static void _setMinLaps(byte laps)
                {
                    memory.WriteByte((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_HOST_MIN_LAPS_1, laps);
                    memory.WriteByte((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_HOST_MIN_LAPS_2, laps);
                }
            }
        }

        /// <summary>
        /// A class representing a <see cref="Player"/> in the game's <see cref="Network"/>.
        /// </summary>
        public class Player
        {
            /// <summary>
            /// The ID of the <see cref="Player"/>.
            /// </summary>
            public int ID { get; private set; }

            /// <summary>
            /// The name of the <see cref="Player"/>.
            /// </summary>
            public string Name { get { return _readName(); } }

            /// <summary>
            /// The unique ID of the <see cref="Player"/>.
            /// </summary>
            public string UID { get { return _readUID(); } }

            /// <summary>
            /// Instantiate a <see cref="Network"/> <see cref="Player"/> class by ID.
            /// </summary>
            /// <param name="ID"></param>
            public Player(int ID)
            {
                this.ID = ID;
            }

            /// <summary>
            /// Returns a nicely formmated <see cref="Player"/> string.
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return string.Format("ID: {0} Player: {1} UID: {2}", ID, Name, UID);
            }

            internal string _readName()
            {
                int offset = 0;
                for (int i = 0; i < ID; i++)
                {
                    offset = offset + Addrs.NetworkAddrs.STATIC_OFFSET_GAME_ROOM_PLAYER;
                }
                return Encoding.Default.GetString(memory.ReadByteArray((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_GAME_ROOM_PLAYER + offset, 12).Where(b => b != 0x00).ToArray());
            }

            internal string _readUID()
            {
                int offset = 0;
                for (int i = 0; i < ID; i++)
                {
                    offset = offset + Addrs.NetworkAddrs.STATIC_OFFSET_GAME_ROOM_PLAYER;
                }
                return memory.ReadStringASCII((IntPtr)Addrs.NetworkAddrs.STATIC_NETWORK_GAME_ROOM_PLAYER + Addrs.NetworkAddrs.STATIC_OFFSET_GAME_ROOM_PLAYER_UID
                    + offset, 9).Replace(" ", string.Empty);
            }
        }
    }
}
