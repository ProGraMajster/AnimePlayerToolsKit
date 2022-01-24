namespace AnimePlayerToolsKit
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonTAT_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitileAddTool _ = new TitileAddTool();
            _.Show();
            GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonToolNewsCreator_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tool_NewsCreator _ = new Tool_NewsCreator();
            _.Show();
            GC.Collect();
        }

        private void buttonEpCreator_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tool_EpCreator _ = new Tool_EpCreator();
            _.Show();
            GC.Collect();
        }
    }
}