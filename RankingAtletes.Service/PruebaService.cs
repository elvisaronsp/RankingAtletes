using RankingAtletes.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RankingAtletes.Service
{
    public interface IPruebaService: IEntityService<Prueba>
    {
        Prueba GetById(long id);
    }
    public class PruebaService : EntityService<Prueba>, IPruebaService
    {
        public PruebaService(IContext context) : base(context) { }

        public Prueba GetById(long id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }

        public override IEnumerable<Prueba> GetAll()
        {
            return _context.Pruebas
                .Include(x => x.Pista)
                .Include(x => x.Medida)
                .ToList();
        }
    }
}
