using System;
using System.Runtime.InteropServices;

namespace vac_some_steamdll_structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct sockaddr
    {
        public ushort sa_family;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public byte[] sa_data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ADDRINFOA
    {
        public IntPtr ai_flags;
        public IntPtr ai_family;
        public IntPtr ai_socktype;
        public IntPtr ai_protocol;
        public IntPtr ai_addrlen;
        public IntPtr ai_canonname;
        public IntPtr ai_addr;
        public IntPtr ai_next;
    }

    /*

00000000 sockaddr        struc ; (sizeof=0x10, align=0x2, copyof_36)
00000000                                         ; XREF: sub_4ACCF0/r
00000000                                         ; sub_4AD4F0/r ...
00000000 sa_family       dw ?
00000002 sa_data         db 14 dup(?)
00000010 sockaddr        ends
00000010

     */

    /*

00000000 ADDRINFOA       struc ; (sizeof=0x20, align=0x4, copyof_40)
00000000                                         ; XREF: sub_4C04F0/r
00000000 ai_flags        dd ?                    ; XREF: sub_4C04F0+5C/w
00000000                                         ; sub_4C04F0+9F/w ...
00000004 ai_family       dd ?                    ; XREF: sub_4C04F0+5F/w
00000004                                         ; sub_4C04F0:loc_4C0576/w ...
00000008 ai_socktype     dd ?                    ; XREF: sub_4C04F0+62/w
0000000C ai_protocol     dd ?                    ; XREF: sub_4C04F0+65/w
00000010 ai_addrlen      dd ?                    ; XREF: sub_4C04F0+68/w
00000014 ai_canonname    dd ?                    ; XREF: sub_4C04F0+6B/w ; offset
00000018 ai_addr         dd ?                    ; XREF: sub_4C04F0+6E/w ; offset
0000001C ai_next         dd ?                    ; XREF: sub_4C04F0+71/w ; offset
00000020 ADDRINFOA       ends
00000020

    */

}
