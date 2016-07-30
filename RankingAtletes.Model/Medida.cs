using System.ComponentModel.DataAnnotations;

namespace RankingAtletes.Model
{
    public class Medida : Entity<long>
    {
        [Required]
        public string Nombre { get; set; }
    }
}
