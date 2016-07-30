using RankingAtletes.Model;
using System.Linq;

namespace RankingAtletes.Service
{
    public interface IMedidaService: IEntityService<Medida>
    {
        Medida GetById(long id);
    }
    public class MedidaService : EntityService<Medida>, IMedidaService
    {
        public MedidaService(IContext context) : base(context) { }

        public Medida GetById(long id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }
    }
}
