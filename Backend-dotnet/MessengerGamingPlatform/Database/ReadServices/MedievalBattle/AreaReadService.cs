using Database.DTO.MedievalBattleDTO;
using System.Collections.Generic;

namespace Database.ReadServices.MedievalBattle
{
    public class AreaReadService : IAreaReadService
    {
        private readonly IAreaQueries _queries;

        public AreaReadService(IAreaQueries queries)
        {
            _queries = queries;
        }

        public List<GetAreaByUserIdDTO> GetAreasByUserId(int userId)
        {
            return _queries.GetAreasByUserId(userId);
        }

        public GetUnitsAliveCountDTO GetUnitsAliveCount(int areaId)
        {
            return _queries.GetUnitsAliveCount(areaId);
        }

        public GetUnitsDeadCountDTO GetUnitsDeadCount(int areaId)
        {
            return _queries.GetUnitsDeadCount(areaId);
        }
    }
}