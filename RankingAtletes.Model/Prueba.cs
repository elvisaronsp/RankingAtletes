using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RankingAtletes.Model
{
    public class Prueba : Entity<long>
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public int CantidadParticipantes { get; set; }

        [Required]
        public long MedidaId { get; set; }

        [Required]
        public long PistaId { get; set; }

        [ForeignKey("MedidaId")]
        public virtual Medida Medida { get; set; }

        [ForeignKey("PistaId")]
        public virtual Pista Pista { get; set; }
    }
}
