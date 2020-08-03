using Database.WriteServices.MedievalBattle.Interfaces;
using Database.ReadServices.MedievalBattle;

namespace Database.WriteServices.MedievalBattle
{
    public class AreaWriteService : IAreaWriteService
    {
        private readonly IAreaQueries _queries;
        public AreaWriteService(IAreaQueries queries)
        {
            _queries = queries;
        }
    }
}