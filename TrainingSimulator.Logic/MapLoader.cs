using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrainingSimulator.Data;

namespace TrainingSimulator.Logic
{
    public class MapLoader
    {
        /// <summary>
        /// Attached the information from Data.RoomData to the map
        /// </summary>
        /// <param name="match"></param>
        /// <param name="activeMap"></param>
        private static void ParseMatch(Match match, Map activeMap)
        {
            int row = Int32.Parse(match.Groups[1].Value);
            int col = Int32.Parse(match.Groups[2].Value);
            if (activeMap.GetRoom[row, col] != null)
            {
                activeMap.GetRoom[row, col].SetRow = row;
                activeMap.GetRoom[row, col].SetCol = col;
                activeMap.GetRoom[row, col].SetName = match.Groups[3].Value;
                activeMap.GetRoom[row, col].SetDescription = match.Groups[4].Value;
            }
        }

        /// <summary>
        /// Loads the Regular Expressions from the DAL and parses the 
        /// </summary>
        public static void LoadMapData()
        {
            MatchCollection matches = RoomData.namesRegex.Matches(RoomData.data);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    ParseMatch(match, GameData.GetActiveMap);
                }
            }
            GameData.GetActiveMap.GetRoom[3, 1].SetDiscovered = true;//Set the initial room to "discovered"
        }
    }
}
