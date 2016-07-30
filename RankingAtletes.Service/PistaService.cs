using RankingAtletes.Model;
using System.Linq;

namespace RankingAtletes.Service
{
    public interface IPistaService: IEntityService<Pista>
    {
        Pista GetById(long id);
    }
    public class PistaService : EntityService<Pista>, IPistaService
    {
        public PistaService(IContext context) : base(context) { }

        public Pista GetById(long id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }
    }
}
