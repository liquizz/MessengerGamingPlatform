using System.Collections.Generic;
using Database.DTO.MedievalBattleDTO;

namespace Database.ReadServices.MedievalBattle
{
    public interface IAreaReadService
    {
        public List<GetAreaByUserIdDTO> GetAreasByUserId(int userId);
        public GetUnitsAliveCountDTO GetUnitsAliveCount(int areaId);
        public GetUnitsDeadCountDTO GetUnitsDeadCount(int areaId);
    }
}