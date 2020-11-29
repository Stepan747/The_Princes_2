using System;

namespace The_Princes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Picteres picteres = new Picteres();
            Player player = new Player();
            Map map = new Map();
            map.CreateMapAndGenerateMines(player);
            map.DrawMap(player);
            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow: player.PlayerRunUp(map); break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow: player.PlayerRunDown(map); break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow: player.PlayerRunRight(map); break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow: player.PlayerRunLeft(map); break;
                    default: break;
                }
                if (player.Hp < 0)
                {
                    if (picteres.GameOver(1) == 0) { break; }
                    map.CreateMapAndGenerateMines(player);
                }
                else if (player.Hp > 10)
                {
                    if (picteres.GameOver(0) == 0) { break; }
                    map.CreateMapAndGenerateMines(player);
                }              
            }
        }
    }    
}
