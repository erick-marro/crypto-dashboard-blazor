namespace CryptoDashboard.Models
{

    public partial class Market
    {
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public Uri Image { get; set; }
        public double Current_Price { get; set; }
        public long MarketCap { get; set; }
        public long MarketCapRank { get; set; }
        public long? FullyDilutedValuation { get; set; }
        public long TotalVolume { get; set; }
        public double High24H { get; set; }
        public double Low24H { get; set; }
        public double Price_Change_24H { get; set; }
        public double PriceChangePercentage24H { get; set; }
        public double MarketCapChange24H { get; set; }
        public double MarketCapChangePercentage24H { get; set; }
        public double CirculatingSupply { get; set; }
        public double? TotalSupply { get; set; }
        public double? MaxSupply { get; set; }
        public double Ath { get; set; }
        public double AthChangePercentage { get; set; }
        public DateTimeOffset AthDate { get; set; }
        public double Atl { get; set; }
        public double AtlChangePercentage { get; set; }
        public DateTimeOffset AtlDate { get; set; }
        public Roi Roi { get; set; }
        public DateTimeOffset LastUpdated { get; set; }
    }

    public partial class Roi
    {
        public double Times { get; set; }
        public string Currency { get; set; }
        public double Percentage { get; set; }
    }

}
