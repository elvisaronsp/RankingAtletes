using RankingAtletes.Model;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace RankingAtletes.Service
{
    public interface IAtletaService: IEntityService<Atleta>
    {
        Atleta GetById(long id);
    }
    public class AtletaService : EntityService<Atleta>, IAtletaService
    {
        public AtletaService(IContext context) : base(context) { }

        public Atleta GetById(long id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }

        public override IEnumerable<Atleta> GetAll()
        {
            return _context.Atletas
                .Include(x => x.Genero)
                .ToList();
        }
    }
}
