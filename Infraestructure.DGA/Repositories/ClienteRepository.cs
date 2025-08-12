

using Domain.DGA.Entities;
using Infraestructure.DGA.Context;
using Infraestructure.DGA.Core;
using Infraestructure.DGA.Interfaces;


namespace Infraestructure.DGA.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly Project1DbContext dbContext;


        public ClienteRepository(Project1DbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }


        public List<Cliente> GetClienteById(int id)
        {
            var cliente = this.dbContext.Clientes.Where(cliente => cliente.Id == id).ToList();
            return cliente;
        }


        public override List<Cliente> GetEntities()
        {
            return this.dbContext.Clientes.ToList();
        }


        public override void Save(Cliente entity)
        {
            dbContext.Clientes.Add(entity);
            dbContext.SaveChanges();
        }


        public override void Update(Cliente entity)
        {
            var clienteUpdated = base.GetEntity(entity.Id);

            clienteUpdated.Nombre = entity.Nombre;
            clienteUpdated.Email = entity.Email;
            clienteUpdated.Telefono = entity.Telefono;

            dbContext.Clientes.Update(clienteUpdated);
            dbContext.SaveChanges();
        }


        public override void Delete(Cliente entity)
        {
            var clienteDeleted = base.GetEntity(entity.Id);

            clienteDeleted.Id = entity.Id;
            clienteDeleted.Nombre = entity.Nombre;
            clienteDeleted.Email = entity.Email;
            clienteDeleted.Telefono = entity.Telefono;

            this.dbContext.Update(clienteDeleted);
            this.dbContext.SaveChanges();
        }

    }
}
