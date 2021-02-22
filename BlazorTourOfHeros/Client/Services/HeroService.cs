using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorTourOfHeros.Shared;

namespace BlazorTourOfHeros.Client.Services
{
    public class HeroService : IHeroService
    {
        private readonly HttpClient Http;
        private readonly IMessagingService messagingService;

        public HeroService(HttpClient client, IMessagingService MessagingService)
        {
            Http = client;
            messagingService = MessagingService;
        }


        // Get Heroes
        public async Task<Hero[]> GetHeroes()
        {
            await messagingService.Add("Heroes Service: Heroes Fetched");
            return await Http.GetFromJsonAsync<Hero[]>("Hero");
        }
    }
}
