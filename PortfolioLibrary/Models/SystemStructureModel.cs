using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioLibrary.Models
{
    public class SystemStructureModel
    {
        public List<string> ProgrammingLanguages { get; set; }
        public List<string> FrameworksAndLibraries { get; set; }
        public List<string> Platforms { get; set; }
        public List<string> Tools { get; set; }
        public List<DatabaseModel> Databases { get; set; }
        public List<ApiModel> Api { get; set; }
    }
}
