﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace VAC.UserInformation
{
    public static class ProcessorInformation
    {
        public static string Get()
        {
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }

            return id;
        }
    }
}
