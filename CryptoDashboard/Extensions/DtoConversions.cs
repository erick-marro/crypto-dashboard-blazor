using CryptoDashboard.Dtos;
using CryptoDashboard.Models;

namespace CryptoDashboard.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<MarketDto> MarketToDto(this IEnumerable<Market> markets)
        {
            return (from market in markets
                    select new MarketDto()
                    {
                        Id = market.Id,
                        Symbol = market.Symbol,
                        Name = market.Name,
                        Image = market.Image,
                        CurrentPrice = market.Current_Price,
                        PriceChange24H = market.Price_Change_24H,
                    });
        }
    }
}
