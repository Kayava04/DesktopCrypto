using Newtonsoft.Json;

namespace DesktopCrypto.Models
{
    public class CryptocurrencyData
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("priceUsd")]
        public decimal PriceUSD { get; set; }

        [JsonProperty("changePercent24Hr")]
        public double ChangePercent24Hr { get; set; }

        [JsonProperty("marketCapUsd")]
        public decimal MarketCupUSD { get; set; }
    }
}