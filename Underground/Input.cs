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
    /// A class for the game's inputs
    /// </summary>
    public static class Input
    {
        /// <summary>
        /// The ID for the throttle (acceleration) main input.
        /// </summary>
        public const int MAIN_THROTTLE_INPUT_ID = 0x100;

        /// <summary>
        /// The ID for the reverse main input.
        /// </summary>
        public const int MAIN_REVERSE_INPUT_ID = 0x101;

        /// <summary>
        /// The ID for the steering right main input.
        /// </summary>
        public const int MAIN_STEERING_RIGHT_INPUT_ID = 0x102;

        /// <summary>
        /// The ID for the steering left main input.
        /// </summary>
        public const int MAIN_STEERING_LEFT_INPUT_ID = 0x103;

        /// <summary>
        /// The ID for the E-Brake main input.
        /// </summary>
        public const int MAIN_EBRAKE_INPUT_ID = 0x104;

        /// <summary>
        /// The ID for the nitrous main input.
        /// </summary>
        public const int MAIN_NITROUS_BOOST_INPUT_ID = 0x105;

        /// <summary>
        /// The ID for the shift up main input.
        /// </summary>
        public const int MAIN_SHIFT_UP_INPUT_ID = 0x106;

        /// <summary>
        /// The ID for the shift down main input.
        /// </summary>
        public const int MAIN_SHIFT_DOWN_INPUT_ID = 0x107;

        /// <summary>
        /// The ID for the look back main input.
        /// </summary>
        public const int MAIN_LOOK_BACK_INPUT_ID = 0x108;

        /// <summary>
        /// The ID for the change camera main input.
        /// </summary>
        public const int MAIN_CAMERA_CHANGE_INPUT_ID = 0x109;

        /// <summary>
        /// The ID for the reset car main input.
        /// </summary>
        public const int MAIN_RESET_CAR_INPUT_ID = 0x10A;

        /// <summary>
        /// Return the DirectX key binded to the input ID.
        /// </summary>
        /// <param name="inputID"></param>
        /// <returns></returns>
        public static DirectXKeys GetInputKey(int inputID)
        {
            switch (inputID)
            {
                default:
                    return DirectXKeys.None;

                case MAIN_THROTTLE_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_THROTTLE_MAIN_INPUT);

                case MAIN_REVERSE_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_REVERSE_MAIN_INPUT);

                case MAIN_STEERING_LEFT_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_STEERING_LEFT_MAIN_INPUT);

                case MAIN_STEERING_RIGHT_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_STEERING_RIGHT_MAIN_INPUT);

                case MAIN_EBRAKE_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_EBRAKE_MAIN_INPUT);

                case MAIN_NITROUS_BOOST_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_NITROUS_BOOST_MAIN_INPUT);

                case MAIN_SHIFT_UP_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_SHIFT_UP_MAIN_INPUT);

                case MAIN_SHIFT_DOWN_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_SHIFT_DOWN_MAIN_INPUT);

                case MAIN_LOOK_BACK_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_LOOK_BACK_MAIN_INPUT);

                case MAIN_CAMERA_CHANGE_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_CAMERA_CHANGE_MAIN_INPUT);

                case MAIN_RESET_CAR_INPUT_ID:
                    return (DirectXKeys)memory.ReadUShort((IntPtr)Addrs.GenericAddrs.STATIC_RESET_CAR_MAIN_INPUT);
            }
        }
    }
}
