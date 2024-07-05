using BoletoBus.Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Viaje.Domain.Interface
{
    public interface IAsientoRepository : IBaseRepository<Viaje.Domain.Entities.Asiento>
    {
    }
}
