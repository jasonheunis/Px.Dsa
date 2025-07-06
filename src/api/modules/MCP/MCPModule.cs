using Microsoft.Extensions.DependencyInjection;

namespace FSH.Starter.Api.Modules.MCP;

/// <summary>
/// Master Context Provider (MCP) server module.
/// Provides a central context and coordination point for distributed modules/services.
/// </summary>
public static class MCPModule
{
    public static IServiceCollection AddMCPModule(this IServiceCollection services)
    {
        // Register MCP services, context providers, and related dependencies here.
        // Example: services.AddSingleton<IMasterContextProvider, MasterContextProvider>();
        return services;
    }
}
