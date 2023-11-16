using System;
using System.Runtime.InteropServices;

// found in VAC3.dll from uc:
// https://www.unknowncheats.me/forum/anti-cheat-bypass/113531-vac3-dump-5-1-14-a.html

namespace runfunc.dll_structs.structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FILETIME
    {
        public uint DateTimeLow;
        public uint DateTimeHigh;
    }

    /*
        00000000 FILETIME        struc ; (sizeof=0x8, align=0x4, copyof_5)
        00000000                                         ; XREF: _BY_HANDLE_FILE_INFORMATION/r
        00000000                                         ; _BY_HANDLE_FILE_INFORMATION/r ...
        00000000 dwLowDateTime   dd ?
        00000004 dwHighDateTime  dd ?
        00000008 FILETIME        ends
        00000008
    */
}
