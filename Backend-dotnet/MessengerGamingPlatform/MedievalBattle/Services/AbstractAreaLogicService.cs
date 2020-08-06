using Database.ReadServices.MedievalBattle;
using Database.WriteServices.MedievalBattle.Interfaces;
using MedievalBattle.Services.Interfaces;
using MedievalBattle.Logic;

namespace MedievalBattle.Services
{
    public class AbstractAreaLogicService : IAbstractAreaLogicService
    {
        private readonly IAreaQueries _queries;
        private readonly IAbstractAreaRepository _repository;
        public AbstractAreaLogicService(IAreaQueries queries, IAbstractAreaRepository repository)
        {
            _queries = queries;
            _repository = repository;
        }

        public bool FillArea(int unitsAmount, int areaId)
        {
            var area = _queries.GetAreaByAreaId(areaId);
            var logic = new AbstractAreaLogic();

            var fillFieldResult = logic.FillArea(area, unitsAmount);

            if (fillFieldResult != null)
            {
                _repository.UpdateAbstractAreaCounters(areaId, fillFieldResult.AliveUnitCount,
                    fillFieldResult.DeadUnitCount);

                foreach (var unit in fillFieldResult.Units)
                {
                    _repository.CreateUnit(unit);
                }

                return true;
            }

            return false;
        }
    }
}