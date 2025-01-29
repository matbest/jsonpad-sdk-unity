namespace JSONPad.UnitySDK.Assets.Scripts.Utilities;

public class Request
{
    public static async Task<T> Get<T>(string url)
    {
        // using var client = new HttpClient();
        // var response = await client.GetAsync(url);
        // response.EnsureSuccessStatusCode();
        // var json = await response.Content.ReadAsStringAsync();
        // return JsonSerializer.Deserialize<T>(json);

        // TODO

        throw new NotImplementedException();
    }
}
