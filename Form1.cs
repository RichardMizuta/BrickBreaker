using System.Numerics;

namespace BrickBreaker
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }
        private void B_Shokyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main();
            fMain.Show();
            Hide();
        }
        private void B_Chukyu_Click(object sender, EventArgs e)
        {

        }
        private void B_Jyokyu_Click(object sender, EventArgs e)
        {

        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Owner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }
    }
}