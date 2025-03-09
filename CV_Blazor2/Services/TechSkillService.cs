using CV_Blazor2.Models;

namespace CV_Blazor2.Services
{
    public class TechSkillService
    {
        private readonly HttpClient _httpClient;


        public TechSkillService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AddTechSkillAsync(TechSkill skill)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("https://karolin-cv-api-hfe5feakc9e5gxe8.westeurope-01.azurewebsites.net/Tech-skills", skill);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Misslyckades! Statuskod: {response.StatusCode}");
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Felmeddelande: {errorMessage}");
                }

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel inträffade vid API-anropet: {ex.Message}");
                return false;
            }
        }
    }
}
