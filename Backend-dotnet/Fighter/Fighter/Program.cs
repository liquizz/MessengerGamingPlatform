using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fighter.src;

namespace Fighter
{
    class Program
    {
        static int[] unitCosts = new int[1]; //стоймость ячейка в масиве соответствует id типа юнита

        static void Main(string[] args)
        {
            unitCosts[0] = 10; //это наверно должно хранитсья в базе и я хуй его как доступ получать
            BotSimulyator();
        }


        //Типы/id юнитов - Archer/0 
        static void BotSimulyator() //Херовенькая имитация работы бота для отладки
        {
            Builder kek = new Builder();
            Console.WriteLine("use auto filling? (y/n)");
            if (Console.ReadLine() == "y")
            {
                mapAutoFilling(kek);
            }
            else
            {

                int _team, fieldId, unitTypeId, unitCount;
                for (int i = 0; i < 16; i++)
                {
                    _team = i % 2;
                    if (_team == 0)
                    {
                        Console.WriteLine("team 1: ");
                    }
                    else
                    {
                        Console.WriteLine("team 2: ");
                    }
                    Console.WriteLine("coins: " + kek.GetCoins(_team));
                    Console.Write("Free Fields: ");
                    List<int> freeFields = kek.GetFreeField(_team);
                    for (int j = 0; j < freeFields.Count; j++)
                    {
                        if (j != 0)
                        {
                            Console.Write(",");
                        }
                        Console.Write(freeFields[j]);
                    }
                    Console.Write("\n");


                    Console.WriteLine("Chose field for filling: ");
                    fieldId = Convert.ToInt32(Console.ReadLine()) - 1;

                    Console.WriteLine("Units type id: \n0 - Archers");
                    Console.WriteLine("Enter unit type: ");
                    unitTypeId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("One unit this type cost - " + unitCosts[unitTypeId]);
                    Console.WriteLine("\nEnter unit count: ");
                    unitCount = Convert.ToInt32(Console.ReadLine());
                    kek.SetField(_team, unitCount, unitTypeId, fieldId, unitCosts[unitTypeId]);
                }
            }

            bool a = true;

            int team, field;

            if (a) //чисто по преколу **требует переработки** (нет я серьезно, нужно исправить)
            {
                team = Convert.ToInt32(a);
                Console.WriteLine("team 1: ");
                a = !a;
            }
            else
            {
                team = Convert.ToInt32(a);
                Console.WriteLine("team 2: ");
                a = !a;
            }

            List<int> availableFields = kek.GetAvailableField(team);
            Console.Write("Available field: ");
            for(int j = 0; j < availableFields.Count; j++)
                    {
                if (j != 0)
                {
                    Console.Write(",");
                }
                Console.Write(availableFields[j]);
            }
            Console.Write("\n");
            Console.WriteLine("Choose field: ");
            field = Convert.ToInt32(Console.ReadLine());


            Console.Write("Available actions (a): ");
            string action = Console.ReadLine();
            switch (action)
            {
                case "action":

                    break;
            }

        }

        static void mapAutoFilling(Builder kek) //для быстрой отладки
        {
            for (int team = 0; team < 2; team++) {
                for (int fieldId = 0; fieldId < 8; fieldId++) {
                    if (fieldId != 4 && fieldId != 5)
                    {
                        kek.SetField(team, 10, fieldId, 1, unitCosts[1]);
                    }
                    else
                    {
                        kek.SetField(team, 10, fieldId, 0, unitCosts[0]);
                    }
                } 
            }
        }


    }
}
