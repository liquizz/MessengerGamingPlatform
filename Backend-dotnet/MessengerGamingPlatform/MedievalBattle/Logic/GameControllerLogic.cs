using System.Collections.Generic;
using Database.DTO.MedievalBattleDTO;
using Database.Models.MedievalBattleModels;

namespace MedievalBattle.Logic
{
    public class GameControllerLogic
    {
        // TODO: Implement write/read actions to this section

        // REQUIRED DATA: READ List<Coins> coins, WRITE List<AbstractField> Teams
        public SetAreaDTO SetArea(int teamId, int unitCount, int classId, int areaId, int unitCost, GetCoinsDTO coins, GameController controller, List<AbstractField> enemyTeams) //Заполняет ячейку операясь на данные возвращенные ботом
        {
            var dto = new SetAreaDTO()
            {
                CoinsValue = coins.Value
            };

            switch (classId)
            {
                case 0:

                    if (dto.CoinsValue < unitCost * unitCount)
                    {
                        return null;
                    }
                    else
                    {
                        var unitArcher = new Archer()
                        {
                            AbstractFieldId = areaId,
                            FieldUnitCount = unitCount,
                            Enemies = enemyTeams,
                            GameController = controller
                            // count, team, areaId, Teams[(team == 1) ? 0 : 1 /*это вражеская команда*/], this
                        };

                        dto.CoinsValue -= unitCost * unitCount;
                        dto.UnitType = "Archer";
                        dto.Units.Add(unitArcher);
                        return dto;
                    }
                case 1:
                    if (dto.CoinsValue < unitCost * unitCount)
                    {
                        return null;
                    }
                    else
                    {
                        var unitWarrior = new Fighter()
                        {
                            AbstractFieldId = areaId,
                            FieldUnitCount = unitCount,
                            Enemies = enemyTeams,
                            GameController = controller
                        };

                        dto.CoinsValue -= unitCost * unitCount;
                        dto.UnitType = "Warrior";
                        dto.Units.Add(unitWarrior);


                        // Teams[team][areaId] = new Warrior(count, team, areaId, Teams[(team == 1) ? 0 : 1 /*это вражеская команда*/], this);
                        return dto;
                    }
                default: return null;
            }
        }


        // GetMapState will be implemented in read-action form

        //public string GetMapState() //отдает строку состояниия карты (ячейка - тип юнита) нужно для выведения пользователю
        //{
        //    string map = "";
        //    for (int i = 0; i < 2; i++)
        //    {
        //        map += "team" + (i + 1) + ": ";
        //        for (int j = 0; j < 8; j++)
        //        {
        //            string state = "";
        //            if (Teams[j][i] != null)
        //            {
        //                state += Teams[j][i].GetType();
        //            }
        //            else
        //            {
        //                state += "void";
        //            }
        //            map += ((j + 1) + ":" + state + ";");
        //        }
        //        map += "_";
        //    }
        //    return map;
        //}

        //public List<int> GetAvailableField(int team) //Показывает свободные ячеки указанной команды (для стадии выбора)
        //    // !нужно кардинально переработать!
        //{
        //    List<int> ids = new List<int>();
        //    for (int i = 0; i < 8; i++)
        //    {
        //        if (Teams[team][i] != null)
        //        {
        //            ids.Add(i + 1);
        //        }
        //    }
        //    return ids;
        //}

        //public int GetCoins(int team) //Доступные игроку коины во время стадии выбора
        //{
        //    return coins[team];
        //}

        //public int GetTurn()
        //{
        //    return turn;
        //}

        //public void IncTurn()
        //{
        //    turn++;
        //}

        //public void RemoveField(int team, int position)
        //{
        //    Teams[team][position] = null;
        //    if (--availableFieldsCount[team] == 0)
        //    {
        //        gameAvailable = false;
        //        defeatTeam = team;
        //    }
        //}

        //public bool GetGameAvailable()
        //{
        //    return gameAvailable;
        //}

        //public int GetDefeatTeam()
        //{
        //    return defeatTeam;
        //}
    }
}