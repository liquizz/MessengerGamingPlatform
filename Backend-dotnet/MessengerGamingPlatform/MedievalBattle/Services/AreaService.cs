using MedievalBattle.Queries;
using MedievalBattle.Queries.Interfaces;
using MedievalBattle.Services.Interfaces;

namespace MedievalBattle.Services
{
    public class AreaService : IAreaService
    {
        private readonly AreaQueries _queries;
        public AreaService(IAreaQueries queries)
        {
            _queries = (AreaQueries)queries;
        }
    }
}