using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingSimulator.Logic;

namespace TrainingSimulator
{
    partial class TrainingSimulatorForm
    {
        /// <summary>
        /// Re-uses the arrow image resource by 
        /// flipping the appropriate bitmaps on the buttons.
        /// </summary>
        private void FlipDirectionalArrows()
        {
            northBtn.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            eastBtn.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            southBtn.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
        }

        /// <summary>
        /// Instantiated seperately from the rest of the UI due to it being
        /// an array of buttons.
        /// </summary>
        private Button[,] buttonArray;

        /// <summary>
        /// Uses Buttons as a way to display a visual map.
        /// An array of buttons gives an easy interface since
        /// the data structure is an array of objects as well.
        /// </summary>
        private void CreateButtonGrid()
        {
            int rows = MapManager.GetGridRowSize;
            int cols = MapManager.GetGridColSize;
            buttonArray = new Button[rows, cols];
            for (int r = 0; r < rows; r++)// REQ: For loop. Populates the array of buttons.
            {
                for (int c = 0; c < cols; c++)
                {
                    buttonArray[r, c] = new Button
                    {
                        Dock = DockStyle.Fill,
                        Name = "buttonArray" + r + "_" + c,
                        BackgroundImageLayout = ImageLayout.Zoom,
                        UseVisualStyleBackColor = true,
                        Enabled = false
                    };
                    mapPanel.Controls.Add(buttonArray[r, c], c, r);//TableLayoutPanel is x,y unlike arrays which are y,x
                }
            }
        }

        /// <summary>
        /// Refreshes the text, title, and map
        /// </summary>
        private void RefreshDisplay()
        {
            roomNameLabel.Text = MapManager.GetCurrentRoomName;
            descriptionBox.Text = MapManager.GetCurrentRoomDescription;
            buttonArray[MapManager.GetCurrentRowNum, MapManager.GetCurrentColNum].BackgroundImage = Properties.Resources.star1;
        }

        /// <summary>
        /// Handles the event of any of the directional buttons being pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DirButtonClick(object sender, System.EventArgs e)
        {
            buttonArray[MapManager.GetCurrentRowNum, MapManager.GetCurrentColNum].BackgroundImage = null;
            Button button = sender as Button;
            var a = MapManager.BlockedCellFinder(sender);
            if (a.IsBlocked == true)// REQ: if statement
            {
                buttonArray[(int)a.Row, (int)a.Column].BackgroundImage = Properties.Resources.X;
            }
            RefreshDisplay();
        }
    }
}
