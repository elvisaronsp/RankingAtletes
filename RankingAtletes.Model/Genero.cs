using System.ComponentModel.DataAnnotations;

namespace RankingAtletes.Model
{
    public class Genero: Entity<long>
    {
        [Required]
        public string Nombre { get; set; }
    }
}
