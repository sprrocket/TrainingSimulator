using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSimulator.Data
{
    public partial class Room
    {
        /// <summary>
        /// Variables for connected rooms; If a given direction is null, there's no room there.
        /// </summary>
        private Room north = null;
        private Room south = null;
        private Room east = null;
        private Room west = null;
        private int? row = null;
        private int? col = null;
        private bool discovered = false;
        private String name = null;
        private String description = null;

        /// <summary>
        /// default constructor
        /// </summary>
        public Room() { }

        /// <summary>
        /// Constructs rooms without connecting them
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_description"></param>
        public Room(String _name, String _description)
        {
            this.name = _name;
            this.description = _description;
        }

        /// <summary>
        /// Constructs rooms with connections
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_description"></param>
        /// <param name="_north"></param>
        /// <param name="_south"></param>
        /// <param name="_east"></param>
        /// <param name="_west"></param>
        public Room(String _name, String _description, Room _north, Room _south, Room _east, Room _west)
        {
            ConnectRooms(_north, _south, _east, _west);
        }

        /// <summary>
        /// Connects the rooms
        /// </summary>
        /// <param name="_north"></param>
        /// <param name="_south"></param>
        /// <param name="_east"></param>
        /// <param name="_west"></param>
        public void ConnectRooms(Room _north, Room _south, Room _east, Room _west)
        {
            this.north = _north;
            this.south = _south;
            this.east = _east;
            this.west = _west;
        }
    }
}
