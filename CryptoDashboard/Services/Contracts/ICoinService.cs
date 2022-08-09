using CryptoDashboard.Models;

namespace CryptoDashboard.Services.Contracts
{
    public interface ICoinService
    {
        Task<IEnumerable<Market>> GetMarkets();
        Task<IEnumerable<Market>> GetDashboardMarkets();
    }
}
