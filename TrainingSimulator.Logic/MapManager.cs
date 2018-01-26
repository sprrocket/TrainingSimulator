using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingSimulator.Data;
using TrainingSimulator;

namespace TrainingSimulator.Logic
{
    /// <summary>
    /// Getters 'n Setters for the Map Manager
    /// </summary>
    public partial class MapManager
    {
        public static int GetGridRowSize{ get { return RoomData.GetRowsOfRooms; } }
        public static int GetGridColSize{ get { return RoomData.GetColsOfRooms; } }
        public static string GetCurrentRoomName { get { return GameData.GetCurrentRoom.GetName; } }
        public static string GetCurrentRoomDescription { get { return GameData.GetCurrentRoom.GetDescription; } }
        public static int GetCurrentRowNum { get { return (int)GameData.GetCurrentRoom.GetRow; } }
        public static int GetCurrentColNum { get { return (int)GameData.GetCurrentRoom.GetCol; } }        

        /// <summary>
        /// A "setter" for the Current room, since it's a bit cumbersome to type out every time.
        /// </summary>
        /// <param name="newRoom"></param>
        private static void SetNewRoom(Room newRoom) { GameData.SetCurrentRoom = newRoom; }               
    }
}
