using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Common.Data.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll(TEntity entity);
        TEntity GetEntityBy(int Id);

        void Guardar(TEntity entity);

        void Eliminar(TEntity entity);

        void Editar(TEntity entity);

        bool Exists(Expression<Func<TEntity, bool>> filter);

    }
}
