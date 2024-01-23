using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingFinal
{
    class Level
    {
        private string currentRiddle = "What goes up and down but doesn’t move?";
        List<int> enemy_point = new List<int> { 2, 2 };
        List<int> special_item1_point = new List<int> { 0, -1 };
       
        private string correctAnswer = "Staircase";
        private int specialItemCount;
        List<int> map_length = new List<int> { -2, 2 };
        List<int> start_point = new List<int> { 0, 0 };
        private int tryAmount = 2;

        List<int> map_width = new List<int> { -2, 2 };
        private List<string> answerChoices = new List<string>() { "Cup", "Shadow", "Life", "Staircase", "Baloon" };
        List<int> clue1_point = new List<int> { 1, 1 };
        List<int> clue2_point = new List<int> { -1, -2 };

        public void ExploreMap(List<int> currentPosition)
        {
            if (currentPosition[0] == start_point[0] && currentPosition[1] == start_point[1])
            {
                Console.WriteLine("You find yourself at where you began!");
            }
            else if (currentPosition[0] == enemy_point[0] && currentPosition[1] == enemy_point[1])
            {
                Console.WriteLine($"Hey, I have a riddle for you. Answer correctly or face the consequences!");
                Console.WriteLine(currentRiddle);
                DisplayChoices();
                if (specialItemCount > 0) Console.WriteLine("You are using the item and it whispers: " + correctAnswer);
                VerifyAnswer();
            }
            else if (currentPosition[0] == special_item1_point[0] && currentPosition[1] == special_item1_point[1])
            {
                Console.WriteLine("You find a book in front of the window. Keep it anyway!");
                specialItemCount++;
            }
            else if (currentPosition[0] == clue1_point[0] && currentPosition[1] == clue1_point[1])
            {
                Console.WriteLine("This part of the room is a little bit high and you can see the rest.");
            }
            else if (currentPosition[0] == clue2_point[0] && currentPosition[1] == clue2_point[1])
            {
                Console.WriteLine("You heard some sounds coming from the upside of the room.");
            }
            else
            {
                Console.WriteLine("You see nothing around here.");
            }
        }

        public bool CheckBorders(List<int> player_position)
        {
            return player_position[0] < map_width[0] || player_position[0] > map_width[1] ||
                player_position[1] < map_length[0] || player_position[1] > map_length[1];
        }

        private void VerifyAnswer()
        {
            var userAnswer = Console.ReadLine();
            if (userAnswer == correctAnswer || userAnswer == correctAnswer.ToLower())
            {
                Console.WriteLine("Your answer is true! You finished the game.");
                Program.game_finished = true;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer is incorrect!");

                if (tryAmount > 1)
                {
                    tryAmount--;
                    Console.WriteLine("You are about to die! Try again!");
                    VerifyAnswer();
                }
                else
                {
                    Console.WriteLine("You Lost!");
                    Program.game_finished = true;
                    Console.ReadLine();
                }
                
            }
        }

        private void DisplayChoices()
        {
            Console.WriteLine("Choices: ");
            foreach (string choice in answerChoices)
            {
                Console.WriteLine(choice);
            }
            Console.WriteLine("Choose one !");
        }
    }
}

