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

        public bool UpdateCoin(int value, int team)
        {
            var coin = new Coin()
            {
                TeamId = team,
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

        public bool CreateUnitArcher(int team, int unitCount, int classId, int areaId, int unitCost)
        {
            var unit = new List<Unit>(); // Is this rly empty?

            var area =  new AbstractField()
            {
                TeamId = team,
                FieldUnitCount = unitCount,
                TypeName = "Archer",
                HpPerUnit = 100,
                DamagePerUnit = 10,
                FieldArmor = 0,
                UnitSize = 1,
                Units = unit,
            };
             

            throw new System.NotImplementedException();
        }
    }
}