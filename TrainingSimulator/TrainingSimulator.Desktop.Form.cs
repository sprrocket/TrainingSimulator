using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingSimulator.Data;

namespace TrainingSimulator
{
    public partial class TrainingSimulatorForm : Form
    {
        public TrainingSimulatorForm()
        {
            InitializeComponent();
            TrainingSimulator.Data.Map map = new Map();
            map.LoadMapData(TrainingSimulator.Data.RoomData.data);
            Room currentRoom = map.roomLayout[3, 1];
            richTextBox1.Text = map.roomLayout[3, 1].GetDescription;
            mapGrid10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            
            mapGrid10.BackgroundImage = global::TrainingSimulator.Properties.Resources.star1;
            mapGrid10.BackgroundImage = null;
            
        }

        private void mapPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
