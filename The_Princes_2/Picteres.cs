using System;
using System.Collections.Generic;
using System.Text;

namespace The_Princes_2
{
    class Picteres
    {
        public int GameOver(int result)
        {
            if (result == 0) 
            {
                Console.WriteLine("Вы выиграли!!"); 
            }
            else 
            {
                Console.WriteLine("Вы проиграли.");
            }
            Console.WriteLine("Не желаете повторить -> y? \n");
            if (Console.ReadLine() == "y")
            { 
                return 1; 
            }
            else
            {
                return 0;
            }
        }

        public void PaintLine(int line)
        {
            Console.WriteLine("__________________________");
            if (line < 10) { Console.Write("|"); }
        }
        public void WriteGameName()
        {
            Console.WriteLine("The Princess game!");
        }

        public void PaintPlayer()
        {
            Console.Write("|P|");
        }       

        public void PaintMineCell(int big)
        {
            if (big == 0) { Console.Write("| |"); }
            else { Console.Write("|X|"); }
        }
        public void PaintEmptyCell()
        {
            Console.Write("| |");
        }

        public void WriteHP(Player player)
        {
            Console.WriteLine($"HP {player.Hp}");
        }

        
    }
}
