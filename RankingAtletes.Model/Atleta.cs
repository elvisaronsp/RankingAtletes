using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RankingAtletes.Model
{
    public class Atleta : AuditableEntity<long>
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public long GeneroId { get; set; }

        [ForeignKey("GeneroId")]
        public virtual Genero Genero { get; set; }

    }
}
