namespace Tyuiu.GamaleevaYuA.Sprint7.Project.V11
{
    public partial class FormMain_GYA : Form
    {
        public FormMain_GYA()
        {
            InitializeComponent();

        }

        private void pictureBoxTools_GYA_Click(object sender, EventArgs e)
        {
            panelToolbar_GYA.Size = new System.Drawing.Size(200, 451);
        }

        private void pictureBoxTools_GYA_DoubleClick(object sender, EventArgs e)
        {
            panelToolbar_GYA.Size = new System.Drawing.Size(21, 451);
        }

        private void pictureBoxTools_GYA_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxTools_GYA.Cursor = Cursors.Hand;
        }
    }
}
