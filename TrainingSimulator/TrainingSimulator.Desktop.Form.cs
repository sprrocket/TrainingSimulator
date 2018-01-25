using System.Windows.Forms;
using System.Drawing;

namespace TrainingSimulator
{
    public partial class TrainingSimulatorForm : Form
    {
        //Map map = new Map();
        //Room currentRoom = new Room();

        public TrainingSimulatorForm()
        {
            InitializeComponent();
        }

        private void TrainingSimulatorForm_Load(object sender, System.EventArgs e)
        {
            //map.LoadMapData(RoomData.data);
            CreateButtonControls();
            //currentRoom = map.roomLayout[3, 1];
            //richTextBox1.Text = currentRoom.GetDescription;



            upButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            rightButton.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            downButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipY);
        }        

        private void CreateButtonControls()
        {
            //Button[,] buttonArray = new Button[Map.ROWS_OF_ROOMS, Map.COLUMNS_OF_ROOMS];

            //for (int r = 0; r < Map.ROWS_OF_ROOMS; r++ )
            //{
            //    for(int c = 0; c < Map.COLUMNS_OF_ROOMS; c++)
            //    {
            //        buttonArray[r, c] = new Button
            //        {
            //            Dock = DockStyle.Fill,
            //            Name = "buttonArray" + r + "_" + c,
            //            BackgroundImageLayout = ImageLayout.Zoom,
            //            UseVisualStyleBackColor = true
            //        };
            //        mapPanel.Controls.Add(buttonArray[r, c], c, r);//TableLayoutPanel is x,y unlike arrays which are y,x
            //    }              
            //}
        }
        
        private void button1_Click(object sender, System.EventArgs e)
        {
            //currentRoom = map.roomLayout[0, 1];
            //richTextBox1.Text = currentRoom.GetDescription;
        }
    }
}
