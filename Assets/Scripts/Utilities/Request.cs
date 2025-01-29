using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json; // Use Newtonsoft.Json instead of System.Text.Json

namespace JSONPad.UnitySDK.Assets.Scripts.Utilities
{
    public class Request
    {
        public static async Task<T> Get<T>(string url)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json) ?? throw new InvalidOperationException("Deserialization returned null.");
        }
    }
}
