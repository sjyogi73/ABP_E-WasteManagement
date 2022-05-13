using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace eWasteManagement;

public class eWasteManagementWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<eWasteManagementWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
