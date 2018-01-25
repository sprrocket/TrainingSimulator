using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TrainingSimulator.Data
{
    public class Map
    {
        public string[,] roomName;
        public string[,] roomDescription;

        private Room[,] roomGrid =
        {
            {null, new Room(), null },
            {new Room(), new Room(), new Room()},
            {new Room(), new Room(), new Room()},
            {null, new Room(), null }
        };

        public Map()//Inits the map and begins populating the necessary information for each room
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

        private Room FetchRoom(int r, int c)
        {
            if (r >= 0 && r < RoomData.GetRowsOfRooms && c >= 0 && c < RoomData.GetColsOfRooms)
            {
                return roomGrid[r, c];
            }
            else return null;
        }

        public Room[,] GetRoom { get { return roomGrid; } }

    }
}