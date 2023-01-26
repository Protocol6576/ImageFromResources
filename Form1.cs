namespace YourProjectName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            mainPictureBox.Image = YourProjectName.Properties.Resources.Raising_image;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            mainPictureBox.Image = YourProjectName.Properties.Resources.Decline_image;
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            mainPictureBox.Image = YourProjectName.Properties.Resources.Stable_image;
        }
    }
}