
using BoletoBus.Viaje.Domain.Interface;
using System.Linq.Expressions;

namespace BoletoBus.Asiento.Persistence.Repositories
{
    public class AsientoRepository : IAsientoRepository
    {
        public void Editar(Viaje.Domain.Entities.Asiento entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Viaje.Domain.Entities.Asiento entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Viaje.Domain.Entities.Asiento, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Viaje.Domain.Entities.Asiento> GetAll(Viaje.Domain.Entities.Asiento entity)
        {
            throw new NotImplementedException();
        }

        public Viaje.Domain.Entities.Asiento GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Viaje.Domain.Entities.Asiento entity)
        {
            throw new NotImplementedException();
        }
    }
}
