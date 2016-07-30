using System.ComponentModel.DataAnnotations;

namespace RankingAtletes.Model
{
    public class Pista: Entity<long>
    {
        [Required]
        public string Nombre { get; set; }
    }
}
