using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace NFSScript.Core
{
    /// <summary>
    /// Exposes functions that scans patterns.
    /// </summary>
    public static class PatternScan
    {
        #region API Definitions
        [DllImport("kernel32.dll")]
        private static extern Boolean ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, Byte[] buffer, UInt32 size, Int32 lpNumberOfBytesRead);
        [DllImport("kernel32.dll")]
        private static extern Int32 VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, Int32 dwLength);

        private const Int32 MEM_COMMIT = 0x1000;
        private const Int32 PAGE_GUARD = 0x100;
        [StructLayout(LayoutKind.Sequential)]
        private struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public UInt32 AllocationProtect;
            public UInt32 RegionSize;
            public UInt32 State;
            public UInt32 Protect;
            public UInt32 Type;
        }
        #endregion

        private static IntPtr match(Byte[] mem, Byte[] pattern)
        {
            // Setup filler array
            List<Int32> bytes = new List<Int32>(255).Select(i => { i = pattern.Length; return i; }).ToList();
            for (Int32 i = 0; i < pattern.Length - 1; i++)
                bytes[pattern[i]] = (pattern.Length - 1) - i;

            Int32 ptr = 0;
            do
            {
                // Check if scan has reached the pattern fully, in little-endian order
                for (Int32 i = (pattern.Length - 1); i > 0; i--)
                {
                    if (mem[ptr + i] != pattern[i])
                        break; // Doesn't match fully, break
                    if (i == 0)
                        return new IntPtr(ptr); // Matched fully, return
                }
                ptr += bytes[mem[ptr + (pattern.Length - 1)]];
            } while (ptr <= (mem.Length - pattern.Length));
            return IntPtr.Zero;
        }

        /// <summary>
        /// Utilizes WIN32 RPM and VQEx to find given pattern in the given process context.
        /// </summary>
        /// <example>
        /// A sample usage of the <see cref="matchPattern(string, byte[])"/> method:
        /// <code>
        /// using static NFSScript.Core.PatternScan;
        /// 
        /// class MyClass
        /// {
        ///     static int Main()
        ///     {
        ///         IntPtr addr1 = matchPattern("nfsw.exe", new Byte[] { 0x55, 0xF0, 0x0, 0xAB });
        ///         IntPtr addr2 = matchPattern("gameplay.dll", new Byte[] { 0x78, 0xA, 0xBC, 0xEB });
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <remarks>Doesn't support 'ghost' patterns, a.k.a. unknown byte patterns; e.g., xx??x.</remarks>
        /// <param name="processName">The process context, has to be idenntifiable in WIN32 memory; e.g., myExe.exe, myLib.dll.</param>
        /// <param name="pattern">Byte array that containts the pattern in big-endian order (MSB->LSB).</param>
        /// <returns>The dynamic memory address if found, else IntPtr.Zero.</returns>
        public static IntPtr matchPattern(String processName, Byte[] pattern)
        {
            // Consistency
            Process[] context = Process.GetProcessesByName(processName);
            if (context.Length < 1)
                return IntPtr.Zero;

            // Init
            IntPtr handle = context[0].Handle;
            List<MEMORY_BASIC_INFORMATION> memoryRegistry = new List<MEMORY_BASIC_INFORMATION>();

            // Fill in registry
            IntPtr iAddress = new IntPtr();
            Int32 memoryDump;
            do
            {
                MEMORY_BASIC_INFORMATION memoryInfo = new MEMORY_BASIC_INFORMATION();
                memoryDump = VirtualQueryEx(handle, iAddress, out memoryInfo, Marshal.SizeOf(memoryInfo));
                if ((memoryInfo.State & MEM_COMMIT) != 0 && (memoryInfo.Protect & PAGE_GUARD) == 0)
                    memoryRegistry.Add(memoryInfo);

                iAddress = new IntPtr(memoryInfo.BaseAddress.ToInt32() + (Int32)memoryInfo.RegionSize);
            } while (memoryDump > 0);

            // Scan
            foreach (MEMORY_BASIC_INFORMATION cur in memoryRegistry)
            {
                Byte[] buffer = new Byte[cur.RegionSize];
                ReadProcessMemory(handle, cur.BaseAddress, buffer, cur.RegionSize, 0);

                IntPtr Result = match(buffer, pattern);
                if (Result != IntPtr.Zero)
                    return new IntPtr(cur.BaseAddress.ToInt32() + Result.ToInt32());
            }
            return IntPtr.Zero;
        }
    }
}
