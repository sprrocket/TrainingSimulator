using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSimulator.Data
{
    public class Room
    {
        //Variables for connected rooms; If a given direction is null, there's no room there.
        private Room north = null;
        private Room south = null;
        private Room east = null;
        private Room west = null;
        private int? row = null;
        private int? col = null;

        private bool discovered = false;
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

        public bool IsDiscovered { get { return discovered; } }
        public bool SetDiscovered { set { discovered = true; } }

        public int? GetRow { get { return row; } }
        public int? SetRow { set { row = value; } }

        public int? GetCol { get { return col; } }
        public int? SetCol { set { col = value; } }
    }
}
