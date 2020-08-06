namespace Database.WriteServices.MedievalBattle.Interfaces
{
    public interface IGameControllerRepository
    {
        public bool CreateCoin(int teamId, int value);
        public bool UpdateCoin(int teamId, int value);
        public bool DeleteCoin(int teamId);
        public bool CreateGameController(); // Initializes game (creates required fields in DB)
        public bool AreaUpdate();
        public bool CreateUnitArcher(int team, int unitCount, int classId, int areaId, int unitCost);
    }
}