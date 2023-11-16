using System;
using System.Runtime.InteropServices;

// found in VAC3.dll from uc:
// https://www.unknowncheats.me/forum/anti-cheat-bypass/113531-vac3-dump-5-1-14-a.html

namespace runfunc.dll_structs.structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MyGUID
    {
        public uint Data1;
        public ushort Data2;
        public ushort Data3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] Data4;
    }

    /*
        00000000 GUID            struc ; (sizeof=0x10, align=0x4, copyof_2)
        00000000                                         ; XREF: .rdata:1000728C/r
        00000000 Data1           dd ?
        00000004 Data2           dw ?
        00000006 Data3           dw ?
        00000008 Data4           db 8 dup(?)
        00000010 GUID            ends
    */
}
