using System;
using System.Runtime.InteropServices;

namespace vac_some_steamdll_structs
{
    //[DllImport("kernel32.dll")]
    //public static extern void GetSystemInfo(out _SYSTEM_INFO lpSystemInfo);

    [StructLayout(LayoutKind.Sequential)]
    public struct _SYSTEM_INFO
    {
        public IntPtr anonymous_0; // _SYSTEM_INFO::$A707B71C060B6D10F73A71917EA8473F
        public uint dwPageSize;
        public IntPtr lpMinimumApplicationAddress;
        public IntPtr lpMaximumApplicationAddress;
        public IntPtr dwActiveProcessorMask;
        public uint dwNumberOfProcessors;
        public uint dwProcessorType;
        public uint dwAllocationGranularity;
        public ushort wProcessorLevel;
        public ushort wProcessorRevision;
    }

    /*

00000000 _SYSTEM_INFO    struc ; (sizeof=0x24, align=0x4, copyof_82)
00000000                                         ; XREF: sub_53E140/r
00000000                                         ; sub_5425F0/r ...
00000000 anonymous_0     _SYSTEM_INFO::$A707B71C060B6D10F73A71917EA8473F ?
00000000                                         ; XREF: sub_53E140+EA/w
00000004 dwPageSize      dd ?                    ; XREF: sub_53E140+F0/w
00000008 lpMinimumApplicationAddress dd ?        ; XREF: sub_53E140+F6/w ; offset
0000000C lpMaximumApplicationAddress dd ?        ; XREF: sub_53E140+FC/w ; offset
00000010 dwActiveProcessorMask dd ?              ; XREF: sub_53E140+102/w
00000014 dwNumberOfProcessors dd ?               ; XREF: sub_53E140+108/w
00000014                                         ; sub_53E140+133/r ...
00000018 dwProcessorType dd ?                    ; XREF: sub_53E140+10E/w
0000001C dwAllocationGranularity dd ?            ; XREF: sub_53E140+114/w
00000020 wProcessorLevel dw ?                    ; XREF: sub_53E140+11A/w
00000022 wProcessorRevision dw ?
00000024 _SYSTEM_INFO    ends
00000024

     */
}
