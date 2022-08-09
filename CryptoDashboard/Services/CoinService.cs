using CryptoDashboard.Dtos;
using CryptoDashboard.Models;
using CryptoDashboard.Services.Contracts;
using System.Net.Http.Json;

namespace CryptoDashboard.Services
{
    public class CoinService: ICoinService
    {
        private readonly HttpClient _httpClient;

        public CoinService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Market>> GetDashboardMarkets()
        {
            try
            {

                var markets = await _httpClient.GetFromJsonAsync<IEnumerable<Market>>("coins/markets?vs_currency=usd&ids=bitcoin%2Cethereum%2Csolana&order=market_cap_desc&per_page=50&page=1&sparkline=false");
                return markets;

            } catch (Exception ex)
            {
                return null; 
            }
        }

        public async Task<IEnumerable<Market>> GetMarkets()
        {
            try
            {

                var markets = await _httpClient.GetFromJsonAsync<IEnumerable<Market>>("coins/markets?vs_currency=usd&order=market_cap_desc&per_page=50&page=1&sparkline=false");
                return markets;

            } catch (Exception ex)
            {
                return null;
            }
        }
    }
}
