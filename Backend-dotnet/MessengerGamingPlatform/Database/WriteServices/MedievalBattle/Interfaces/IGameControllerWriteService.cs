namespace Database.WriteServices.MedievalBattle.Interfaces
{
    public interface IGameControllerWriteService
    {
        public bool FillArea(int userId, int unitsCount, int classId, int areaId, int unitCost); // SetField in original logic -> Fills user's area with unitsCount amount of units
        public bool CreateGameController(); // Initializes game (creates required fields in DB)
    }
}