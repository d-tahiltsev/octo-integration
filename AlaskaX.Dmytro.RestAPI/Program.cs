using AlaskaX.Dmytro.Infrastructure.IoC;

using Microsoft.Extensions.PlatformAbstractions;

using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{PlatformServices.Default.Application.ApplicationName}.xml"));
    c.EnableAnnotations();
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddHealthChecks();
builder.Services.AddResponseCompression();
builder.Services.AddEndpointsApiExplorer();

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

app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks("/health");

app.UseResponseCompression();

app.Run();
