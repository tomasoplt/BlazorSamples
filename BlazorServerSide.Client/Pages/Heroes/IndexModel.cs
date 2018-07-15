using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorServerSide.Client.Services;
using BlazorServerSide.Shared.Models;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorServerSide.Client.Pages.Heroes
{
    public class IndexModel : BlazorComponent
    {
        public IndexModel()
        {

        }
        [Inject]
        private AppState AppState { get; set; }
        public List<Hero> Heroes { get; set; }
        public List<Hero> SearchResults { get; set; }

        public string SearchCriteria { get; set; }
        public bool SearchInProgress { get; set; } = false;

        protected async void SearchHeroes()
        {
            SearchInProgress = true;
            SearchResults = await AppState.HeroClient.SearchHeroes(SearchCriteria);
            SearchInProgress = false;
            this.StateHasChanged();
        }

        protected override async Task OnInitAsync()
        {
            Heroes = await AppState.HeroClient.GetTopHeroes();
        }

    }
}
