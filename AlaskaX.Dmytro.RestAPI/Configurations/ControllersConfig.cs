using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlaskaX.Dmytro.RestAPI.Configurations
{
    public static class ControllersConfig
    {
        /// <summary>
        /// Controllers service configuration
        /// </summary>
        /// <param name="services"></param>
        public static void AddControllersConfig(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddControllers(options =>
            {
                options.SuppressAsyncSuffixInActionNames = false;
                options.ReturnHttpNotAcceptable = true;
                options.EnableEndpointRouting = true;
                options.RequireHttpsPermanent = true;
            })
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                options.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
                options.JsonSerializerOptions.IgnoreReadOnlyFields = true;
                options.JsonSerializerOptions.AllowTrailingCommas = true;
                options.JsonSerializerOptions.IncludeFields = true;
                options.JsonSerializerOptions.NumberHandling = JsonNumberHandling.AllowReadingFromString;
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                options.JsonSerializerOptions.ReadCommentHandling = JsonCommentHandling.Skip;
            })
            .AddNewtonsoftJson(newtonsoft =>
            {
                newtonsoft.SerializerSettings.Converters.Add(new StringEnumConverter());
                newtonsoft.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver()
                {
                    IgnoreSerializableAttribute = true,
                    SerializeCompilerGeneratedMembers = true,
                    IgnoreIsSpecifiedMembers = false,
                };
                newtonsoft.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                newtonsoft.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                newtonsoft.SerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
            });
        }
    }
}