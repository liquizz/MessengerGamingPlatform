using System.Collections.Generic;
using Database.DTO.MedievalBattleDTO;

namespace Database.ReadServices.MedievalBattle
{
    public interface IAreaQueries
    {
        public object GetAreaByAreaId(int areaId);
        public List<GetAreaByUserIdDTO> GetAreasByUserId(int userId);
        public object GetAreaState(int userId);

        // Methods required for GetUnitsState functionality
        public GetUnitsDeadCountDTO GetUnitsDeadCount(int areaId);
        public object GetUnitList(int areaId);
        public object GetAreaSize(int areaId);
        public GetUnitsAliveCountDTO GetUnitsAliveCount(int areaId);
        public object GetDamagePerUnit(int areaId);
        public object GetTypeName(int areaId);

        // Methods required for Fighter(Warrior) model implementation
    }
}