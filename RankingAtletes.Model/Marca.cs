using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RankingAtletes.Model
{
    public class Marca : AuditableEntity<long>
    {
        [Required]
        public long Valor { get; set; }
        [Required]
        public long AtletaId { get; set; }
        [Required]
        public long PruebaId { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public string Poblacion { get; set; }
        [ForeignKey("AtletaId")]
        public virtual Atleta Atleta { get; set; }
        [ForeignKey("PruebaId")]
        public virtual Prueba Prueba { get; set; }
    }
}
