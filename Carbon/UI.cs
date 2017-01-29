using System;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.CarbonAddresses;
using static NFSScript.CarbonFunctions;
using NFSScript.Math;

namespace NFSScript.Carbon
{
    /// <summary>
    /// A struct that represents the game's UI.
    /// </summary>
    public static class UI
    {
        /// <summary>
        /// Returns the point of where the game's cursor is located on screen. (Might be inaccurate)
        /// </summary>
        public static Point cursorPosition
        {
            get
            {
                ushort x = memory.ReadUShort((IntPtr)Addrs.UIAddrs.STATIC_CURSOR_POS_X);
                ushort y = memory.ReadUShort((IntPtr)Addrs.UIAddrs.STATIC_CURSOR_POS_Y);

                return new Point(x, y);
            }
        }

        /// <summary>
        /// Show a race countdown.
        /// </summary>
        public static void ShowRaceCountdown()
        {
            Function.Call(SHOW_RACE_COUNTDOWN);
        }

        /// <summary>
        /// Shows a time extension.
        /// </summary>
        public static void ShowTimeExtension()
        {
            Function.Call(SHOW_TIME_EXTENSION);
        }

        /// <summary>
        /// Shows a screen text message on the HUD.
        /// </summary>
        /// <param name="message"></param>
        public static void ShowScreenTextMessage(string message)
        {
            _setErrorMsgString(message);
            Function.Call(SHOW_SCREEN_TEXT_MESSAGE, 0x1, 0x1, 0x1, 0x8AB83EDB, 0x0, Addrs.UIAddrs.STATIC_ERROR_ALLOCATED_MSG);
        }

        private const int ERROR_MSG_MAX_LENGTH = 44;
        internal static void _setErrorMsgString(string s)
        {
            IntPtr address = (IntPtr)Addrs.UIAddrs.STATIC_ERROR_ALLOCATED_MSG;
            ASM.Abolish(address, ERROR_MSG_MAX_LENGTH);
            string newString = s;
            if (newString.Length > ERROR_MSG_MAX_LENGTH)
                newString = newString.Substring(0, ERROR_MSG_MAX_LENGTH);
            memory.WriteStringASCII(address, newString);
        }

        /// <summary>
        /// A class that represents the UI's minimap.
        /// </summary>
        public static class Minimap
        {
            /// <summary>
            /// Set the color edge of the minimap's route route line mesh renderer.
            /// </summary>
            /// <param name="color"></param>
            public static void SetMinimapRouteColourEdge(Color color)
            {
                _setMinimapRouteColourEdge(color.r, color.g, color.b, color.a);
            }

            /// <summary>
            /// Set the color center of the minimap's route line mesh renderer.
            /// </summary>
            /// <param name="color"></param>
            public static void SetMinimapRouteColorCenter(Color color)
            {
                _setMinimapRouteColorCenter(color.r, color.g, color.b, color.a);
            }

            /// <summary>
            /// Set the width of the minimap's route line mesh renderer.
            /// </summary>
            /// <param name="value"></param>
            public static void SetMinimapRouteWidth(float value)
            {
                _setMinimapRouteWidth(value);
            }

            /// <summary>
            /// An internal function for changing the colour edge of the minimap's route.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="z"></param>
            /// <param name="w"></param>
            internal static void _setMinimapRouteColourEdge(float x, float y, float z, float w)
            {
                int address = memory.ReadInt32((IntPtr)memory.getBaseAddress + Addrs.UIAddrs.PNONSTATIC_MINIMAP_ROUTE_COLOR_EDGE_X);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_1);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_2);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_3);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_4);

                memory.WriteFloat((IntPtr)(address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_5), x);
                memory.WriteFloat((IntPtr)(address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_5 + Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER), y);
                memory.WriteFloat((IntPtr)(address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_5 + (Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER + Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER)), z);
                memory.WriteFloat((IntPtr)(address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_EDGE_X_5 + (Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER + Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER 
                    + Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER)), w);
            }

            /// <summary>
            /// An internal function for changing the colour center of the minimap's route.
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="z"></param>
            /// <param name="w"></param>
            internal static void _setMinimapRouteColorCenter(float x, float y, float z, float w)
            {
                int address = memory.ReadInt32((IntPtr)memory.getBaseAddress + Addrs.UIAddrs.PNONSTATIC_MINIMAP_ROUTE_COLOR_CENTER_X);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_1);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_2);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_3);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_4);

                memory.WriteFloat((IntPtr)(address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_5), x);
                memory.WriteFloat((IntPtr)(address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_5 + Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER), y);
                memory.WriteFloat((IntPtr)(address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_5 + (Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER + Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER)), z);
                memory.WriteFloat((IntPtr)(address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_COLOR_CENTER_X_5 + (Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER 
                    + Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER + Addrs.UIAddrs.OFFSET_MINIMAP_ROUTE_COLOR_CENTER)), w);
            }

            /// <summary>
            /// An internal function for changing the minimap's route width.
            /// </summary>
            /// <param name="value"></param>
            internal static void _setMinimapRouteWidth(float value)
            {
                int address = memory.ReadInt32((IntPtr)memory.getBaseAddress + Addrs.UIAddrs.PNONSTATIC_MINIMAP_ROUTE_WIDTH);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_WIDTH_1);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_WIDTH_2);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_WIDTH_3);
                address = memory.ReadInt32((IntPtr)address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_WIDTH_4);

                memory.WriteFloat((IntPtr)(address + Addrs.UIAddrs.POINTER_MINIMAP_ROUTE_WIDTH_5), value);
            }
        }
    }
/*  // Soon.
    /// <summary>
    /// An enum for the text mode.
    /// </summary>
    public enum TextMode : int
    {
        /// <summary>
        /// Show the text once.
        /// </summary>
        ShowOnce = 1,
        /// <summary>
        /// Show the text until ReloadHUD is called.
        /// </summary>
        Repeat = 2
    }

    /// <summary>
    /// An enum for the text location.
    /// </summary>
    public enum TextLocation : int
    {
        /// <summary>
        /// Show the text at the center of the screen.
        /// </summary>
        Center = 1,
        /// <summary>
        /// Show the text above the RPM meter.
        /// </summary>
        AboveRPMMeter = 2
    }

    /// <summary>
    /// An enum for the text type.
    /// </summary>
    public enum TextType : uint
    {
        /// <summary>
        /// Standard message type
        /// </summary>
        Standard = 0x8AB83EDB,
        /// <summary>
        /// Constant. Color not working when text is centered.
        /// </summary>
        PulsingTeal = 0x75A0BDB0,
        /// <summary>
        /// Constant. Color not working when text is centered.
        /// </summary>
        PulsingRed = 0x0A6797F23,
        /// <summary>
        /// Not working.
        /// </summary>
        ZoomOut = 0x9D73BC15,
        /// <summary>
        /// Not working.
        /// </summary>
        MoveRight = 0x9D73BC16,
        /// <summary>
        /// Constant. Color not working when text is centered.
        /// </summary>
        RedEaseInOut = 0x5230FAF6,
        /// <summary>
        /// Constant. Color not working when text is centered.
        /// </summary>
        TealEaseInOut = 0x9847B3E3,
        /// <summary>
        /// Constant. Color not working when text is centered.
        /// </summary>
        EaseInToRightConst = 0x2B3213E9,
        /// <summary>
        /// Not working.
        /// </summary>
        Busted = 0x3D6C4706,
        /// <summary>
        /// Only works when the text is centered.
        /// </summary>
        Unknown1 = 0x0D99A,
        /// <summary>
        /// 
        /// </summary>
        Unknown2 = 0x713E201B,
        /// <summary>
        /// 
        /// </summary>
        Unknown3 = 0x87AC789B,
        /// <summary>
        /// 
        /// </summary>
        Unknown4 = 0x136707
    }*/
}
