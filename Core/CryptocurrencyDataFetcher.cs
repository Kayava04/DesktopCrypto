using DesktopCrypto.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows;

namespace DesktopCrypto.Core
{
    public class CryptocurrencyDataFetcher
    {
        private const string URL = "https://api.coincap.io/v2/assets?limit=10";

        public async Task<CryptocurrencyDataList> GetCryptocurrencyListAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string answer = string.Empty;
                
                try
                {
                    var response = await httpClient.GetStringAsync(URL);
                    answer = response;
                    var cryptocurrencyDataList = JsonConvert.DeserializeObject<CryptocurrencyDataList>(answer);
                    
                    return cryptocurrencyDataList;
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("Error getting data, try again!", "API error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Unexpected error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return null;
                }
            }
        }
    }
}