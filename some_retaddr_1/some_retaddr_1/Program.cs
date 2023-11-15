/*
 
__int64 __fastcall sub_1801F0CE0(__int64 a1, int *a2)
{
  int v2; // ebx
  __int64 v4; // rsi
  __int64 result; // rax

  v2 = *a2;
  if ( *a2 >= 0 )
  {
    if ( v2 > 3 )
      v2 = 3;
  }
  else
  {
    v2 = 0;
  }
  v4 = 1120i64 * v2;
  if ( (unsigned __int8)LoggingSystem_IsChannelEnabled(LOG_CONSOLE, 2i64) )
    LoggingSystem_Log(
      LOG_CONSOLE,
      2i64,
      "pos [player %d]: %.3f,%.3f,%.3f\n",
      (unsigned int)v2,
      *(float *)(v4 + a1 + 336),
      *(float *)(v4 + a1 + 340),
      *(float *)(v4 + a1 + 344));
  result = LoggingSystem_IsChannelEnabled(LOG_CONSOLE, 2i64);
  if ( (_BYTE)result )
    return LoggingSystem_Log(
             LOG_CONSOLE,
             2i64,
             "angles[player %d]: %.3f,%.3f,%.3f\n",
             (unsigned int)v2,
             *(float *)(v4 + a1 + 348),
             *(float *)(v4 + a1 + 352),
             *(float *)(v4 + a1 + 356));
  return result;
}

// .rdata:0000000180418B70 aAnglesPlayerD3 db 'angles[player %d]: %.3f,%.3f,%.3f',0Ah,0

 */


using System;
using static Engine2Imports;

class some_retaddr_1
{
    public static Int64 sub_1801F0CE0(Int64 a1, int a2)
    {
        unsafe
        {
            int v2;
            Int64 v4;
            Int64 result = 0;

            v2 = a2;
            if (a2 >= 0)
            {
                if (v2 > 3)
                    v2 = 3;
            }
            else
            {
                v2 = 0;
            }

            v4 = /*1120i64*/1120L * v2;
            if ((sbyte /*unsigned __int8 == sbye*/ )LoggingSystem_IsChannelEnabled((ulong)LOG_CONSOLE(), 2UL) != 0)
            {
                LoggingSystem_Log((ulong)LOG_CONSOLE(), 2UL, "pos [player %d]: %.3f,%.3f,%.3f\n", (uint)v2,
                    *(float*)(v4 + a1 + 336),
                    *(float*)(v4 + a1 + 340),
                    *(float*)(v4 + a1 + 344));

                result = LoggingSystem_IsChannelEnabled((ulong)LOG_CONSOLE(), 2UL);
            }

            if ((byte /*_BYTE == bye*/ )result != 0)
            {
                 return LoggingSystem_Log((ulong)LOG_CONSOLE(), 2UL, "angles[player %d]: %.3f,%.3f,%.3f\n", (uint)v2,
                 *(float*)(v4 + a1 + 348),
                 *(float*)(v4 + a1 + 352),
                 *(float*)(v4 + a1 + 356));
            }
                
            return result;
        }
    }
}