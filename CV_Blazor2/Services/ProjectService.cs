using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using CV_Blazor2.Models;

namespace CV_Blazor2.Services
{
    public class ProjectService
    {
        private readonly HttpClient _httpClient;


        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Project>> GetProjectsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Project>>("https://karolin-cv-api-hfe5feakc9e5gxe8.westeurope-01.azurewebsites.net/Projects") ?? new List<Project>();
        }

        public async Task<bool> AddProjectAsync(Project project)
        {
            var response = await _httpClient.PostAsJsonAsync("https://karolin-cv-api-hfe5feakc9e5gxe8.westeurope-01.azurewebsites.net/Projects", project);
            return response.IsSuccessStatusCode;
        }
    }

}

    