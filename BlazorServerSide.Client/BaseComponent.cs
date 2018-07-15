using System.Net.Http;
using BlazorServerSide.Shared;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.Services;

namespace BlazorServerSide.Client
{
    public abstract class BaseComponent : BlazorComponent
    {
        [Inject]
        protected IUriHelper UriHelper { get; set; }

        [Inject]
        protected IBooksClient BooksClient { get; set; }
    }
}
