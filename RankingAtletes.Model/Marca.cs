using System;
using System.ComponentModel.DataAnnotations;

namespace RankingAtletes.Model
{
    public class Marca: AuditableEntity<long>
    {
        [Required]
        public long Valor { get; set; }
        [Required]
        public Atleta Atleta { get; set; }
        [Required]
        public Prueba Prueba { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public string Poblacion { get; set; }

    }
}
