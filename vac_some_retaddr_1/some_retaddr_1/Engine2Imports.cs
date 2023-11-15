using System;
using System.Runtime.InteropServices;

public class Engine2Imports
{
    [DllImport("engine2.dll")]
    public static extern Int64 LoggingSystem_IsChannelEnabled(ulong param1, ulong param2);

    [DllImport("engine2.dll")]
    public static extern Int64 LOG_CONSOLE()/* = 0*/;

    [DllImport("engine2.dll")]
    public static extern long LoggingSystem_Log(ulong param1, ulong param2, string format, params object[] args);
}
