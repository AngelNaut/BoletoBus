using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Common.Data.Base
{
    public class AuditEntity<TType> : BaseEntity<TType>
    {
        public override TType Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
