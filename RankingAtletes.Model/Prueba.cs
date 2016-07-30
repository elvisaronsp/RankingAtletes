using System.ComponentModel.DataAnnotations;

namespace RankingAtletes.Model
{
    public class Prueba : Entity<long>
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public int CantidadParticipantes { get; set; }

        [Required]
        public Medida Medida { get; set; }

        [Required]
        public Pista Pista { get; set; }


    }
}
