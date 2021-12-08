using System;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace IHttpClientFactoryInSingletonService;

internal class CustomLoggerProvider : ILoggerProvider
{
    private readonly IHttpClientFactory _factory;

    public CustomLoggerProvider(IHttpClientFactory _factory)
    {
        this._factory = _factory;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public ILogger CreateLogger(string categoryName)
    {
        throw new NotImplementedException();
    }
}
