// [----------------------------------------------------------------------------------------------------------------------------------------------]
// Thank you Vivid Abstractions for this wonderful class!
// I'll probably replace this class with my own memory editor class when I have enough time.
// [----------------------------------------------------------------------------------------------------------------------------------------------]
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using NFSScript;

namespace NFSScript.Core
{
    /// <summary>
    /// Where the magic happens.
    /// </summary>
    public class VAMemory
    {
        /// <summary>
        /// 
        /// </summary>
        public static bool debugMode;
        private IntPtr baseAddress;
        private ProcessModule processModule;
        private Process[] mainProcess;
        private IntPtr processHandle;

        /// <summary>
        /// 
        /// </summary>
        public string processName { get; set; }

        /// <summary>
        /// Get the process handle.
        /// </summary>
        public IntPtr ProcessHandle { get { return processHandle; } }

        /// <summary>
        /// 
        /// </summary>
        public long getBaseAddress
        {
            get
            {
                this.baseAddress = (IntPtr)0;
                this.processModule = this.mainProcess[0].MainModule;
                this.baseAddress = this.processModule.BaseAddress;
                return (long)this.baseAddress;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public VAMemory()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public VAMemory(string pProcessName)
        {
            this.processName = pProcessName;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint dwSize, uint lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, uint lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        private static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        /// <summary>
        /// 
        /// </summary>
        public bool CheckProcess()
        {
            if (this.processName != null)
            {
                this.mainProcess = Process.GetProcessesByName(this.processName);
                if (this.mainProcess.Length == 0)
                {
                    this.ErrorProcessNotFound(this.processName);
                    return false;
                }
                this.processHandle = VAMemory.OpenProcess(2035711U, false, this.mainProcess[0].Id);
                if (!(this.processHandle == IntPtr.Zero))
                    return true;
                this.ErrorProcessNotFound(this.processName);
                return false;
            }
            int num = (int)MessageBox.Show("Programmer, define process name first!");
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] ReadByteArray(IntPtr pOffset, uint pSize)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                uint lpflOldProtect;
                VAMemory.VirtualProtectEx(this.processHandle, pOffset, (UIntPtr)pSize, 4U, out lpflOldProtect);
                byte[] lpBuffer = new byte[(int)pSize];
                VAMemory.ReadProcessMemory(this.processHandle, pOffset, lpBuffer, pSize, 0U);
                VAMemory.VirtualProtectEx(this.processHandle, pOffset, (UIntPtr)pSize, lpflOldProtect, out lpflOldProtect);
                return lpBuffer;
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadByteArray" + ex.ToString());
                return new byte[1];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ReadStringUnicode(IntPtr pOffset, uint pSize)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return Encoding.Unicode.GetString(this.ReadByteArray(pOffset, pSize), 0, (int)pSize);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadStringUnicode" + ex.ToString());
                return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ReadStringASCII(IntPtr pOffset, uint pSize)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return Encoding.ASCII.GetString(this.ReadByteArray(pOffset, pSize), 0, (int)pSize);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadStringASCII" + ex.ToString());
                return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public char ReadChar(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToChar(this.ReadByteArray(pOffset, 1U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadChar" + ex.ToString());
                return ' ';
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool ReadBoolean(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToBoolean(this.ReadByteArray(pOffset, 1U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadByte" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public byte ReadByte(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.ReadByteArray(pOffset, 1U)[0];
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadByte" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public short ReadInt16(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToInt16(this.ReadByteArray(pOffset, 2U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadInt16" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public short ReadShort(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToInt16(this.ReadByteArray(pOffset, 2U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadInt16" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ReadInt32(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToInt32(this.ReadByteArray(pOffset, 4U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadInt32" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ReadInteger(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToInt32(this.ReadByteArray(pOffset, 4U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadInteger" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long ReadInt64(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToInt64(this.ReadByteArray(pOffset, 8U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadInt64" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long ReadLong(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToInt64(this.ReadByteArray(pOffset, 8U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadLong" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ushort ReadUInt16(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToUInt16(this.ReadByteArray(pOffset, 2U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadUInt16" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ushort ReadUShort(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToUInt16(this.ReadByteArray(pOffset, 2U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadUShort" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public uint ReadUInt32(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToUInt32(this.ReadByteArray(pOffset, 4U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadUInt32" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public uint ReadUInteger(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToUInt32(this.ReadByteArray(pOffset, 4U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadUInteger" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ulong ReadUInt64(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToUInt64(this.ReadByteArray(pOffset, 8U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadUInt64" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long ReadULong(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return (long)BitConverter.ToUInt64(this.ReadByteArray(pOffset, 8U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadULong" + ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public float ReadFloat(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToSingle(this.ReadByteArray(pOffset, 4U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadFloat" + ex.ToString());
                return 0.0f;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double ReadDouble(IntPtr pOffset)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return BitConverter.ToDouble(this.ReadByteArray(pOffset, 8U), 0);
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: ReadDouble" + ex.ToString());
                return 0.0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteByteArray(IntPtr pOffset, byte[] pBytes)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                uint lpflOldProtect;
                VAMemory.VirtualProtectEx(this.processHandle, pOffset, (UIntPtr)((ulong)pBytes.Length), 4U, out lpflOldProtect);
                bool flag = VAMemory.WriteProcessMemory(this.processHandle, pOffset, pBytes, (uint)pBytes.Length, 0U);
                VAMemory.VirtualProtectEx(this.processHandle, pOffset, (UIntPtr)((ulong)pBytes.Length), lpflOldProtect, out lpflOldProtect);
                return flag;
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteByteArray" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteStringUnicode(IntPtr pOffset, string pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, Encoding.Unicode.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteStringUnicode" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteStringASCII(IntPtr pOffset, string pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, Encoding.ASCII.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteStringASCII" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteBoolean(IntPtr pOffset, bool pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteBoolean" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteChar(IntPtr pOffset, char pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteChar" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteByte(IntPtr pOffset, byte pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteByte" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteInt16(IntPtr pOffset, short pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteInt16" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteShort(IntPtr pOffset, short pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteShort" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteInt32(IntPtr pOffset, int pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteInt32" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteInteger(IntPtr pOffset, int pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteInt" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteInt64(IntPtr pOffset, long pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteInt64" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteLong(IntPtr pOffset, long pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteLong" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteUInt16(IntPtr pOffset, ushort pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteUInt16" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteUShort(IntPtr pOffset, ushort pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteShort" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteUInt32(IntPtr pOffset, uint pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteUInt32" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteUInteger(IntPtr pOffset, uint pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteUInt" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteUInt64(IntPtr pOffset, ulong pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteUInt64" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteULong(IntPtr pOffset, ulong pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteULong" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteFloat(IntPtr pOffset, float pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteFloat" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool WriteDouble(IntPtr pOffset, double pData)
        {
            if (this.processHandle == IntPtr.Zero)
                this.CheckProcess();
            try
            {
                return this.WriteByteArray(pOffset, BitConverter.GetBytes(pData));
            }
            catch (Exception ex)
            {
                if (VAMemory.debugMode)
                    Console.WriteLine("Error: WriteDouble" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Process GetMainProcess()
        {
            return this.mainProcess[0];
        }

        private void ErrorProcessNotFound(string pProcessName)
        {
            Log.Print("ERROR", string.Format("{0} {1}", processName, "is not running or has not been found. Try to open the loader as an administrator."));
            Environment.Exit(0);
        }

        [Flags]
        private enum ProcessAccessFlags : uint
        {
            All = 2035711,
            Terminate = 1,
            CreateThread = 2,
            VMOperation = 8,
            VMRead = 16,
            VMWrite = 32,
            DupHandle = 64,
            SetInformation = 512,
            QueryInformation = 1024,
            Synchronize = 1048576,
        }

        private enum VirtualMemoryProtection : uint
        {
            PAGE_NOACCESS = 1,
            PAGE_READONLY = 2,
            PAGE_READWRITE = 4,
            PAGE_WRITECOPY = 8,
            PAGE_EXECUTE = 16,
            PAGE_EXECUTE_READ = 32,
            PAGE_EXECUTE_READWRITE = 64,
            PAGE_EXECUTE_WRITECOPY = 128,
            PAGE_GUARD = 256,
            PAGE_NOCACHE = 512,
            PROCESS_ALL_ACCESS = 2035711,
        }
    }
}
