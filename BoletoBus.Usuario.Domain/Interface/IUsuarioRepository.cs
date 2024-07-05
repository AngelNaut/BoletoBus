using BoletoBus.Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Usuario.Domain.Interface
{
    public interface IUsuarioRepository : IBaseRepository<Usuario.Domain.Entities.Usuario>
    {
    }
}
