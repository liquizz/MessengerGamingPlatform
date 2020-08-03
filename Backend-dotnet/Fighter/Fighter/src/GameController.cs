using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Fighter.src
{
    class GameController
    {
        public List<AbstractField>[] Teams = new List<AbstractField>[2];
        int[] coins = new int[2] { 2500, 2500 };
        int[] availableFieldsCount = new int[2] {8, 8};
        bool gameAvailable = true;
        int defeatTeam;
        int turn = 0;

        public GameController()
        {
            for (int j = 0; j < 2; j++)
            {
                Teams[j] = new List<AbstractField>();
                for (int i = 0; i < 8; i++)
                {
                    Teams[j].Add(null);
                }
            }
        }


        public bool SetField(int team, int count, int classId, int fieldId, int unitCost) //Заполняет ячейку операясь на данные возвращенные ботом
        {

            switch (classId)
            {
                case 0:

                    if (coins[team] < unitCost * count)
                    {
                        return false;
                    }
                    else
                    {
                        coins[team] -= unitCost * count;
                        Teams[team][fieldId] = new Archer(count, team, fieldId, Teams[(team == 1) ? 0 : 1 /*это вражеская команда*/], this);
                        return true;
                    }
                case 1:
                    if (coins[team] < unitCost * count)
                    {
                        return false;
                    }
                    else
                    {
                        coins[team] -= unitCost * count;
                        Teams[team][fieldId] = new Warrior(count, team, fieldId, Teams[(team == 1) ? 0 : 1 /*это вражеская команда*/], this);
                        return true;
                    }

            }
            return false;
        }

        public string GetMapState() //отдает строку состояниия карты (ячейка - тип юнита) нужно для выведения пользователю
        {
            string map = "";
            for (int i = 0; i < 2; i++)
            {
                map += "team" + (i + 1) + ": ";
                for (int j = 0; j < 8; j++)
                {
                    string state = "";
                    if (Teams[j][i] != null)
                    {
                        state += Teams[j][i].GetType();
                    }
                    else
                    {
                        state += "void";
                    }
                    map += ((j + 1) + ":" + state + ";");
                }
                map += "_";
            }
            return map;
        } 

        public List<int> GetFreeField(int team) //Показывает свободные ячеки указанной команды (для стадии выбора)
        {
            List<int> ids = new List<int>();
            for(int i = 0; i < 8; i++)
            {
                if (Teams[team][i] == null)
                {
                    ids.Add(i + 1);
                }
            }
            return ids;
        }

        public List<int> GetAvailableField(int team) //Показывает свободные ячеки указанной команды (для стадии выбора)
        // !нужно кардинально переработать!
        {
            List<int> ids = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                if (Teams[team][i] != null)
                {
                    ids.Add(i + 1);
                }
            }
            return ids;
        }

        public int GetCoins (int team) //Доступные игроку коины во время стадии выбора
        {
            return coins[team];
        }

        public int GetTurn()
        {
            return turn;
        }

        public void IncTurn()
        {
            turn++;
        }

        public void RemoveField(int team, int position)
        {
            Teams[team][position] = null;
            if(--availableFieldsCount[team] == 0)
            {
                gameAvailable = false;
                defeatTeam = team;
            }
        }

        public bool GetGameAvailable()
        {
            return gameAvailable;
        }

        public int GetDefeatTeam()
        {
            return defeatTeam;
        }
    }
}
