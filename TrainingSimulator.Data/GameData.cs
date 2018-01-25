using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSimulator.Data
{
    public static class GameData
    {
        private static Map activeMap = new Map();

        private static Room[,] roomGrid = activeMap.GetRoom;

        private static Room currentRoom = roomGrid[3, 1];
        private static string RoomDescription = currentRoom.GetDescription;

        public static Map GetActiveMap { get { return activeMap; } }

        public static Room[,] GetRoomGrid { get { return roomGrid; } }
        public static Tuple<int?,int?> GetRoomLocation { get { return new Tuple<int?, int?>(currentRoom.GetRow, currentRoom.GetCol); } }
        public static Room GetCurrentRoom { get { return currentRoom; } }
        public static Room SetCurrentRoom { set { currentRoom = value; } }
    }
}
