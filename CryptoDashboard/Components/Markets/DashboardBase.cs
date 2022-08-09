using CryptoDashboard.Models;
using CryptoDashboard.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace CryptoDashboard.Components.Markets
{
    public class DashboardBase: ComponentBase
    {
        [Inject]
        public ICoinService CoinService { get; set; }

        public IEnumerable<Market> Coins { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Coins = await CoinService.GetDashboardMarkets();
        }
    }
}
