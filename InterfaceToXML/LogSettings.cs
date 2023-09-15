using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceToXML
{
    public class LogSettings
    {
        public string MinimumLogLevel { get; set; }
        public bool LogStartAndStop { get; set; }
        public bool LogRunStartAndStop { get; set; }
        public bool LogRunBody { get; set; }
    }
}
