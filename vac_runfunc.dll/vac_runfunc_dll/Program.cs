using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using static runfunc_dll.Imports;

namespace runfunc_dll
{
    class Program
    {
        private static void Main()
        {
            // Dosya yolunu ve bellek eşlemesi için dosya adını belirle
            string filePath = "C:\\Users\\ceza\\source\\repos\\ConsoleApp3\\private\\bin\\Debug\\1.exe";
            string mappingObjectName = "Global\\MyFileMappingObject";

            // Dosyayı aç
            IntPtr hFile = CreateFile(filePath, GENERIC_READ, 0, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);

            if (hFile != IntPtr.Zero)
            {
                // Dosya eşlemesi oluştur
                IntPtr hMapping = CreateFileMapping(hFile, IntPtr.Zero, PAGE_READONLY, 0, 1, mappingObjectName);

                if (hMapping != IntPtr.Zero)
                {
                    // Memory map'i al
                    IntPtr pData = MapViewOfFile(hMapping, FILE_MAP_READ, 0, 0, UIntPtr.Zero);

                    if (pData != IntPtr.Zero)
                    {
                        //long size = GetFileSize(pData);

                        byte[] buffer = new byte[/*size*/999]; // Örnek bir tampon
                        Marshal.Copy(pData, buffer, 0, buffer.Length);
                        string content = Encoding.UTF8.GetString(buffer);
                        Console.WriteLine("buffer (string): " + content);

                        Console.WriteLine("buffer (hex):\n");
                        foreach (byte b in buffer)
                        {
                            Console.Write($"{b:X2} ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error from MapViewOfFile -> " + Marshal.GetLastWin32Error());
                    }
                }
                else
                {
                    Console.WriteLine("Error from CreateFileMapping -> " + Marshal.GetLastWin32Error());
                }
            }
            else
            {
                Console.WriteLine("Error from CreateFile -> " + Marshal.GetLastWin32Error());
            }

            Console.ReadKey();
        }

        /* //test
        static long GetFileSize(IntPtr pData)
        {
            string filePath = Marshal.PtrToStringAnsi(pData);
            if (File.Exists(filePath))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                return fileInfo.Length;
            }
            else
            {
                return -1;
            }
        }
        */
    }
}
