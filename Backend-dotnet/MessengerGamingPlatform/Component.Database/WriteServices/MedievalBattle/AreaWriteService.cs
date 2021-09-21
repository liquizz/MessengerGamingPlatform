using Component.Database.ReadServices.MedievalBattle;
using Component.Database.WriteServices.MedievalBattle.Interfaces;

namespace Component.Database.WriteServices.MedievalBattle
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