using System.Collections.Generic;
using Database.DTO.MedievalBattleDTO;
using Database.Models.MedievalBattleModels;
using Database.ReadServices.MedievalBattle;
using Database.WriteServices.MedievalBattle.Interfaces;
using MedievalBattle.Logic;
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

        public GetEnemyTeamIdDTO GetEnemyTeamId(int teamId, int gameControllerId)
        {
            return _queries.GetEnemyTeamId(teamId, gameControllerId);
        }

        public object SetArea(int teamId, int unitCount, int classId, int areaId, int unitCost)
        {
            var logic = new GameControllerLogic();
            var gameControllerId = _queries.GetGameControllerId(teamId).GameControllerId;
            var gameController = _queries.GetGameController(gameControllerId); // redundant using of queries
            var coins = GetCoins(gameControllerId, teamId);
            var enemyAreas = _queries.GetEnemyAreas(teamId, gameControllerId);

            var setAreaResult = logic.SetArea(teamId, unitCount, classId, areaId, unitCost, coins, gameController,
                enemyAreas);

            _repository.UpdateCoin(teamId, setAreaResult.CoinsValue);
            _repository.AreaUpdate(areaId, setAreaResult); 
            // TODO: Think about merging AreaUpdate and UpdateCoin methods
            return true;
        }
    }
}