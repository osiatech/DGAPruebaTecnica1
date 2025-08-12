

using Domain.DGA.Core;
using Domain.DGA.Entities;

namespace Infraestructure.DGA.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        public abstract List<Cliente> GetClienteById(int id);
    }
}
