using System;
using System.Collections.Generic;
using System.Text;

namespace The_Princes_2
{
    class Player
    {
        public int Hp { get; private set; }
        public int CoordX { get; private set; }
        public int CoordY { get; private set; }

        public void TheWin()
        {
            Console.WriteLine("You are win!!!");
        }
        public void StartPosition()
        {
            CoordX = 0;
            CoordY = 0;
            Hp = 10;
        }

        public void PlayerRunUp(Map map)
        {
           
            if (CoordX == 0) { return; }

            CoordX -= 1;
            int damage = map.ChekMines(this);
            Hp -= damage;                     
            map.DrawMap(this);
        }
        public void PlayerRunDown(Map map)
        {
            if (CoordX == 9) { return; }

            CoordX += 1;
            int damage = map.ChekMines(this); 
            Hp -= damage;                     
            map.DrawMap(this);
        }
        public void PlayerRunRight(Map map)
        {
            if (CoordY == 9) { return; }

            CoordY += 1;
            int damage = map.ChekMines(this); 
            Hp -= damage;                     
            map.DrawMap(this);
        }
        public void PlayerRunLeft(Map map)
        {
            
            if (CoordY == 0) { return; }

            CoordY -= 1;
            int damage = map.ChekMines(this); 
            Hp -= damage;                     
            map.DrawMap(this);
        }

        public Player()
        {
            Hp = 10;
            CoordX = 0;
            CoordY = 0;
        }

    }
}
