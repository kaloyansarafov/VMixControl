namespace VMixHTTP;

using VMixHTTP.Audio;

public class Api
{
    private readonly HttpClient _client;
    private string url { get; init; }

    /// <summary>
    /// Get the version of the wrapper
    /// </summary>
    /// <returns>Wrapper version</returns>
    public string GetWrapperVersion()
    {
        return "0.0.1";
    }
    
    public Api(string url)
    {
        _client = new HttpClient();
        this.url = url;
    }

    /// <summary>
    /// Sends a request to the VMix API
    /// </summary>
    /// <param name="request"></param>
    /// <returns>vMix API response</returns>
    private async Task<string> SendRequestAsync(string request)
    {
        var response = await _client.GetAsync($"{url}/api/?{request}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
    
    
}