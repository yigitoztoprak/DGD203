using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingFinal
{
    public class Program
    {
        static Moving moving_class = new Moving();
        public static bool game_finished;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome The Hell Room!. You are starting a dangerous adventure." +
                "\nNever forget to look around and keep them on your mind!" +
                "\nLet's start the adventure!((Map = 5x5))");
            while (!game_finished)
            {
                GetMoveInput();
            }
        }

        static void GetMoveInput()
        {
            Console.WriteLine("You can use 'WASD' keys to move in the room!");
            string key = Console.ReadLine();
            if (key == "w" || key == "W")
            {
                moving_class.MoveForward();
            }
            else if (key == "s" || key == "S")
            {
                moving_class.MoveBack();
            }
            else if (key == "a" || key == "A")
            {
                moving_class.MoveLeft();
            }
            else if (key == "d" || key == "D")
            {
                moving_class.MoveRight();
            }
            
        }

        
    }
}
