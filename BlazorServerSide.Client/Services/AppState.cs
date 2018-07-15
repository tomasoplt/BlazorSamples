using System;
using System.Net.Http;

namespace BlazorServerSide.Client.Services
{
    public class AppState
    {
        // Lets components receive change notifications
        // Could have whatever granularity you want (more events, hierarchy...)
        public event Action OnChange;

        // Receive 'http' instance from DI
        private readonly HttpClient _http;

        private readonly HeroClient _heroClient;

        public AppState(HttpClient httpInstance)
        {
            _http = httpInstance;
            _heroClient = new HeroClient(_http);
        }

        public HeroClient HeroClient
        {
            get
            {
                return _heroClient;
            }
        }

        public HttpClient Http
        {
            get
            {
                return _http;
            }
        }

    }
}
