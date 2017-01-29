using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NFSScript
{
    /// <summary>
    /// A class for DirectX Inputs.
    /// </summary>
    public struct DirectXInput
    {
        private static Dictionary<DirectXKeys, Keys> inputDictonary = new Dictionary<DirectXKeys, Keys>()
        {
            { DirectXKeys.None, Keys.None },
            { DirectXKeys.Escape, Keys.Escape },
            { DirectXKeys.One, Keys.D1 },
            { DirectXKeys.Two, Keys.D2 },
            { DirectXKeys.Three, Keys.D3 },
            { DirectXKeys.Four, Keys.D4 },
            { DirectXKeys.Five, Keys.D5 },
            { DirectXKeys.Six, Keys.D6 },
            { DirectXKeys.Seven, Keys.D7 },
            { DirectXKeys.Eight, Keys.D8 },
            { DirectXKeys.Nine, Keys.D9 },
            { DirectXKeys.Zero, Keys.D0 },
            { DirectXKeys.Minus, Keys.OemMinus },
            { DirectXKeys.Equals, Keys.Oemplus },
            { DirectXKeys.Backspace, Keys.Back },
            { DirectXKeys.Tab, Keys.Tab },
            { DirectXKeys.Q, Keys.Q },
            { DirectXKeys.W, Keys.W },
            { DirectXKeys.E, Keys.E },
            { DirectXKeys.R, Keys.R },
            { DirectXKeys.T, Keys.T },
            { DirectXKeys.Y, Keys.Y },
            { DirectXKeys.U, Keys.U },
            { DirectXKeys.I, Keys.I },
            { DirectXKeys.O, Keys.O },
            { DirectXKeys.P, Keys.P },
            { DirectXKeys.LeftBracket, Keys.OemOpenBrackets },
            { DirectXKeys.RightBracket, Keys.OemCloseBrackets },
            { DirectXKeys.Enter, Keys.Return },
            { DirectXKeys.LeftControl, Keys.LControlKey },
            { DirectXKeys.A, Keys.A },
            { DirectXKeys.S, Keys.S },
            { DirectXKeys.D, Keys.D },
            { DirectXKeys.F, Keys.F },
            { DirectXKeys.G, Keys.G },
            { DirectXKeys.H, Keys.H },
            { DirectXKeys.J, Keys.J },
            { DirectXKeys.K, Keys.K },
            { DirectXKeys.L, Keys.L },
            { DirectXKeys.Semicolon, Keys.OemSemicolon },
            { DirectXKeys.Apostrophe, Keys.OemQuotes },
            { DirectXKeys.Tilde, Keys.Oemtilde },
            { DirectXKeys.LeftShift, Keys.LShiftKey },
            { DirectXKeys.Backslash, Keys.OemBackslash },
            { DirectXKeys.Z, Keys.Z },
            { DirectXKeys.X, Keys.X },
            { DirectXKeys.C, Keys.C },
            { DirectXKeys.V, Keys.V },
            { DirectXKeys.B, Keys.B },
            { DirectXKeys.N, Keys.N },
            { DirectXKeys.M, Keys.M },
            { DirectXKeys.Comma, Keys.Oemcomma },
            { DirectXKeys.Period, Keys.OemPeriod },
            { DirectXKeys.ForwardSlash, Keys.OemQuestion },
            { DirectXKeys.RightShift, Keys.RShiftKey },
            { DirectXKeys.LeftAlt, Keys.LMenu },
            { DirectXKeys.Spacebar, Keys.Space },
            { DirectXKeys.CapsLock, Keys.CapsLock },
            { DirectXKeys.F1, Keys.F1 },
            { DirectXKeys.F2, Keys.F2 },
            { DirectXKeys.F3, Keys.F3 },
            { DirectXKeys.F4, Keys.F4 },
            { DirectXKeys.F5, Keys.F5 },
            { DirectXKeys.F6, Keys.F6 },
            { DirectXKeys.F7, Keys.F7 },
            { DirectXKeys.F8, Keys.F8 },
            { DirectXKeys.F9, Keys.F9 },
            { DirectXKeys.F10, Keys.F10 },
            { DirectXKeys.NumLock, Keys.NumLock },
            { DirectXKeys.ScrollLock, Keys.Scroll },
            { DirectXKeys.Numpad7, Keys.NumPad7 },
            { DirectXKeys.Numpad8, Keys.NumPad8 },
            { DirectXKeys.Numpad9, Keys.NumPad9 },
            { DirectXKeys.Numpad4, Keys.NumPad4 },
            { DirectXKeys.Numpad5, Keys.NumPad5 },
            { DirectXKeys.Numpad6, Keys.NumPad6 },
            { DirectXKeys.Numpad1, Keys.NumPad1 },
            { DirectXKeys.Numpad2, Keys.NumPad2 },
            { DirectXKeys.Numpad3, Keys.NumPad3 },
            { DirectXKeys.Numpad0, Keys.NumPad0 },
            { DirectXKeys.F12, Keys.F12 },
            { DirectXKeys.F12, Keys.F12 },
            { DirectXKeys.NumpadEnter, Keys.Enter },
            { DirectXKeys.RightControl, Keys.RControlKey },
            { DirectXKeys.RightAlt, Keys.RMenu },
            { DirectXKeys.Home, Keys.Home },
            { DirectXKeys.UpArrow, Keys.Up },
            { DirectXKeys.PageUp, Keys.PageUp },
            { DirectXKeys.LeftArrow, Keys.Left },
            { DirectXKeys.RightArrow, Keys.Right },
            { DirectXKeys.End, Keys.End },
            { DirectXKeys.DownArrow, Keys.Down },
            { DirectXKeys.PageDown, Keys.PageDown },
            { DirectXKeys.Insert, Keys.Insert },
            { DirectXKeys.Delete, Keys.Delete },
            { DirectXKeys.LeftMouseButton, Keys.LButton },
            { DirectXKeys.RightMouseButton, Keys.RButton },
            { DirectXKeys.MiddleMouseButton, Keys.MButton },
            { DirectXKeys.MouseButton3, Keys.XButton1},
            { DirectXKeys.MouseButton4, Keys.XButton2 },
        };

        /// <summary>
        /// Converts a DirectX keycode to Forms keycode
        /// </summary>
        /// <param name="dKey"></param>
        /// <returns></returns>
        public static Keys DirectXKeyToKeys(DirectXKeys dKey)
        {
            Keys key;
            inputDictonary.TryGetValue(dKey, out key);

            return key;
        }

        /// <summary>
        /// Converts a Form keycode to DirectX keycode
        /// </summary>
        /// <param name="fKey"></param>
        /// <returns></returns>
        public static DirectXKeys KeysToDirectXKey(Keys fKey)
        {
            return inputDictonary.FirstOrDefault(x => x.Value == fKey).Key;
        }
    }

    /// <summary>
    /// Specifies DirectX keycodes.
    /// </summary>
    public enum DirectXKeys : ushort
    {
        /// <summary>
        /// The None Key
        /// </summary>
        None = 0,
        /// <summary>
        /// Escape key
        /// </summary>
        Escape = 1,
        /// <summary>
        /// The non-numpad 1 key
        /// </summary>
        One = 2,
        /// <summary>
        /// The non-numpad 2 key
        /// </summary>
        Two = 3,
        /// <summary>
        /// The non-numpad 3 key
        /// </summary>
        Three = 4,
        /// <summary>
        /// The non-numpad 4 key
        /// </summary>
        Four = 5,
        /// <summary>
        /// The non-numpad 5 key
        /// </summary>
        Five = 6,
        /// <summary>
        /// The non-numpad 6 key
        /// </summary>
        Six = 7,
        /// <summary>
        /// The non-numpad 7 key
        /// </summary>
        Seven = 8,
        /// <summary>
        /// The non-numpad 8 key
        /// </summary>
        Eight = 9,
        /// <summary>
        /// The non-numpad 9 key
        /// </summary>
        Nine = 10,
        /// <summary>
        /// The non-numpad 0 key
        /// </summary>
        Zero = 11,
        /// <summary>
        /// The Minus key (-)
        /// </summary>
        Minus = 12,
        /// <summary>
        /// The Equals key (=)
        /// </summary>
        Equals = 13,
        /// <summary>
        /// The Backspace key
        /// </summary>
        Backspace = 14,
        /// <summary>
        /// The Tab key
        /// </summary>
        Tab = 15,
        /// <summary>
        /// The Q key
        /// </summary>
        Q = 16,
        /// <summary>
        /// The W key
        /// </summary>
        W = 17,
        /// <summary>
        /// The E key
        /// </summary>
        E = 18,
        /// <summary>
        /// The R key
        /// </summary>
        R = 19,
        /// <summary>
        /// The T key
        /// </summary>
        T = 20,
        /// <summary>
        /// The Y key
        /// </summary>
        Y = 21,
        /// <summary>
        /// The U key
        /// </summary>
        U = 22,
        /// <summary>
        /// The I key
        /// </summary>
        I = 23,
        /// <summary>
        /// The O key
        /// </summary>
        O = 24,
        /// <summary>
        /// The P key
        /// </summary>
        P = 25,
        /// <summary>
        /// The Left-Bracket key
        /// </summary>
        LeftBracket = 26,
        /// <summary>
        /// The Right-Bracket key
        /// </summary>
        RightBracket = 27,
        /// <summary>
        /// The Enter (Return) key
        /// </summary>
        Enter = 28,
        /// <summary>
        /// The Left Control key
        /// </summary>
        LeftControl = 29,
        /// <summary>
        /// The A key
        /// </summary>
        A = 30,
        /// <summary>
        ///  The S key
        /// </summary>
        S = 31,
        /// <summary>
        /// The D key
        /// </summary>
        D = 32,
        /// <summary>
        /// The F key
        /// </summary>
        F = 33,
        /// <summary>
        /// The G key
        /// </summary>
        G = 34,
        /// <summary>
        /// The H key
        /// </summary>
        H = 35,
        /// <summary>
        /// The J key
        /// </summary>
        J = 36,
        /// <summary>
        /// The K key
        /// </summary>
        K = 37,
        /// <summary>
        /// The L key
        /// </summary>
        L = 38,
        /// <summary>
        /// The Semicolon key (;)
        /// </summary>
        Semicolon = 39,
        /// <summary>
        /// The Apostrophe key (')
        /// </summary>
        Apostrophe = 40,
        /// <summary>
        /// The Tilde key (~)
        /// </summary>
        Tilde = 41,
        /// <summary>
        /// The Left-Shift key
        /// </summary>
        LeftShift = 42,
        /// <summary>
        /// The Backslash key \
        /// </summary>
        Backslash = 43,
        /// <summary>
        /// The Z key
        /// </summary>
        Z = 44,
        /// <summary>
        /// The X key
        /// </summary>
        X = 45,
        /// <summary>
        /// The C key
        /// </summary>
        C = 46,
        /// <summary>
        /// The V key
        /// </summary>
        V = 47,
        /// <summary>
        /// The B key
        /// </summary>
        B = 48,
        /// <summary>
        /// The N key
        /// </summary>
        N = 49,
        /// <summary>
        /// The M key
        /// </summary>
        M = 50,
        /// <summary>
        /// The Comma key (,)
        /// </summary>
        Comma = 51,
        /// <summary>
        /// The Period key (.)
        /// </summary>
        Period = 52,
        /// <summary>
        /// The Forward Slash key (/)
        /// </summary>
        ForwardSlash = 53,
        /// <summary>
        /// The Right-Shift key
        /// </summary>
        RightShift = 54,
        /// <summary>
        /// The Left-Alt key
        /// </summary>
        LeftAlt = 56,
        /// <summary>
        /// The Spacebar key ( )
        /// </summary>
        Spacebar = 57,
        /// <summary>
        /// THE CAPSLOCK KEY
        /// </summary>
        CapsLock = 58,
        /// <summary>
        /// The F1 key
        /// </summary>
        F1 = 59,
        /// <summary>
        /// The F2 key
        /// </summary>
        F2 = 60,
        /// <summary>
        /// The F3 key
        /// </summary>
        F3 = 61,
        /// <summary>
        /// The F4 key
        /// </summary>
        F4 = 62,
        /// <summary>
        /// The F5 key
        /// </summary>
        F5 = 63,
        /// <summary>
        /// The F6 key
        /// </summary>
        F6 = 64,
        /// <summary>
        /// The F7 key
        /// </summary>
        F7 = 65,
        /// <summary>
        /// The F8 key
        /// </summary>
        F8 = 66,
        /// <summary>
        /// The F9 key
        /// </summary>
        F9 = 67,
        /// <summary>
        /// The F10 key
        /// </summary>
        F10 = 68,
        /// <summary>
        /// The Num-Lock key
        /// </summary>
        NumLock = 69,
        /// <summary>
        /// The Scroll-Lock key
        /// </summary>
        ScrollLock = 70,
        /// <summary>
        /// The number 7 on the numpad
        /// </summary>
        Numpad7 = 71,
        /// <summary>
        /// The number 8 on the numpad
        /// </summary>
        Numpad8 = 72,
        /// <summary>
        /// The number 9 on the numpad
        /// </summary>
        Numpad9 = 73,
        /// <summary>
        /// The number 4 on the numpad
        /// </summary>
        Numpad4 = 75,
        /// <summary>
        /// The number 5 on the numpad
        /// </summary>
        Numpad5 = 76,
        /// <summary>
        /// The number 6 on the numpad
        /// </summary>
        Numpad6 = 77,
        /// <summary>
        /// The number 1 on the numpad
        /// </summary>
        Numpad1 = 79,
        /// <summary>
        /// The number 2 on the numpad
        /// </summary>
        Numpad2 = 80,
        /// <summary>
        /// The number 3 on the numpad
        /// </summary>
        Numpad3 = 81,
        /// <summary>
        /// The number 0 on the numpad
        /// </summary>
        Numpad0 = 82,
        /// <summary>
        /// The F11 key
        /// </summary>
        F11 = 87,
        /// <summary>
        /// The F12 key
        /// </summary>
        F12 = 88,
        /// <summary>
        /// The enter key on the numpad
        /// </summary>
        NumpadEnter = 156,
        /// <summary>
        /// The Right-Control key
        /// </summary>
        RightControl = 157,
        /// <summary>
        /// The Right-Alt key
        /// </summary>
        RightAlt = 184,
        /// <summary>
        /// The Home key
        /// </summary>
        Home = 199,
        /// <summary>
        /// The Up-Arrow key
        /// </summary>
        UpArrow = 200,
        /// <summary>
        /// The PageUp key
        /// </summary>
        PageUp = 201,
        /// <summary>
        /// The Left-Arrow key
        /// </summary>
        LeftArrow = 203,
        /// <summary>
        /// The Right-Arrow key
        /// </summary>
        RightArrow = 205,
        /// <summary>
        /// The End key
        /// </summary>
        End = 207,
        /// <summary>
        /// The Down-Arrow key
        /// </summary>
        DownArrow = 208,
        /// <summary>
        /// The PageDown key
        /// </summary>
        PageDown = 209,
        /// <summary>
        /// The Insert key
        /// </summary>
        Insert = 210,
        /// <summary>
        /// The Delete key
        /// </summary>
        Delete = 211,
        /// <summary>
        /// The left mouse button keycode
        /// </summary>
        LeftMouseButton = 256,
        /// <summary>
        /// The right mouse button keycode
        /// </summary>
        RightMouseButton = 257,
        /// <summary>
        /// The middle mouse button keycode
        /// </summary>
        MiddleMouseButton = 258,
        /// <summary>
        /// Mouse button 3
        /// </summary>
        MouseButton3 = 259,
        /// <summary>
        /// Mouse button 4
        /// </summary>
        MouseButton4 = 260
    }
}
