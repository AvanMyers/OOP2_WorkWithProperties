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

            render.DrowPlayer(player.PlayerX, player.PlayerY);
            Console.ReadKey();
        }
    }

    class Renderer
    {
        public void DrowPlayer(int x, int y, char player = '+')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(player);
        }
    }

    class Player
    {
        public int PlayerX { get; private set; }

        public int PlayerY { get; private set; }

        public Player(int playerX, int playerY)
        {
            PlayerX = playerX;
            PlayerY = playerY;
        }
        
    }
}
