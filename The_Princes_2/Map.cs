using System;
using System.Collections.Generic;
using System.Text;

namespace The_Princes_2
{
    class Map
    {

        int [,] cell = new int[10,10];
        public void CreateMapAndGenerateMines(Player player)
        {
            Random random = new Random();            

            for (int i = 0; i < 10; i++)
            {
                int j = random.Next(0,9);
                cell[i, j] = random.Next(1,10);
            }
        }

        public int ChekMines(Player player)
        {
            Mine mine = new Mine(0);
            if (player.CoordX == 9 && player.CoordY == 9) 
            {
                player.TheWin(); return 0; 
            }            
            if (cell[player.CoordX,player.CoordY] == 0)
            {
                return 0; 
            }           
            if (cell[player.CoordX,player.CoordY] != 0)
            {
               return player.Hp - cell[player.CoordX, player.CoordY];                
            }
            else
            {
                return 0; 
            }
        }

        public void DrawMap(Player player)
        {
            Mine mine = new Mine(0);
            Console.Clear();
            Picteres picteres = new Picteres();            
            
            for (int i = 0; i < cell.Length; i++)
            {
                picteres.PaintLine(i);   
                for (int o = 0; o < cell.Length; o++)
                {
                    if (i == player.CoordX && o == player.CoordY)
                    {
                        picteres.PaintPlayer(); 
                    }
                    else if (cell[i, o] == 0) 
                    { 
                        picteres.PaintEmptyCell();
                    }
                    else if (cell[i, o] != 0)
                    {
                        picteres.PaintMineCell(cell[i,o]);
                    }
                }
                Console.WriteLine();
            }
            picteres.PaintLine(10);
        }
    
    }
}
