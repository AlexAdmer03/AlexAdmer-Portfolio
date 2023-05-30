using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PortfolioAPI.Models;
using PortfolioLibrary.Service;

namespace AlexAdmer_Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IApiService _apiService;
        public IndexModel(IApiService apiService)
        {
            _apiService = apiService;
        }

        public List<ProjectsModel> MyProjects { get; set; }

        public async Task OnGetAsync()
        {
            MyProjects = await _apiService.GetAllProjectsAsync();
        }

    }
}