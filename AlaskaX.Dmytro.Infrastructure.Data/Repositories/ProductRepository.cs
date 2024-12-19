using AlaskaX.Dmytro.Domain.Entities.Products;
using AlaskaX.Dmytro.Domain.Interfaces.Repositories;
using AlaskaX.Dmytro.Infrastructure.Data.Contexts;

namespace AlaskaX.Dmytro.Infrastructure.Data.Repositories
{
    public partial class ProductRepository(MySQL aMySQL) : MySQLRepository<Product>(aMySQL), IProductRepository
    {

    }
}
