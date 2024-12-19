using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AlaskaX.Dmytro.Infrastructure.Data.Contexts

{
    public class MySQL : DbContext
    {
        protected readonly IConfiguration _Configuration;

        public MySQL(IConfiguration configuration)
        {
            _Configuration = configuration;
        }
    }
}
