using BoletoBus.Common.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Bus.Domain.Interface
{
    public interface IBusRepository : IBaseRepository<Bus.Domain.Entities.Bus>
    {

    }
}
