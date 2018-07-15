using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorServerSide.Client.Services;
using BlazorServerSide.Shared.Models;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorServerSide.Client.Pages.Todo
{
    public class IndexModel : BlazorComponent
    {
        public IndexModel()
        {

        }

        [Inject]
        public AppState App { get; set; }

        protected override async Task OnInitAsync()
        {
        }

    }
}
