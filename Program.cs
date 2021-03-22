using System;

namespace ConsoleApp1
{
    class Program
    {
        enum ClassType
        {
         None = 0,
         Knight = 1,
         Archer = 2,
         Mage = 3
        }

        struct Player
        {
            public int hp;
            public int attack;
          
        }

        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요!\n[1] 기사\n[2] 궁수\n[3] 법사");

            ClassType choice = ClassType.None;

            string input = Console.ReadLine();

            switch (input)

            {
                case "1":
                    choice = ClassType.Knight;
                    break;

                case "2":
                    choice = ClassType.Archer;
                    break;

                case "3":
                    choice = ClassType.Mage;
                    break;
            }
            return choice;

        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
           

            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;

                default:
                        player.hp = 0;
                        player.attack = 0;
                        break; 
            }    
        }
       
        static void Main(string[] args)
        { 
            
            while (true)
            {
               ClassType choice = ChooseClass();
                
                if (choice != ClassType.None)
                {
                    Player player;


                    CreatePlayer(choice, out player);

                    Console.WriteLine($"Hp{player.hp} Attack{player.attack}");
                }
            }
        
        
        
        }
    }
}
