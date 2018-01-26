using System.Drawing;
using System.Windows.Forms;
using TrainingSimulator.Logic;

namespace TrainingSimulator
{
    public partial class TrainingSimulatorForm : Form
    {
        public TrainingSimulatorForm()
        {
            InitializeComponent();
        }

        private void TrainingSimulatorForm_Load(object sender, System.EventArgs e)
        {
            MapLoader.LoadMapData();
            FlipDirectionalArrows();
            CreateButtonGrid();
            RefreshDisplay();
        }
    }
}
