using BoletoBus.Common.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Bus.Domain.Entities
{
    public class Bus : AuditEntity<int>
    {
        [Column("IdBus")]
        public override int Id { get => base.Id; set => base.Id = value; }
    }
}
