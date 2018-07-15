using BlazorServerSide.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Blazor;

namespace BlazorServerSide.Client.Services
{
    public class HeroClient
    {
        private readonly HttpClient _httpClient;

        public HeroClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Hero>> GetHeroes()
        {
            return await _httpClient.GetJsonAsync<List<Hero>>("/api/heroes");
        }

        public async Task<Hero> GetHero(string id)
        {
            return await _httpClient.GetJsonAsync<Hero>($"/api/heroes/{id}");
        }

        public async Task<List<Hero>> GetTopHeroes()
        {
            return await _httpClient.GetJsonAsync<List<Hero>>("/api/heroes/top");
        }

        public async Task<List<Hero>> SearchHeroes(string name)
        {
            return await _httpClient.GetJsonAsync<List<Hero>>($"/api/heroes?name={name}");
        }
        public async Task CreateHero(string name)
        {
            await _httpClient.PostJsonAsync($"/api/heroes", new Hero { Name = name });
        }

        public async Task UpdateHero(string heroId, string name)
        {
            await _httpClient.PutJsonAsync($"/api/heroes/{heroId}", new Hero { Id = int.Parse(heroId), Name = name });
        }

        public async Task DeleteHero(string heroId)
        {
            await _httpClient.DeleteAsync($"/api/heroes/{heroId}");
        }
    }
}
