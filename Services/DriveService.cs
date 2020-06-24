using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using cam.Models;

namespace cam.Services 
{
    public class DriveService 
    {
        private readonly HttpClient httpClient;
        public DriveService (HttpClient httpClient) 
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Student>> GetStudents(string url)
        {
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            using var responseContent = await response.Content.ReadAsStreamAsync();
            
            return await JsonSerializer.DeserializeAsync<List<Student>>(responseContent);
        }


    }
}