using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerToolsKit
{
    public partial class Tool_NewsCreator : Form
    {
        public Tool_NewsCreator()
        {
            InitializeComponent();
            splitContainer1.Panel2Collapsed = true;
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = new Form();
                form.Show();
                AnimePlayerLibrary.PanelNews panelNews = new AnimePlayerLibrary.PanelNews(textBox_Title.Text,
                    textBox_Dis.Text, textBox_LinkImage.Text);
                panelNews.Show();
                panelNews.Dock = DockStyle.Fill;
                form.Controls.Add(panelNews);
                form.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Tool_NewsCreator_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.OpenForms[0].Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
