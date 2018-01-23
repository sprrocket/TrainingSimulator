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

        private Regex namesRegex = new Regex(@"{(\d+), (\d+)}, {(.+)}, {(.+)}");
        public string[,] roomName;
        public string[,] roomDescription;


        public Room[,] roomLayout =
        {
            {null, new Room(), null },
            {new Room(), new Room(), new Room()},
            {new Room(), new Room(), new Room()},
            {null, new Room(), null }
        };

        public const int ROWS_OF_ROOMS = 3;
        public const int COLUMNS_OF_ROOMS = 2;

        public Map()//Inits the map and begins populating the necessary information for each room
        {
            for(int r=0; r < ROWS_OF_ROOMS; r++)
            {
                for(int c=0; c< COLUMNS_OF_ROOMS; c++)
                {
                    if (roomLayout[r, c] != null) {
                        roomLayout[r, c].ConnectRooms(FetchRoom(r - 1, c), FetchRoom(r + 1, c),
                                                      FetchRoom(r, c + 1), FetchRoom(r, c - 1));
                    }
                }
            }
        }

        public void LoadMapData(string roomData)
        {
            MatchCollection matches = namesRegex.Matches(roomData);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    ProcessMatch(match);
                }
            }

        }

        private void ProcessMatch(Match match)
        {
            int row = Int32.Parse(match.Groups[1].Value);
            int col = Int32.Parse(match.Groups[2].Value);
            roomLayout[row, col].SetName = match.Groups[3].Value;
            roomLayout[row,col].SetDescription = match.Groups[4].Value;
        }

        private Room FetchRoom(int r, int c)
        {
            if (r >= 0 && r < ROWS_OF_ROOMS && c >= 0 && c < COLUMNS_OF_ROOMS)
            {
                return roomLayout[r, c];
            }
            else return null;
        }
    }

    public class Room
    {
        //Variables for connected rooms; If a given direction is null, there's no room there.
        private Room north = null;
        private Room south = null;
        private Room east = null;
        private Room west = null;

        private String name = null;

        private String description = null;

        public Room() { }//default constructor

        public Room(String _name, String _description)//Constructs rooms without connecting them
        {
            this.name = _name;
            this.description = _description;
        }

        public Room(String _name, String _description, Room _north, Room _south, Room _east, Room _west)//Constructs rooms with connections
        {
            ConnectRooms(_north, _south, _east, _west);
        }

        public void ConnectRooms(Room _north, Room _south, Room _east, Room _west)//Connects the rooms
        {
            this.north = _north;
            this.south = _south;
            this.east = _east;
            this.west = _west;
        }

        //Get/Set... GO!
        public Room GetNorth { get { return north; } }
        public Room SetNorth { set { north = value; } }

        public Room GetSouth { get { return south; } }
        public Room SetSouth { set { south = value; } }

        public Room GetEast { get { return east; } }
        public Room SetEast { set { east = value; } }

        public Room GetWest { get { return west; } }
        public Room SetWest { set { west = value; } }

        public String GetName { get { return name; } }
        public String SetName { set { name = value; } }

        public String GetDescription { get { return description; } }
        public String SetDescription { set { description = value; } }

    }
    /*Room Layout
     *  □ x □
     *  x x x
     *  x x x
     *  □ x □  <-starting at the bottom x. □'s are blocked off.
     */

    public static class RoomData
    {
        public const string data =
@"This string literal will hold all of the information needed for the rooms in the training simulator.
We'll be using RegEx, so keep the formatting exact! This includes whitespace in the IDE.
{3, 1}, {Entrance}, {Walking in from the south door, you descend down a flight of stars to what appears to be a dingy stock room. A dim lamp swings eerily overhead.}
{2, 0}, {Wine Cellar}, {The stench of rancid fruit all but overwhelms you as you step into the barely-lit cellar, broken wine bottles littering the floor. You think you see a cockroach drunkenly skitter across the floor. Gross.}
{2, 1}, {Lounge}, {Stepping through the door, you can tell the basement used to be a rather classy place. Glass beads refract what little light comes from the chandelier, illuminating the worn furniture in the room. If you weren't on a mission, you might be tempted to take a moment to relax.}
{2, 2}, {Kitchen}, {A step through a swinging door reveals a very old but very large, and what looks to have been well-equipped kitchen, before it fell into the state of disrepair it's in now. The only thing on the pantry shelves nowadays is dust.}
{1, 0}, {Dark Room}, {You open the door to a pitch-black room, the fluorescent lights too dim to pierce through the seeming blackness. You hear rustling but it's far too dark to even make out shapes. A screech breaks the silence, and you can only guess it came from a very large rat.}
{1, 1}, {Operating Room?}, {Deeper into the basement you find fluorescent lights illuminating what seems to be a makeshift operating room, with stretchers slovenly left about and trays of surgical tools left to rust. Something tells you you should turn back while you still can.}
{1, 2}, {Office}, {You open the door to an unexpectedly opulent office. A cherry-stained desk acts as the centerpiece to the lavish space, a plush leather chair tilted away. The wallpaper looks dated, but somehow maintained. You take a look around but other than the odd cleanliness of the room, there's not even a single shred of paper to be found.}
{0, 1}, {Exit}, {You open a heavy metal door and, to your surprise, are greeted by the smoggy air of Los Angeles, but it's a welcomed change from the eery basement. You decide to give up on your search for now. Best not to tempt fate.}";
    }
}
