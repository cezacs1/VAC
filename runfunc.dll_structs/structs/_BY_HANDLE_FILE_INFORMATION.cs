using System;
using System.Runtime.InteropServices;

// found in VAC3.dll from uc:
// https://www.unknowncheats.me/forum/anti-cheat-bypass/113531-vac3-dump-5-1-14-a.html

namespace runfunc.dll_structs.structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _BY_HANDLE_FILE_INFORMATION
    {
        public uint dwFileAttributes;
        public FILETIME ftCreationTime;
        public FILETIME ftLastAccessTime;
        public FILETIME ftLastWriteTime;
        public uint dwVolumeSerialNumber;
        public uint nFileSizeHigh;
        public uint nFileSizeLow;
        public uint nNumberOfLinks;
        public uint nFileIndexHigh;
        public uint nFileIndexLow;
    }

    /*
        00000000 _BY_HANDLE_FILE_INFORMATION struc ; (sizeof=0x34, align=0x4, copyof_3)
        00000000                                         ; XREF: sub_10001D6A/r
        00000000 dwFileAttributes dd ?
        00000004 ftCreationTime  FILETIME ?
        0000000C ftLastAccessTime FILETIME ?
        00000014 ftLastWriteTime FILETIME ?
        0000001C dwVolumeSerialNumber dd ?
        00000020 nFileSizeHigh   dd ?
        00000024 nFileSizeLow    dd ?
        00000028 nNumberOfLinks  dd ?
        0000002C nFileIndexHigh  dd ?                    ; XREF: sub_10001D6A+12B/r
        00000030 nFileIndexLow   dd ?                    ; XREF: sub_10001D6A+131/r
        00000034 _BY_HANDLE_FILE_INFORMATION ends
        00000034
    */
}
