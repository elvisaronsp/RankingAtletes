using System;
using System.ComponentModel.DataAnnotations;

namespace RankingAtletes.Model
{
    public class Atleta : AuditableEntity<long>
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }
        
        [Required]
        public Genero Genero { get; set; }

    }
}
