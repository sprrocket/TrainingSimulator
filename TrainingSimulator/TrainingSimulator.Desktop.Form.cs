using System.Drawing;
using System.Windows.Forms;
using TrainingSimulator.Logic;

namespace TrainingSimulator
{
    public partial class TrainingSimulatorForm : Form
    {
        public Button[,] buttonArray;
        //Map map = new Map();
        //Room currentRoom = new Room();

        public TrainingSimulatorForm()
        {
            InitializeComponent();
        }

        private void TrainingSimulatorForm_Load(object sender, System.EventArgs e)
        {
            MapLoader.LoadMapData();
            FlipDirectionalArrows();
            CreateMapGrid();
            RefreshDisplay();
        }

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
        

        private void CreateMapGrid()
        {
            int rows = MapManager.GetGridRowSize;
            int cols = MapManager.GetGridColSize;
            buttonArray = new Button[rows, cols];
            for (int r = 0; r < rows; r++)
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

        private void RefreshDisplay()
        {
            roomNameLabel.Text = MapManager.GetCurrentRoomName;
            descriptionBox.Text = MapManager.GetCurrentRoomDescription;
            buttonArray[MapManager.GetCurrentRowNum, MapManager.GetCurrentColNum].BackgroundImage = Properties.Resources.star1;

        }

        private void DirButtonClick(object sender, System.EventArgs e)
        {
            buttonArray[MapManager.GetCurrentRowNum, MapManager.GetCurrentColNum].BackgroundImage = null;
            Button button = sender as Button;
            var a = MapManager.MoveRooms(sender);
            if (a.Item1 == true)
            {
                buttonArray[(int)a.Item2, (int)a.Item3].BackgroundImage = Properties.Resources.X; 
            }
            RefreshDisplay();
        }
    }
}
