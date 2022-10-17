using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2__WorkWithProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer render = new Renderer();
            Player player = new Player(10, 10);

            render.DrowPlayer(player.PositionX, player.PositionY);
            Console.ReadKey();
        }
    }

    class Renderer
    {
        public void DrowPlayer(int x, int y, char simbol = '+')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simbol);
        }
    }

    class Player
    {
        public int PositionX { get; private set; }

        public int PositionY { get; private set; }

        public Player(int playerX, int playerY)
        {
            PositionX = playerX;
            PositionY = playerY;
        }
        
    }
}
