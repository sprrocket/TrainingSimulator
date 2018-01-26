using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSimulator.Data
{
    public partial class Room
    {
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
