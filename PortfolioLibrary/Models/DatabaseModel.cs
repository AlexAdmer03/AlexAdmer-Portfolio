using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioLibrary.Models
{
    public class DatabaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        public string HostName { get; set; }
        public List<string> Tables { get; set; }

    }
}
