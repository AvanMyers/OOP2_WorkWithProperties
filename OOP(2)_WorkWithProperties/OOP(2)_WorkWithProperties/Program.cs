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

            render.DrawPlayer(player.PositionX, player.PositionY);
            Console.ReadKey();
        }
    }

    class Renderer
    {
        public void DrawPlayer(int playerX, int playerY, char symbol = '+')
        {
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(symbol);
        }
    }

    class Player
    {
        public int PositionX { get; private set; }

        public int PositionY { get; private set; }

        public Player(int playerPositionX, int playerPositionY)
        {
            PositionX = playerPositionX;
            PositionY = playerPositionY;
        }
        
    }
}
