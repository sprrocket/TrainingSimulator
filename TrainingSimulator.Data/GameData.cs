using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSimulator.Data
{
    /// <summary>
    /// Holds the actively used information during runtime
    /// </summary>
    public static class GameData
    {
        private static Map activeMap = new Map();
        private static Room[,] roomGrid = activeMap.GetRoom;
        private static Room currentRoom = roomGrid[3, 1];//3,1 is where the player begins

        public static Map GetActiveMap { get { return activeMap; } }
        public static Room GetCurrentRoom { get { return currentRoom; } }
        public static Room SetCurrentRoom { set { currentRoom = value; } }
    }
}
