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
    public class MapManager
    {
        public static int GetGridRowSize{ get { return RoomData.GetRowsOfRooms; } }
        public static int GetGridColSize{ get { return RoomData.GetColsOfRooms; } }
        public static string GetCurrentRoomName { get { return GameData.GetCurrentRoom.GetName; } }
        public static string GetCurrentRoomDescription { get { return GameData.GetCurrentRoom.GetDescription; } }
        public static int GetCurrentRowNum { get { return (int)GameData.GetCurrentRoom.GetRow; } }
        public static int GetCurrentColNum { get { return (int)GameData.GetCurrentRoom.GetCol; } }        

        private static void SetNewRoom(Room newRoom) { GameData.SetCurrentRoom = newRoom; }
        // REQ: switch statement
        /// <summary>
        /// This has a very long switch statement in it. I'm so sorry.
        /// </summary>
        public static Tuple<bool?, int?, int?> MoveRooms(object sender)
        {
            var emptyTuple = new Tuple<bool?, int?,int?>(null, null, null);
            var cr = GameData.GetCurrentRoom;
            switch ((sender as Button).Name)
            {
                case "northBtn":
                    if (cr.GetNorth != null){// REQ: if /else if/else statement
                        SetNewRoom(cr.GetNorth);
                        return emptyTuple;
                    }
                    else if (cr.GetRow > 0)
                        return new Tuple<bool?, int?, int?>(true, cr.GetRow -1, cr.GetCol);
                    else return emptyTuple;
                case "southBtn":
                    if (cr.GetSouth != null)
                    { SetNewRoom(cr.GetSouth);
                        return emptyTuple;
                    }
                    else if (cr.GetRow < RoomData.GetRowsOfRooms-1)
                        return new Tuple<bool?, int?, int?>(true, cr.GetRow + 1, cr.GetCol);
                    else return emptyTuple;
                case "eastBtn":
                    if (cr.GetEast != null)
                    { SetNewRoom(cr.GetEast);
                        return emptyTuple;
                    }
                    else if (cr.GetCol < RoomData.GetColsOfRooms - 1)
                        return new Tuple<bool?, int?, int?>(true, cr.GetRow, cr.GetCol + 1);
                    return emptyTuple;
                case "westBtn":
                    if (cr.GetWest != null)
                    {
                        SetNewRoom(cr.GetWest);
                        return emptyTuple;
                    }
                    else if (cr.GetCol >0 )
                        return new Tuple<bool?, int?, int?>(true, cr.GetRow, cr.GetCol-1);
                    else return emptyTuple;
            }
            return emptyTuple;
        }

        public static bool CheckIfAllRoomsVisited()
        {
            for(int r= 0; r<RoomData.GetRowsOfRooms; r++)
            {
                for(int c=0; c<RoomData.GetColsOfRooms; c++)
                {
                    if((GameData.GetActiveMap.GetRoom[r,c] !=null) && GameData.GetActiveMap.GetRoom[r,c].IsDiscovered)
                        return false;
                }
            }
            return true;
        }

        
    }
}
