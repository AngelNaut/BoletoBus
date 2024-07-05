using BoletoBus.Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Asiento.Domain.Interface
{
    public interface IAsientoRepository : IBaseRepository<Asiento.Domain.Entities.Asiento>
    {
    }
}
