using BoletoBus.Common.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Asiento.Domain.Entities
{
    public class Asiento : AuditEntity<int>
    {
        [Column("IdAsiento")]
        public override int Id { get => base.Id; set => base.Id = value; }
    }
}
