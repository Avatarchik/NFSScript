// [----------------------------------------------------------------------------------------------------------------------------------------------]
// My heart skips a beat when I have to enter this file to edit or add code..
// So yeah welcome to the file where madness lies.
// 
// [----------------------------------------------------------------------------------------------------------------------------------------------]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

using static NFSScript.Core.NativeMethods;

namespace NFSScript.Core
{
    /// <summary>
    /// For 'building' ASM code.
    /// </summary>
    public class ASMBuilder // This class is pretty basic at the moment, and I will probably add more functions such as JE or SUB, etc... it gets the job done 99% of the time.
    {
        List<byte> b;

        /// <summary>
        /// Initializes a new instance of ASMBuilder.
        /// </summary>
        public ASMBuilder()
        {
            b = new List<byte>();
        }

        /// <summary>
        /// Adds shellcode.
        /// </summary>
        /// <param name="bytes"></param>
        public void AddShellcode(byte[] bytes)
        {
            b.AddRange(bytes);
        }

        /// <summary>
        /// Call the EAX registry.
        /// </summary>
        public void CallEAX()
        {
            b.AddRange(new byte[] { 0xFF, 0xD0 });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void PushWORDPTRDS(int value)
        {
            b.AddRange(new byte[] { 0xff, 0x35 });
            b.AddRange(BitConverter.GetBytes(value));
        }

        /// <summary>
        /// Push ESI to the stack.
        /// </summary>
        public void PushESI()
        {
            b.Add(0x56);
        }

        /// <summary>
        /// Push EDI to the stack.
        /// </summary>
        public void PushEDI()
        {
            b.Add(0x57);
        }

        /// <summary>
        /// Push EDX to the stack.
        /// </summary>
        public void PushEDX()
        {
            b.Add(0x52);
        }

        /// <summary>
        /// Add to ESP.
        /// </summary>
        /// <param name="value"></param>
        public void AddToESP(int value)
        {
            b.AddRange(new byte[] { 0x83, 0xc4 });
            b.AddRange(BitConverter.GetBytes(value));
        }

        /// <summary>
        /// Push a value to the stack.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Push(int value)
        {
            if (value >= 0 && value <= 127)
            {
                b.Add(0x6A);
                b.Add((byte)value);
            }
            else
            {
                byte[] bytes = BitConverter.GetBytes(value);
                b.Add(0x68);
                b.AddRange(bytes);
            }
        }

        /// <summary>
        /// Push a floating point value to the stack.
        /// </summary>
        /// <param name="value"></param>
        public void Push(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            b.Add(0x68);
            b.AddRange(bytes);
        }

        /// <summary>
        /// Push a value to the stack.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Push(uint value)
        {
            if (value >= 0 && value <= 127)
            {
                b.Add(0x6A);
                b.Add((byte)value);
            }
            else
            {
                b.Add(0x68);
                b.AddRange(BitConverter.GetBytes(value));
            }
        }


        /// <summary>
        /// Pop EAX from the stack.
        /// </summary>
        /// <returns></returns>
        public void PopEAX()
        {
            b.Add(0x58);
        }

        /// <summary>
        /// Pop EDI from the stack.
        /// </summary>
        public void PopEDI()
        {
            b.Add(0x5F);
        }

        /// <summary>
        /// Pop ESI from the stack.
        /// </summary>
        public void PopESI()
        {
            b.Add(0x5E);
        }

        /// <summary>
        /// Pop EDX from the stack.
        /// </summary>
        public void PopEDX()
        {
            b.Add(0x5A);
        }

        /// <summary>
        /// JMP command.
        /// </summary>
        /// <param name="value"></param>
        public void Jmp(int value)
        {
            b.Add(0xE9);
            b.AddRange(BitConverter.GetBytes(value));
        }

        /// <summary>
        /// Move a value to the EAX registry
        /// </summary>
        /// <param name="value"></param>
        public void MovEAX(int value)
        {
            b.Add(0xb8);
            b.AddRange(BitConverter.GetBytes(value));
        }

        /// <summary>
        /// Calls ret.
        /// </summary>
        /// <returns></returns>
        public void Return()
        {
            b.Add(0xC3);
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] ToArray()
        {
            return b.ToArray();
        }
    }

    /// <summary>
    /// Class for 'assembly' related stuff.
    /// </summary>
    public static class ASM
    {
        /// <summary>
        /// 
        /// </summary>
        public const int MAKE_NOP = 0x90;

        /// <summary>
        /// 
        /// </summary>
        public const int MAKE_JMP = 0xE9;

        /// <summary>
        /// Writes a NOP instruction at a specified address.
        /// </summary>
        /// <param name="address"></param>
        public static void MakeNopAt(int address)
        {
            GameMemory.memory.WriteByte((IntPtr)address, 0x90);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <param name="toAddress"></param>
        public static void MakeJMPAt(int address, int toAddress)
        {
            List<byte> b = new List<byte>();
            b.Add(0xE9);
            b.AddRange(BitConverter.GetBytes(toAddress));
            GameMemory.memory.WriteByteArray((IntPtr)address, b.ToArray());
        }

        /// <summary>
        /// Writes NOP instructions at a specified address
        /// </summary>
        /// <param name="address"></param>
        /// <param name="count"></param>
        public static void MakeNopAt(int address, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int addr = address + 0x02;
                GameMemory.memory.WriteByte((IntPtr)addr, 0x90);
            }
        }

        /// <summary>
        /// Completely empty the address at the defined length with 0x00's.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="length"></param>
        public static void Abolish(IntPtr address, int length)
        {
            byte[] arr = new byte[length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }

            GameMemory.memory.WriteByteArray(address, arr);
        }

        /// <summary>
        /// Execute ASM code using hex arrays.
        /// </summary>
        /// <param name="asm"></param>
        /// <returns></returns>
        public static ASMResult CallAssembly(byte[] asm)
        {
            return _ASM.Call(asm, GameMemory.memory.ProcessHandle);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="asm"></param>
        /// <returns></returns>
        public static IntPtr CallAssemblyForAddress(byte[] asm)
        {
            return _ASM.CallForAddress(asm, GameMemory.memory.ProcessHandle);
        }
    }

    /// <summary>
    /// Where madness occurs...
    /// </summary>
    internal static class _ASM
    {
        static Dictionary<IntPtr, byte[]> memoryPointersCache = new Dictionary<IntPtr, byte[]>();


        public const string ASM_ERROR = "ASMERROR";
        /// <summary>
        /// Inject shellcode and get the address where the shellcode was injected. (Doesn't save to memory's cache!!)
        /// </summary>
        /// <param name="asm"></param>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static IntPtr CallForAddress(byte[] asm, IntPtr handle)
        {
            IntPtr hAlloc = VirtualAllocEx(handle, IntPtr.Zero, (uint)asm.Length, AllocationType.Commit, MemoryProtection.ExecuteReadWrite);

            if (hAlloc == IntPtr.Zero)
            {
                Log.Print(ASM_ERROR, string.Format("Failed to allocate memory! {0}", Marshal.GetLastWin32Error()));
                return IntPtr.Zero;
            }

            UIntPtr bytesWritten = UIntPtr.Zero;

            if (!WriteProcessMemory(handle, hAlloc, asm, (uint)asm.Length, out bytesWritten))
            {
                Log.Print(ASM_ERROR, string.Format("Could not write process memory! {0}", Marshal.GetLastWin32Error()));
                return IntPtr.Zero;
            }

            if (asm.Length != (int)bytesWritten)
            {
                Log.Print(ASM_ERROR, "ASM length is not equal to the amount of bytes written.");
                return IntPtr.Zero;
            }

            uint iThreadId = 0;
            IntPtr hThread = CreateRemoteThread(handle, IntPtr.Zero, 0, hAlloc, IntPtr.Zero, 0, out iThreadId);

            if (hThread == IntPtr.Zero)
            {
                Log.Print(ASM_ERROR, "The handle thread value is IntPtr.Zero! This is invalid.");
                return IntPtr.Zero;
            }

            if (!CloseHandle(hThread))
                Log.Print(ASM_ERROR, string.Format("Could not close handle! {0}", Marshal.GetLastWin32Error()));

            return hAlloc;
        }

        /// <summary>
        /// Inject shellcode and get result.
        /// </summary>
        /// <param name="asm"></param>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static ASMResult Call(byte[] asm, IntPtr handle)
        {
            ASMResult result = ASMResult.Success;

            IntPtr addr = IntPtr.Zero;

            if (memoryPointersCache.ContainsValue(asm))
            {
                addr = memoryPointersCache.FirstOrDefault(x => x.Value == asm).Key;
            }
            else
            {
                addr = VirtualAllocEx(handle, IntPtr.Zero, (uint)asm.Length, AllocationType.Commit, MemoryProtection.ExecuteReadWrite);

                if (addr == IntPtr.Zero)
                {
                    Log.Print(ASM_ERROR, string.Format("Failed to allocate memory! {0}", Marshal.GetLastWin32Error()));
                    result = ASMResult.AllocationFaliure;
                }

                UIntPtr bytesWritten = UIntPtr.Zero;

                if (!WriteProcessMemory(handle, addr, asm, (uint)asm.Length, out bytesWritten))
                {
                    Log.Print(ASM_ERROR, string.Format("Could not close write process memory! {0}", Marshal.GetLastWin32Error()));
                    result = ASMResult.WritingFailed;
                }
                else memoryPointersCache.Add(addr, asm);

                if (asm.Length != (int)bytesWritten)
                {
                    Log.Print(ASM_ERROR, "ASM length is not equal to the amount of bytes written.");
                    result = ASMResult.InvalidSize;
                }
            }

            uint iThreadId = 0;

            IntPtr hThread = CreateRemoteThread(handle, IntPtr.Zero, 0, addr, IntPtr.Zero, 0, out iThreadId);

            if (hThread == IntPtr.Zero)
            {
                Log.Print(ASM_ERROR, "The handle thread value is IntPtr.Zero! This is invalid.");
                result = ASMResult.RemoteThreadFailure;
            }

            if (!CloseHandle(hThread))
                Log.Print(ASM_ERROR, string.Format("Could not close handle! {0}", Marshal.GetLastWin32Error()));

            

            return result;
        }
    }

    #region Enums

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum ProcessAccessFlags : uint
    {
        /// <summary>
        /// 
        /// </summary>
        Terminate = 0x00000001,
        /// <summary>
        /// 
        /// </summary>
        CreateThread = 0x00000002,
        /// <summary>
        /// 
        /// </summary>
        VMOperation = 0x00000008,
        /// <summary>
        /// 
        /// </summary>
        VMRead = 0x00000010,
        /// <summary>
        /// 
        /// </summary>
        VMWrite = 0x00000020,
        /// <summary>
        /// 
        /// </summary>
        DupHandle = 0x00000040,
        /// <summary>
        /// 
        /// </summary>
        SetInformation = 0x00000200,
        /// <summary>
        /// 
        /// </summary>
        QueryInformation = 0x00000400,
        /// <summary>
        /// 
        /// </summary>
        Synchronize = 0x00100000,
        /// <summary>
        /// 
        /// </summary>
        All = 0x001F0FFF
    }

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum AllocationType
    {
        /// <summary>
        /// 
        /// </summary>
        Commit = 0x00001000,
        /// <summary>
        /// 
        /// </summary>
        Reserve = 0x00002000,
        /// <summary>
        /// 
        /// </summary>
        Decommit = 0x00004000,
        /// <summary>
        /// 
        /// </summary>
        Release = 0x00008000,
        /// <summary>
        /// 
        /// </summary>
        Reset = 0x00080000,
        /// <summary>
        /// 
        /// </summary>
        TopDown = 0x00100000,
        /// <summary>
        /// 
        /// </summary>
        WriteWatch = 0x00200000,
        /// <summary>
        /// 
        /// </summary>
        Physical = 0x00400000,
        /// <summary>
        /// 
        /// </summary>
        LargePages = 0x20000000
    }

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum MemoryProtection
    {
        /// <summary>
        /// 
        /// </summary>
        NoAccess = 0x0001,
        /// <summary>
        /// 
        /// </summary>
        ReadOnly = 0x0002,
        /// <summary>
        /// 
        /// </summary>
        ReadWrite = 0x0004,
        /// <summary>
        /// 
        /// </summary>
        WriteCopy = 0x0008,
        /// <summary>
        /// 
        /// </summary>
        Execute = 0x0010,
        /// <summary>
        /// 
        /// </summary>
        ExecuteRead = 0x0020,
        /// <summary>
        /// 
        /// </summary>
        ExecuteReadWrite = 0x0040,
        /// <summary>
        /// 
        /// </summary>
        ExecuteWriteCopy = 0x0080,
        /// <summary>
        /// 
        /// </summary>
        GuardModifierflag = 0x0100,
        /// <summary>
        /// 
        /// </summary>
        NoCacheModifierflag = 0x0200,
        /// <summary>
        /// 
        /// </summary>
        WriteCombineModifierflag = 0x0400
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum CONTEXT_FLAGS : uint
    {
        /// <summary>
        /// 
        /// </summary>
        CONTEXT_i386 = 0x10000,
        /// <summary>
        /// 
        /// </summary>
        CONTEXT_i486 = 0x10000,
        /// <summary>
        /// 
        /// </summary>
        CONTEXT_CONTROL = CONTEXT_i386 | 0x01,
        /// <summary>
        /// 
        /// </summary>
        CONTEXT_INTEGER = CONTEXT_i386 | 0x02,
        /// <summary>
        /// 
        /// </summary>
        CONTEXT_SEGMENTS = CONTEXT_i386 | 0x04,
        /// <summary>
        /// 
        /// </summary>
        CONTEXT_FLOATING_POINT = CONTEXT_i386 | 0x08,
        /// <summary>
        /// 
        /// </summary>
        CONTEXT_DEBUG_REGISTERS = CONTEXT_i386 | 0x10,
        /// <summary>
        /// 
        /// </summary>
        CONTEXT_EXTENDED_REGISTERS = CONTEXT_i386 | 0x20,
        /// <summary>
        /// 
        /// </summary>
        CONTEXT_FULL = CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_SEGMENTS,
        /// <summary>
        /// 
        /// </summary>
        CONTEXT_ALL = CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_SEGMENTS | CONTEXT_FLOATING_POINT | CONTEXT_DEBUG_REGISTERS | CONTEXT_EXTENDED_REGISTERS
    }

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CONTEXT
    {
        /// <summary>
        /// 
        /// </summary>
        public uint ContextFlags;
        /// <summary>
        /// 
        /// </summary>
        public uint Dr0;
        /// <summary>
        /// 
        /// </summary>
        public uint Dr1;
        /// <summary>
        /// 
        /// </summary>
        public uint Dr2;
        /// <summary>
        /// 
        /// </summary>
        public uint Dr3;
        /// <summary>
        /// 
        /// </summary>
        public uint Dr6;
        /// <summary>
        /// 
        /// </summary>
        public uint Dr7;
        /// <summary>
        /// 
        /// </summary>
        public uint FloatSave;
        /// <summary>
        /// 
        /// </summary>
        public uint SegGs;
        /// <summary>
        /// 
        /// </summary>
        public uint SegFs;
        /// <summary>
        /// 
        /// </summary>
        public uint SegEs;
        /// <summary>
        /// 
        /// </summary>
        public uint SegDs;
        /// <summary>
        /// 
        /// </summary>
        public uint Edi;
        /// <summary>
        /// 
        /// </summary>
        public uint Esi;
        /// <summary>
        /// 
        /// </summary>
        public uint Ebx;
        /// <summary>
        /// 
        /// </summary>
        public uint Edx;
        /// <summary>
        /// 
        /// </summary>
        public uint Ecx;
        /// <summary>
        /// 
        /// </summary>
        public uint Eax;
        /// <summary>
        /// 
        /// </summary>
        public uint Ebp;
        /// <summary>
        /// 
        /// </summary>
        public uint Eip;
        /// <summary>
        /// 
        /// </summary>
        public uint SegCs;
        /// <summary>
        /// 
        /// </summary>
        public uint EFlags;
        /// <summary>
        /// 
        /// </summary>
        public uint Esp;
        /// <summary>
        /// 
        /// </summary>
        public uint SegSs;
        /// <summary>
        /// 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] ExtendedRegisters;
    }

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum ThreadAccessFlags : int
    {
        /// <summary>
        /// 
        /// </summary>
        TERMINATE = 0x0001,
        /// <summary>
        /// 
        /// </summary>
        SUSPEND_RESUME = 0x0002,
        /// <summary>
        /// 
        /// </summary>
        GET_CONTEXT = 0x0008,
        /// <summary>
        /// 
        /// </summary>
        SET_CONTEXT = 0x0010,
        /// <summary>
        /// 
        /// </summary>
        SET_INFORMATION = 0x0020,
        /// <summary>
        /// 
        /// </summary>
        QUERY_INFORMATION = 0x0040,
        /// <summary>
        /// 
        /// </summary>
        SET_THREAD_TOKEN = 0x0080,
        /// <summary>
        /// 
        /// </summary>
        IMPERSONATE = 0x0100,
        /// <summary>
        /// 
        /// </summary>
        DIRECT_IMPERSONATION = 0x0200
    }

    /// <summary>
    /// Returns the ASMResult.
    /// </summary>
    public enum ASMResult : byte
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0,
        /// <summary>
        /// 
        /// </summary>
        Success = 1,
        /// <summary>
        /// 
        /// </summary>
        WritingFailed = 2,
        /// <summary>
        /// 
        /// </summary>
        InvalidSize = 3,
        /// <summary>
        /// 
        /// </summary>
        RemoteThreadFailure = 4,
        /// <summary>
        /// 
        /// </summary>
        AllocationFaliure = 5,
        /// <summary>
        /// 
        /// </summary>
        Unknown = 6
    }

    #endregion
}
