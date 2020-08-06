using System.Collections.Generic;
using Database.DTO.MedievalBattleDTO;
using Database.Models.MedievalBattleModels;
using Database.ReadServices.MedievalBattle;
using Database.WriteServices.MedievalBattle.Interfaces;
using MedievalBattle.Services.Interfaces;

namespace MedievalBattle.Services
{
    public class GameControllerLogicService : IGameControllerLogicService
    {
        private readonly IGameControllerReadQueries _queries;
        private readonly IGameControllerRepository _repository;

        public GameControllerLogicService(IGameControllerReadQueries queries, IGameControllerRepository repository)
        {
            _queries = queries;
            _repository = repository;
        }

        public GetCoinsDTO GetCoins(int gameControllerId, int teamId)
        {
            return _queries.GetCoins(gameControllerId, teamId);
        }

        public bool UpdateCoin(int teamId, int value)
        {
            return _repository.UpdateCoin(teamId, value);
        }

        public bool CreateUnit(int areaId, string unitType, int unitCount, int teamId, int positionId,
            GameController controller, List<AbstractField> enemiesFields)
        {
            return _repository.CreateUnit(areaId, unitType, unitCount, teamId, positionId, controller, enemiesFields);
        }

        public object GetEnemyUserId()
        {
            return null;
        }
    }
}