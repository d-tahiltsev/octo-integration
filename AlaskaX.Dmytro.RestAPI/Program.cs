using AlaskaX.Dmytro.Infrastructure.IoC;
using AlaskaX.Dmytro.RestAPI.Configurations;

using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;

using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersConfig();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(
                    options => options.AddPolicy("AllowAll",
                                                    p => p.AllowAnyOrigin()
                                                        .AllowAnyMethod()
                                                        .AllowAnyHeader())
                );

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Authorization", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = @"Please enter Authorization Token into field.",
        Name = "Authorization",
        BearerFormat = "JWT",
        Scheme = "bearer",
        Type = SecuritySchemeType.Http
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Authorization" }
            },
            [ "Authorization" ]
        }
    });

    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{PlatformServices.Default.Application.ApplicationName}.xml"));
    c.EnableAnnotations();
});

builder.Services.AddJwtAuthenticationConfig();
builder.Services.AddHttpContextAccessor();
builder.Services.AddHealthChecks();
builder.Services.AddResponseCompression();
builder.Services.AddEndpointsApiExplorer();

//NativeInjectorBootStrapper.ResolveRepositories(builder.Services);
NativeInjectorBootStrapper.ResolveServices(builder.Services);
NativeInjectorBootStrapper.ResolveAdapters(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.DocExpansion(DocExpansion.None);
        c.DefaultModelExpandDepth(2);
        c.DefaultModelRendering(ModelRendering.Example);
        c.DisplayOperationId();
        c.DisplayRequestDuration();
        c.EnableDeepLinking();
        c.EnableTryItOutByDefault();
        c.EnableValidator();
        c.ShowCommonExtensions();
    });
}

app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.UseHsts();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks("/health");

app.UseResponseCompression();

app.Run();
