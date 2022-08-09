namespace CryptoDashboard.Dtos
{
    public class MarketDto
    {
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public Uri Image { get; set; }
        public double CurrentPrice { get; set; }
        public double PriceChange24H { get; set; }
    }
}
