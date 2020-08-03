namespace Database.ReadServices.MedievalBattle
{
    public interface IAreaQueries
    {
        public object GetAreaByAreaId(int areaId);
        public object GetAreaByUserId(int userId);
        public object GetAreaState(int userId);

        // Methods required for GetUnitsState functionality
        public object GetUnitsDeadCount(int areaId);
        public object GetUnitList(int areaId);
        public object GetAreaSize(int areaId);
        public object GetUnitsAliveCount(int areaId);
        public object GetDamagePerUnit(int areaId);
        public object GetTypeName(int areaId);

        // Methods required for Fighter(Warrior) model implementation
    }
}