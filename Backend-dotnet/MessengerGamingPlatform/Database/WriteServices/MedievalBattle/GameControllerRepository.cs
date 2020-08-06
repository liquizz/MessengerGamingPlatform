using System.Collections.Generic;
using Database.Models;
using Database.Models.MedievalBattleModels;
using Database.WriteServices.MedievalBattle.Interfaces;

namespace Database.WriteServices.MedievalBattle
{
    public class GameControllerRepository : IGameControllerRepository
    {
        private readonly DatabaseContext _context;

        public GameControllerRepository()
        {
            _context = new DatabaseContext();
        }

        public bool CreateCoin(int teamId, int value)
        {
            var coin = new Coin()
            {
                TeamId = teamId,
                Value = value
            };

            _context.Coins.Add(coin);
            _context.SaveChanges();

            return true;
        }

        public bool UpdateCoin(int teamId, int value)
        {
            var coin = new Coin()
            {
                TeamId = teamId,
                Value = value
            };

            _context.Coins.Update(coin);
            _context.SaveChanges();

            return true;
        }

        public bool DeleteCoin(int coinId)
        {
            var coin = _context.Coins.Find(coinId);
            _context.Coins.Remove(coin);
            _context.SaveChanges();

            return true;
        }

        public bool CreateGameController()
        {
            throw new System.NotImplementedException();
        }

        public bool AreaUpdate()
        {
            throw new System.NotImplementedException();
        }

        public bool CreateUnit(int areaId, string unitType, int unitCount, int teamId, int positionId, GameController controller, List<AbstractField> enemiesFields)
        {
            // Testing required
            // var unit = new List<Unit>(); // Is this rly empty?
            var area = _context.AbstractFields.Find(areaId);

            if (area != null)
            {
                area.TeamId = teamId;
                area.FieldUnitCount = unitCount;
                area.TypeName = unitType;
                area.HpPerUnit = 100;
                area.DamagePerUnit = 10;
                area.FieldArmor = 0;
                area.UnitSize = 1;
                area.Enemies = enemiesFields;
                area.GameController = controller;
                area.PositionId = positionId;
                // Units = unit,

                _context.SaveChanges();

                return true;
            }

            return false;
        }
    }
}