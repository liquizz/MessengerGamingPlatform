using Database.DTO.MedievalBattleDTO;

namespace MedievalBattle.Services.Interfaces
{
    public interface IGameControllerLogicService
    {
        public GetCoinsDTO GetCoins(int gameControllerId, int teamId);
    }
}