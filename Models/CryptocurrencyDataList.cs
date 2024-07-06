using Newtonsoft.Json;

namespace DesktopCrypto.Models
{
    public class CryptocurrencyDataList
    {
        [JsonProperty("data")]
        public List<CryptocurrencyData> Data { get; set; }
    }
}