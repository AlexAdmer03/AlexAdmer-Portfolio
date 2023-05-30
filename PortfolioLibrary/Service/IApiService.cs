using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioAPI.Models;

namespace PortfolioLibrary.Service
{
    public interface IApiService
    {
        Task<List<ProjectsModel>> GetAllProjectsAsync();
    }
}
