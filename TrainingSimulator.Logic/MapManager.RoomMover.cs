using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingSimulator.Data;

namespace TrainingSimulator.Logic
{
    public partial class MapManager
    {
        public static BlockedCell notBlockedCell = new BlockedCell(){ IsBlocked = null, Column = null, Row = null };

        /// <summary>
        /// Determines if the currently selected Room is next to a blocked cell
        /// </summary>
        /// <param name="oldR"></param>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static bool IsNextToBlockedCell(Room oldR, char dir)
        {
            return (oldR.GetRow > 0 && dir == 'N' || oldR.GetRow < RoomData.GetRowsOfRooms - 1 && dir == 'S' ||
                oldR.GetCol < RoomData.GetColsOfRooms - 1 && dir == 'E' || oldR.GetCol > 0 && dir == 'W');
        }

        /// <summary>
        /// Handles the actual movement of updating the current room.
        /// </summary>
        /// <param name="newR"></param>
        /// <param name="oldR"></param>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static BlockedCell RoomUpdater(Room newR, Room oldR, char dir)
        {
            if (newR != null)
            {
                SetNewRoom(newR);
                return notBlockedCell;
            }
            int moveN = 0; int moveS = 0; int moveE = 0; int moveW = 0;
            switch (dir) {  case 'N': moveN = 1; break;
                            case 'S': moveS = 1; break;
                            case 'E': moveE = 1; break;
                            case 'W': moveW = 1; break; }            
            if (IsNextToBlockedCell(oldR, dir))
                return new BlockedCell() {
                    IsBlocked = true,
                    Row = oldR.GetRow - moveN + moveS,
                    Column = oldR.GetCol - moveW + moveE };
            else return notBlockedCell;
        }


        // REQ: switch statement
        /// <summary>
        /// Every time a directional button is pressed, the button's events are sent to this function
        /// to be sorted through to make sure the graphical map lines up with the one we have in memory.
        /// This has a very long switch statement in it. I'm so sorry.
        /// </summary>
        public static BlockedCell BlockedCellFinder(object sender)
        {
            Room r = GameData.GetCurrentRoom;
            switch ((sender as Button).Name)
            {
                case "northBtn":
                    return RoomUpdater(r.GetNorth, r, 'N');
                case "southBtn":
                    return RoomUpdater(r.GetSouth, r, 'S');
                case "eastBtn":
                    return RoomUpdater(r.GetEast, r, 'E');
                case "westBtn":
                    return RoomUpdater(r.GetWest, r, 'W');
                default://this should never happen
                    return notBlockedCell;
            }
        }
    }
}
