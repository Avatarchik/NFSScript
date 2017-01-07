using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.UGAddresses;
using NFSScript.Math;

namespace NFSScript.Underground
{
    /// <summary>
    /// A class representing the network in the game.
    /// </summary>
    public static class Network
    {
        private const int NETWORK_LOBBY_IP_LENGTH = 32;

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
    }
}
