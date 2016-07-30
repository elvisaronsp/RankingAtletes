using RankingAtletes.Model;
using System.Linq;

namespace RankingAtletes.Service
{
    public interface IGeneroService: IEntityService<Genero>
    {
        Genero GetById(long id);
    }
    public class GeneroService : EntityService<Genero>, IGeneroService
    {
        public GeneroService(IContext context) : base(context) { }

        public Genero GetById(long id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }
    }
}
