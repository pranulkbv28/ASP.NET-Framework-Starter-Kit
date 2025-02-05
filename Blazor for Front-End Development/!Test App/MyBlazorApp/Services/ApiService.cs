using System;
using Microsoft.JSInterop;

namespace MyBlazorApp.Services;

public class ApiService
{
    private readonly IConfiguration? _configuration;
    private readonly IJSRuntime _jsRuntime;

    public ApiService(IConfiguration configuration, IJSRuntime jsRuntime)
    {
        _configuration = configuration;
        _jsRuntime = jsRuntime;
    }

    public string GetApiUrl()
    {
        _jsRuntime.InvokeVoidAsync("console.log", _configuration?["ApiSettings:BaseUrl"]);
        return _configuration?["ApiSettings:BaseUrl"] ?? "https://localhost:5001";
    }
}
