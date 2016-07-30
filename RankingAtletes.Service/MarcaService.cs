using RankingAtletes.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RankingAtletes.Service
{
    public interface IMarcaService: IEntityService<Marca>
    {
        Marca GetById(long id);
    }
    public class MarcaService : EntityService<Marca>, IMarcaService
    {
        public MarcaService(IContext context) : base(context) { }

        public Marca GetById(long id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }

        public override IEnumerable<Marca> GetAll()
        {
            return _context.Marcas
                .Include(x => x.Atleta)
                .Include(x => x.Prueba)
                .ToList();
        }
    }
}
