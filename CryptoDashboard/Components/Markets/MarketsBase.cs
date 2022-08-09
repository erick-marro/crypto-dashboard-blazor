using CryptoDashboard.Models;
using CryptoDashboard.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace CryptoDashboard.Components.Markets
{
    public class MarketsBase: ComponentBase
    {
        [Inject]
        public ICoinService CoinService { get; set; }

        public IEnumerable<Market> Markets { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Markets = await CoinService.GetMarkets();
        }

    }
}
