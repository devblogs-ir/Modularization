namespace Design.Coupling.ExternalCoupling;

using System.Net.Http;
using System.Threading.Tasks;

/// <summary>
/// External Coupling occurs when two or more modules depend on the same external interface.
/// To reduce external coupling, it is suggested to use Dependency Injection (DI). 
/// In this example, the WebService class interacts with a RESTful web service using the HttpClient.
/// </summary>
public class WebService
{
    private readonly HttpClient _httpClient;

    public WebService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<string> GetAsync(string url)
    {
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}