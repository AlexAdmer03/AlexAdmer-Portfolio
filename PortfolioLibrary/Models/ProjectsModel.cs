using PortfolioLibrary.Models;

namespace PortfolioAPI.Models
{
    public class ProjectsModel
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUptade { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string PreviewURL { get; set; }
        public string GithubURL { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public SystemStructureModel SystemStructure { get; set; } 
        public List<string> TeamMembers { get; set; }
        public List<string> Features { get; set; }
    }
}
