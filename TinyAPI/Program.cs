using System;
using Microsoft.AspNetCore.Builder;

WebApplicationBuilder webApplicationBuilder =
    WebApplication.CreateBuilder(args);

WebApplication webApplication =
    webApplicationBuilder.Build();



webApplication.MapGet("/api/home",
    (Func<string>)(() => "This is the home endpoint"));

webApplication.Run();