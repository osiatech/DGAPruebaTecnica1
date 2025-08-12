
using Domain.DGA.Core;
using Domain.DGA.Entities;

namespace Infraestructure.DGA.Interfaces
{
    public interface IProductoRepository : IBaseRepository<Producto>
    {
        public abstract void GetProductoById(int id);
    }
}
