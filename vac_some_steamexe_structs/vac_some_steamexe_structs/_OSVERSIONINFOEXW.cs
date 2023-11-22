using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vac_some_steamdll_structs
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct OSVERSIONINFOEXW
    {
        public uint dwOSVersionInfoSize;
        public uint dwMajorVersion;
        public uint dwMinorVersion;
        public uint dwBuildNumber;
        public uint dwPlatformId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szCSDVersion;

        public ushort wServicePackMajor;
        public ushort wServicePackMinor;
        public ushort wSuiteMask;
        public byte wProductType;
        public byte wReserved;
    }


    /*
    
00000000 _OSVERSIONINFOEXW struc ; (sizeof=0x11C, align=0x4, copyof_43)
00000000                                         ; XREF: sub_4DEDB0/r
00000000                                         ; sub_549710/r ...
00000000 dwOSVersionInfoSize dd ?                ; XREF: sub_4DEDB0+28/w
00000000                                         ; sub_5431D0+8B/w ...
00000004 dwMajorVersion  dd ?                    ; XREF: sub_4DEDB0+7E/w
00000004                                         ; sub_5431D0+98/w ...
00000008 dwMinorVersion  dd ?                    ; XREF: sub_4DEDB0+8A/w
00000008                                         ; sub_5431D0+A2/w ...
0000000C dwBuildNumber   dd ?                    ; XREF: sub_4DEDB0+32/w
0000000C                                         ; sub_5431D0+AC/w ...
00000010 dwPlatformId    dd ?                    ; XREF: sub_4DEDB0+3C/w
00000010                                         ; sub_5431D0+85/o ...
00000014 szCSDVersion    dw 128 dup(?)           ; XREF: sub_4DEDB0+D/o
00000014                                         ; sub_549710+E/o
00000114 wServicePackMajor dw ?                  ; XREF: sub_4DEDB0+91/w
00000114                                         ; sub_5431D0+C6/w ...
00000116 wServicePackMinor dw ?                  ; XREF: sub_4DEDB0+56/w
00000116                                         ; sub_5431D0+CA/w ...
00000118 wSuiteMask      dw ?                    ; XREF: sub_4DEDB0+5A/w
00000118                                         ; sub_549710+51/w
0000011A wProductType    db ?                    ; XREF: sub_5431D0+DB/w
0000011A                                         ; sub_5497A0+65/w
0000011B wReserved       db ?
0000011C _OSVERSIONINFOEXW ends
0000011C

     */
}
