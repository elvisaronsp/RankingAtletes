using System;

namespace RankingAtletes.Model
{
    public interface IAuditableEntity
    {
        DateTime FechaCreacion { get; set; }

        string CreadoPor { get; set; }

        DateTime FechaActualizacion { get; set; }

        string ActualizadoPor { get; set; }
    }
}
