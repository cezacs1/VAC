using System;
using System.Runtime.InteropServices;

namespace vac_some_steamexe_structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public uint left;
        public uint top;
        public uint right;
        public uint bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct tagMONITORINFO
    {
        public int cbSize;
        public RECT rcMonitor;
        public RECT rcWork;
        public int dwFlags;
    }


    /*

00000000 tagMONITORINFO  struc ; (sizeof=0x28, align=0x4, copyof_214)
00000000                                         ; XREF: sub_46A2A0/r
00000000                                         ; sub_468D30/r
00000000 cbSize          dd ?                    ; XREF: sub_468D30+2CB/w
00000000                                         ; sub_46A2A0+35/w
00000004 rcMonitor       RECT ?                  ; XREF: sub_468D30+30E/r
00000004                                         ; sub_468D30+316/r ...
00000014 rcWork          RECT ?
00000024 dwFlags         dd ?
00000028 tagMONITORINFO  ends
00000028

     */

}
