using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrainingSimulator.Data
{
    /*Room Layout
     *  □ x □
     *  x x x
     *  x x x
     *  □ x □  <-starting at the bottom x. □'s are blocked off.
     */

    /// <summary>
    /// This string literal will hold all of the information needed for the rooms in the training simulator.
    ///We'll be using RegEx, so keep the formatting exact! This includes whitespace in the IDE.
    ///Numbers are formatted as row,column
    /// </summary>
    public static class RoomData
    {
        private const int ROWS_OF_ROOMS = 4;
        private const int COLUMNS_OF_ROOMS = 3;
        public static Regex namesRegex = new Regex(@"{(\d+), (\d+)}, {(.+)}, {(.+)}");
        public const string data =
@"
{3, 1}, {Entrance}, {Walking in from the south door, you descend down a flight of stars to what appears to be a dingy stock room. A dim lamp swings eerily overhead.}

{2, 0}, {Wine Cellar}, {The stench of rancid fruit all but overwhelms you as you step into the barely-lit cellar, broken wine bottles littering the floor. You think you see a cockroach drunkenly skitter across the floor. Gross.}
{2, 1}, {Lounge}, {Stepping through the door, you can tell the basement used to be a rather classy place. Glass beads refract what little light comes from the chandelier, illuminating the worn furniture in the room. If you weren't on a mission, you might be tempted to take a moment to relax.}
{2, 2}, {Kitchen}, {A step through a swinging door reveals a very old but very large, and what looks to have been well-equipped kitchen, before it fell into the state of disrepair it's in now. The only thing on the pantry shelves nowadays is dust.}

{1, 0}, {Dark Room}, {You open the door to a pitch-black room, the fluorescent lights too dim to pierce through the seeming blackness. You hear rustling but it's far too dark to even make out shapes. A screech breaks the silence, and you can only guess it came from a very large rat.}
{1, 1}, {Operating Room?}, {Deeper into the basement you find fluorescent lights illuminating what seems to be a makeshift operating room, with stretchers slovenly left about and trays of surgical tools left to rust. Something tells you you should turn back while you still can.}
{1, 2}, {Office}, {You open the door to an unexpectedly opulent office. A cherry-stained desk acts as the centerpiece to the lavish space, a plush leather chair tilted away. The wallpaper looks dated, but somehow maintained. You take a look around but other than the odd cleanliness of the room, there's not even a single shred of paper to be found.}

{0, 1}, {Exit}, {You open a heavy metal door and, to your surprise, are greeted by the smoggy air of Los Angeles, but it's a welcomed change from the eery basement. You decide to give up on your search for now. Best not to tempt fate.}";
        public static int GetRowsOfRooms { get { return ROWS_OF_ROOMS; } }
        public static int GetColsOfRooms { get { return COLUMNS_OF_ROOMS; } }
    }
}
