using System;
using System.Runtime.InteropServices;

namespace vac_some_steamdll_structs
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct _STARTUPINFOW
    {
        public uint cb;
        public IntPtr lpReserved;
        public IntPtr lpDesktop;
        public IntPtr lpTitle;
        public uint dwX;
        public uint dwY;
        public uint dwXSize;
        public uint dwYSize;
        public uint dwXCountChars;
        public uint dwYCountChars;
        public uint dwFillAttribute;
        public uint dwFlags;
        public ushort wShowWindow;
        public ushort cbReserved2;
        public IntPtr lpReserved2;
        public IntPtr hStdInput;
        public IntPtr hStdOutput;
        public IntPtr hStdError;
    }

    /*
    
00000000 _STARTUPINFOW   struc ; (sizeof=0x44, align=0x4, copyof_100)
00000000                                         ; XREF: sub_54E5C9/r
00000000                                         ; sub_570D6E/r
00000000 cb              dd ?
00000004 lpReserved      dd ?                    ; offset
00000008 lpDesktop       dd ?                    ; offset
0000000C lpTitle         dd ?                    ; offset
00000010 dwX             dd ?
00000014 dwY             dd ?
00000018 dwXSize         dd ?
0000001C dwYSize         dd ?
00000020 dwXCountChars   dd ?
00000024 dwYCountChars   dd ?
00000028 dwFillAttribute dd ?
0000002C dwFlags         dd ?                    ; XREF: sub_54E5C9+20/r
00000030 wShowWindow     dw ?                    ; XREF: sub_54E5C9+26/r
00000032 cbReserved2     dw ?                    ; XREF: sub_570D6E+12/r
00000034 lpReserved2     dd ?                    ; XREF: sub_570D6E+1E/r ; offset
00000038 hStdInput       dd ?                    ; offset
0000003C hStdOutput      dd ?                    ; offset
00000040 hStdError       dd ?                    ; offset
00000044 _STARTUPINFOW   ends
00000044

     */
}