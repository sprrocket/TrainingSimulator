using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TrainingSimulator.Data
{
    /// <summary>
    /// Acts as a virtual layout for the Rooms.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// The hard-coded layout of the rooms
        /// </summary>
        private Room[,] roomGrid =
        {
            {null, new Room(), null },
            {new Room(), new Room(), new Room()},
            {new Room(), new Room(), new Room()},
            {null, new Room(), null }
        };

        /// <summary>
        /// Inits the Map and connects the rooms that exist together
        /// </summary>
        public Map()
        {
            for (int r = 0; r < RoomData.GetRowsOfRooms; r++)
            {
                for (int c = 0; c < RoomData.GetColsOfRooms; c++)
                {
                    if (roomGrid[r, c] != null)
                    {
                        roomGrid[r, c].ConnectRooms(FetchRoom(r - 1, c), FetchRoom(r + 1, c),
                                                      FetchRoom(r, c + 1), FetchRoom(r, c - 1));
                    }
                }
            }
        }

        /// <summary>
        /// Used by Map() to connect rooms
        /// </summary>
        /// <param name="r">row</param>
        /// <param name="c">column</param>
        /// <returns></returns>
        private Room FetchRoom(int r, int c)
        {   //REQ: if/else statement
            if (r >= 0 && r < RoomData.GetRowsOfRooms && c >= 0 && c < RoomData.GetColsOfRooms)
            {
                return roomGrid[r, c];
            }
            else return null;
        }

        public Room[,] GetRoom { get { return roomGrid; } }
    }
}