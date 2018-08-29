using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart.Wasl.Homes.Services.HomeAppliances.Settings
{
  
        public class AppSettings
        {
            public Connectionstrings ConnectionStrings { get; set; }
        }

        public class Connectionstrings
        {
            public string DefaultConnection { get; set; }
        }
    
}
