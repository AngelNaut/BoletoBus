using BoletoBus.Common.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletoBus.Viaje.Domain.Entities
{
    public class Usuario : AuditEntity<int>
    {
        [Column("IdUsuario")]
        public override int Id { get => base.Id; set => base.Id = value; }
    }
}
