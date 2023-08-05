using System.Diagnostics;

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

        private void buttonDefinitions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tool_Definitions tool_Definitions = new Tool_Definitions();
            tool_Definitions.Show();
            GC.Collect();
        }

        private void buttonPageItemData_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageItemCreator pageItemCreator = new PageItemCreator();
            pageItemCreator.Show();
        }

        private void buttonToolEpisode_Click(object sender, EventArgs e)
        {
            this.Hide();
            ToolEpisode toolEpisode = new ToolEpisode();
            toolEpisode.Show();
            GC.Collect();
        }

        private void buttonSendFileToDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/C start \"\" https://discord.gg/YpwXkPyyc3 ");
        }
    }
}