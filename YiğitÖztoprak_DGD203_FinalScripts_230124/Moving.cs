using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgrammingFinal
{
    public class Moving
    {
        Level level = new Level();
        List<int> player_position = new List<int> { 0, 0 };
        List<int> last_position;
        public void MoveForward()
        {
            last_position = new List<int>{(player_position[0] + 1), player_position[1] };
            if (level.CheckBorders(last_position))
            {
                Console.WriteLine("The map is finished. You can't do that!");
                return;
            }
            else
            {
                player_position = last_position;
                level.ExploreMap(player_position);
            }
        }
        public void MoveBack()
        {
            last_position = new List<int> { (player_position[0] - 1), player_position[1] };
            if (level.CheckBorders(last_position))
            {
                Console.WriteLine("The map is finished. You can't do that!");
                return;
            }
            else
            {
                player_position = last_position;
                level.ExploreMap(player_position);
            }
        }
        public void MoveRight()
        {
            last_position = new List<int> { player_position[0], player_position[1] + 1 };
            if (level.CheckBorders(last_position))
            {
                Console.WriteLine("The map is finished. You can't do that!");
                return;
            }
            else
            {
                player_position = last_position;
                level.ExploreMap(player_position);
            }
        }
        public void MoveLeft()
        {
            last_position = new List<int> { player_position[0], player_position[1] - 1 };
            if (level.CheckBorders(last_position))
            {
                Console.WriteLine("The map is finished. You can't do that!");
                return;
            }
            else
            {
                player_position = last_position;
                level.ExploreMap(player_position);
            }
        }
    }
}
