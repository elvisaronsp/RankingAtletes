using System;
using System.ComponentModel.DataAnnotations;

namespace RankingAtletes.Model
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        [ScaffoldColumn(false)]
        public DateTime FechaCreacion { get; set; }


        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string CreadoPor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime FechaActualizacion { get; set; }

        [MaxLength(256)]
        [ScaffoldColumn(false)]
        public string ActualizadoPor { get; set; }
    }
}
