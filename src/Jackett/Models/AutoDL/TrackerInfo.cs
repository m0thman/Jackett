﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackett.Models.AutoDL
{
    public class TrackerInfo
    {
        public string FileName { get; set; }
        public string Type { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string SiteName { get; set; }
        // Defined but never used
        // public bool Deobfuscate { get; set; }
        // public string Follow302 { get; set; }
        public List<ServerInfo> Servers { get; set; } = new List<ServerInfo>();
       
    }
}
