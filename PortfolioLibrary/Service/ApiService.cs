using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioAPI.Models;
using static PortfolioLibrary.Service.ApiService;

namespace PortfolioLibrary.Service
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProjectsModel>> GetAllProjectsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://alexprojectsapi.azurewebsites.net/api/Portfolio"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<ProjectsModel>>(apiResponse);
                }
            }
        }

    }

}


