using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static NFSScript.Memory.GameMemory;
using Addrs = NFSScript.Memory.CarbonAddresses;
using Funcs = NFSScript.Memory.CarbonFunctions;
using NFSScript.Math;

namespace NFSScript.Carbon
{
    /// <summary>
    /// A camera class which isn't fully functional. So please wait for a future update till you can use this!
    /// </summary>
    public class Camera : BaseCamera
    {
        private const float CARLOD_LOW_VALUE_1 = 10000f;
        private const float CARLOD_LOW_VALUE_2 = 16666.67f;
        private const float CARLOD_LOW_VALUE_3 = 2333.333f;
        private const float CARLOD_LOW_VALUE_4 = 2000f;

        private const float CARLOD_MID_VALUE_1 = 1550f;
        private const float CARLOD_MID_VALUE_2 = 2583.333f;
        private const float CARLOD_MID_VALUE_3 = 360.6667f;
        private const float CARLOD_MID_VALUE_4 = 310f;

        private const float CARLOD_HIGH_VALUE_1 = 0.0f;
        private const float CARLOD_HIGH_VALUE_2 = 0.0f;
        private const float CARLOD_HIGH_VALUE_3 = 0.0f;
        private const float CARLOD_HIGH_VALUE_4 = 0.0f;

        private const float CARLOD_DEFAULT_VALUE_1 = 150f;
        private const float CARLOD_DEFAULT_VALUE_2 = 250f;
        private const float CARLOD_DEFAULT_VALUE_3 = 35f;
        private const float CARLOD_DEFAULT_VALUE_4 = 30f;

        private float carLODValue1, carLODValue2, carLODValue3, carLODValue4;

        /// <summary>
        /// Gets or sets the current position of this <see cref="Camera"/>.
        /// </summary>
        public override Vector3 Position { get; set; }

        /// <summary>
        /// Gets or sets the current rotation of this <see cref="Camera"/>.
        /// </summary>
        public override Quaternion Rotation { get; set; }

        /// <summary>
        /// Returns a value that indicates whether this is the main camera or not.
        /// </summary>
        public bool IsMainCamera { get; private set; }

        /// <summary>
        /// Gets the main camera.
        /// </summary>
        public static Camera main { get { return new Camera(true); } }

        /// <summary>
        /// Instantiates a new <see cref="Camera"/>.
        /// </summary>
        public Camera(Vector3 position, Quaternion rotation)
        {
            Position = position;
            Rotation = rotation;
        }

        /// <summary>
        /// Instantiates a camera class that represents the main game <see cref="Camera"/>.
        /// </summary>
        public Camera(bool isMain)
        {
            IsMainCamera = isMain;
        }

        /// <summary>
        /// Sets the world cars level of detail for this <see cref="Camera"/>.
        /// </summary>
        /// <param name="carLOD"></param>
        public void SetCarLevelOfDetail(CarsLOD carLOD)
        {
            switch (carLOD)
            {
                case CarsLOD.None:
                    _interalSetCarLOD(CARLOD_DEFAULT_VALUE_1, CARLOD_DEFAULT_VALUE_2, CARLOD_DEFAULT_VALUE_3, CARLOD_DEFAULT_VALUE_4);
                    break;

                case CarsLOD.Low:
                    _interalSetCarLOD(CARLOD_LOW_VALUE_1, CARLOD_LOW_VALUE_2, CARLOD_LOW_VALUE_3, CARLOD_LOW_VALUE_4);
                    break;

                case CarsLOD.Medium:
                    _interalSetCarLOD(CARLOD_MID_VALUE_1, CARLOD_MID_VALUE_2, CARLOD_MID_VALUE_3, CARLOD_MID_VALUE_4);
                    break;

                case CarsLOD.High:
                    _interalSetCarLOD(CARLOD_HIGH_VALUE_1, CARLOD_HIGH_VALUE_2, CARLOD_HIGH_VALUE_3, CARLOD_HIGH_VALUE_4);
                    break;

                case CarsLOD.Default:
                    _interalSetCarLOD(CARLOD_DEFAULT_VALUE_1, CARLOD_DEFAULT_VALUE_2, CARLOD_DEFAULT_VALUE_3, CARLOD_DEFAULT_VALUE_4);
                    break;

                default:
                    _interalSetCarLOD(CARLOD_DEFAULT_VALUE_1, CARLOD_DEFAULT_VALUE_2, CARLOD_DEFAULT_VALUE_3, CARLOD_DEFAULT_VALUE_4);
                    break;
            }
        }

        /// <summary>
        /// Sets the world cars level of detail.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// <param name="value4"></param>
        public void SetCarLevelOfDetail(float value1, float value2, float value3, float value4)
        {
            _interalSetCarLOD(value1, value2, value3, value4);
        }

        /// <summary>
        /// An internal function for setting the world cars level of detail.
        /// </summary>
        /// <param name="_val1"></param>
        /// <param name="_val2"></param>
        /// <param name="_val3"></param>
        /// <param name="_val4"></param>
        internal void _interalSetCarLOD(float _val1, float _val2, float _val3, float _val4)
        {
            IntPtr lodVal1 = (IntPtr)memory.getBaseAddress + Addrs.CameraAddrs.NONSTATIC_CAMERA_LOD_VALUE_1;
            IntPtr lodVal2 = (IntPtr)memory.getBaseAddress + Addrs.CameraAddrs.NONSTATIC_CAMERA_LOD_VALUE_2;
            IntPtr lodVal3 = (IntPtr)memory.getBaseAddress + Addrs.CameraAddrs.NONSTATIC_CAMERA_LOD_VALUE_3;
            IntPtr lodVal4 = (IntPtr)memory.getBaseAddress + Addrs.CameraAddrs.NONSTATIC_CAMERA_LOD_VALUE_4;

            carLODValue1 = memory.ReadFloat(lodVal1);
            carLODValue2 = memory.ReadFloat(lodVal2);
            carLODValue3 = memory.ReadFloat(lodVal3);
            carLODValue4 = memory.ReadFloat(lodVal4);

            if (IsMainCamera)
            {
                memory.WriteFloat((IntPtr)memory.getBaseAddress + Addrs.CameraAddrs.NONSTATIC_CAMERA_LOD_VALUE_1, _val1);
                memory.WriteFloat((IntPtr)memory.getBaseAddress + Addrs.CameraAddrs.NONSTATIC_CAMERA_LOD_VALUE_2, _val2);
                memory.WriteFloat((IntPtr)memory.getBaseAddress + Addrs.CameraAddrs.NONSTATIC_CAMERA_LOD_VALUE_3, _val3);
                memory.WriteFloat((IntPtr)memory.getBaseAddress + Addrs.CameraAddrs.NONSTATIC_CAMERA_LOD_VALUE_4, _val4);
            }
        }
    }
}
