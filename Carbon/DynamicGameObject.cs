using System;
using NFSScript.Core;
using static NFSScript.Core.GameMemory;
using Addrs = NFSScript.Core.CarbonAddresses;
using NFSScript.Math;

namespace NFSScript.Carbon
{
    /// <summary>
    /// A class that represents a dynamic (physics) game object in the game world.
    /// </summary>
    public class DynamicGameObject : EAGLPhysicsObject
    {
        /// <summary>
        /// Returns the player's car dynamic game object.
        /// </summary>
        public static DynamicGameObject Player
        {
            get { return new DynamicGameObject(0); }
        }

        /// <summary>
        /// Dynamic game object gravity values.
        /// </summary>
        public override Vector3 GravityValues
        {
            get
            {
                int addr = (int)memory.getBaseAddress;
                int offset = 0;
                for (int i = 0; i < ID; i++)
                {
                    offset = offset + Addrs.GenericAddrs.POINTER_CAR_OFFSET;
                }
                float x = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.NONSTATIC_PLAYER_X_POS + offset + 30);
                float y = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.NONSTATIC_PLAYER_Y_POS + offset + 30);
                float z = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.NONSTATIC_PLAYER_Y_POS + offset + 30);

                return new Vector3(x, y, z);
            }
            set
            {
                int addr = (int)memory.getBaseAddress;
                int offset = 0;
                for (int i = 0; i < ID; i++)
                {
                    offset = offset + Addrs.GenericAddrs.POINTER_CAR_OFFSET;
                }
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.NONSTATIC_PLAYER_X_POS + offset + 30, value.x);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.NONSTATIC_PLAYER_Y_POS + offset + 30, value.y);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.NONSTATIC_PLAYER_Y_POS + offset + 30, value.z);
            }
        }

        /// <summary>
        /// The position of the defined dynamic object ID.
        /// </summary>
        public override Vector3 Position
        {
            get
            {
                int addr = (int)memory.getBaseAddress;
                int offset = 0;
                for (int i = 0; i < ID; i++)
                {
                    offset = offset + Addrs.GenericAddrs.POINTER_CAR_OFFSET;
                }
                float x = memory.ReadFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_X_POS + offset);
                float y = memory.ReadFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_Y_POS + offset);
                float z = memory.ReadFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_Z_POS + offset);

                return new Vector3(x, y, z);
            }
            set
            {
                int addr = (int)memory.getBaseAddress;
                int offset = 0;
                for (int i = 0; i < ID; i++)
                {
                    offset = offset + Addrs.GenericAddrs.POINTER_CAR_OFFSET;
                }
                memory.WriteFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_X_POS + offset, value.x);
                memory.WriteFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_Y_POS + offset, value.y);
                memory.WriteFloat((IntPtr)addr + Addrs.PlayerAddrs.NONSTATIC_PLAYER_Z_POS + offset, value.z);
            }
        }

        /// <summary>
        /// The rotation of the defined dynamic object ID.
        /// </summary>
        public override Quaternion Rotation
        {
            get
            {
                int offset = 0;
                for (int i = 0; i < ID; i++)
                {
                    offset = offset + Addrs.GenericAddrs.POINTER_CAR_OFFSET;
                }
                float x = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_X_ROT + offset) * 360;
                float y = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_Y_ROT + offset) * 360;
                float z = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_Z_ROT + offset) * 360;
                float w = memory.ReadFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_W_ROT + offset) * 360;

                return new Quaternion(x, y, z, w);
            }
            set
            {
                int offset = 0;
                for (int i = 0; i < ID; i++)
                {
                    offset = offset + Addrs.GenericAddrs.POINTER_CAR_OFFSET;
                }

                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_X_ROT + offset, value.x / 360);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_X_ROT + offset, value.y / 360);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_X_ROT + offset, value.z / 360);
                memory.WriteFloat((IntPtr)Addrs.PlayerAddrs.STATIC_PLAYER_X_ROT + offset, value.w / 360);
            }
        }

        /// <summary>
        /// The ID of the dynamic object that the class will effect, an ID bigger than 32 will probably crash the game.
        /// </summary>
        public override byte ID { get; set; }

        /// <summary>
        /// Instantiate a dynamic game object class by ID.
        /// </summary>
        /// <param name="ID">The ID of the car in the world, an ID bigger than 32 will probably crash the game.</param>
        public DynamicGameObject(byte ID)
        {
            this.ID = ID;
        }
    }
}
