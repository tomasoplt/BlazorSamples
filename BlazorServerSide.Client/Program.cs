using BlazorServerSide.Client.Services;
using BlazorServerSide.Shared;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BlazorServerSide.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                services.AddSingleton<AppState>();
                services.AddSingleton<IBooksClient, BooksClient>();
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
