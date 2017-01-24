using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.CarbonAddresses;
using Funcs = NFSScript.CarbonFunctions;
using NFSScript.Math;

namespace NFSScript.Carbon
{
    /// <summary>
    /// A debug camera class.
    /// </summary>
    public class DebugCamera
    {        
        /// <summary>
        /// CDActionDrive
        /// </summary>
        public const string CDActionDrive = "CDActionDrive";

        /// <summary>
        /// CDActionTrackCar
        /// </summary>
        public const string CDActionTrackCar = "CDActionTrackCar";

        /// <summary>
        /// CDActionDebug
        /// </summary>
        public const string CDActionDebug = "CDActionDebug";

        /* //Not for this class atm..
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
        */

        /// <summary>
        /// Gets or sets the current position of this <see cref="DebugCamera"/>. (Read only)
        /// </summary>
        public Vector3 Position
        {
            get { return _readPos(); }
            set { _setPos(value.x, value.y, value.z); }
        }

        /// <summary>
        /// Instantiates a new <see cref="DebugCamera"/>.
        /// </summary>
        public DebugCamera(Vector3 position)
        {
            Position = position;
        }

        /// <summary>
        /// Activates the debug camera.
        /// </summary>
        public void Activate()
        {
            Function.Call(Funcs.CAMERA_AI__SET_ACTION, CDActionDebug, 1);
        }

        /// <summary>
        /// Deactivates the debug camera.
        /// </summary>
        public void Deactivate()
        {
            Function.Call(Funcs.CAMERA_AI__SET_ACTION, CDActionDrive, 1);
        }

        internal Vector3 _readPos()
        {
            float x = memory.ReadFloat((IntPtr)Addrs.CameraAddrs.STATIC_DEBUG_CAMERA_POS_X);
            float y = memory.ReadFloat((IntPtr)Addrs.CameraAddrs.STATIC_DEBUG_CAMERA_POS_Y);
            float z = memory.ReadFloat((IntPtr)Addrs.CameraAddrs.STATIC_DEBUG_CAMERA_POS_Z);

            return new Vector3(x, y, z);
        }

        internal void _setPos(float x, float y, float z)
        {
            memory.WriteFloat((IntPtr)Addrs.CameraAddrs.STATIC_DEBUG_CAMERA_POS_X, x);
            memory.WriteFloat((IntPtr)Addrs.CameraAddrs.STATIC_DEBUG_CAMERA_POS_Y, y);
            memory.WriteFloat((IntPtr)Addrs.CameraAddrs.STATIC_DEBUG_CAMERA_POS_Z, z);
        }

        /* //Not for this class atm..
        /// <summary>
        /// Sets the world cars level of detail for this <see cref="DebugCamera"/>.
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
        /// 
        /// </summary>
        /// <returns></returns>
        public Vector3 _readCameraCoords()
        {
            float x = memory.ReadFloat((IntPtr)Addrs.CameraAddrs.STATIC_DEBUG_CAMERA_POS_X);
            float y = memory.ReadFloat((IntPtr)Addrs.CameraAddrs.STATIC_DEBUG_CAMERA_POS_Y);
            float z = memory.ReadFloat((IntPtr)Addrs.CameraAddrs.STATIC_DEBUG_CAMERA_POS_Z);

            return new Vector3(x, y, z);
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
        }*/
    }
}
