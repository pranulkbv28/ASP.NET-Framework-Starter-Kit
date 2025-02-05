using System;
using Microsoft.Extensions.Configuration;

namespace MyBlazorServerApp.Services;

public class ApiService
{
    private readonly IConfiguration? _configuration;

    // Constructor: Inject IConfiguration to access appsettings.json
    public ApiService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    // Method: Access the BaseUrl from appsettings.Development.json
    public string GetApiUrl()
    {
        return _configuration?["ApiSettings:BaseUrl"] ?? "https://localhost:5001";
    }
}
