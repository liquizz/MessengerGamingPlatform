using Database.Models.MedievalBattleModels;
using Database.WriteServices.MedievalBattle.Interfaces;
using Database.ReadServices.MedievalBattle;

namespace Database.WriteServices.MedievalBattle
{
    public class AbstractAreaWriteService : IAbstractAreaWriteService
    {
        private readonly IAreaQueries _queries;
        public AbstractAreaWriteService(IAreaQueries queries)
        {
            _queries = queries;
        }

        public bool FillArea(int unitsAmount)
        {
            throw new System.NotImplementedException();
        }
    }
}