using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerLibrary
{
    public partial class PanelNews : UserControl
    {
        public PanelNews(string titile, string des, string linkIcon)
        {
            InitializeComponent();
            try
            {
                labelTitle.Text = titile;
                Application.DoEvents();
                labelDescription.Text = des;
                Application.DoEvents();
                pictureBox1.ImageLocation = linkIcon;
                Application.DoEvents();
                pictureBox1.BackgroundImage = pictureBox1.Image;
                Application.DoEvents();
                this.BackgroundImage = pictureBox1.Image;
                Application.DoEvents(); 
                pictureBox1.BackColor = Color.Transparent;
                Application.DoEvents();
                labelTitle.BackColor = Color.Transparent;
                Application.DoEvents();
                labelDescription.BackColor = Color.Transparent;
                Application.DoEvents();
                panel1.BackColor = Color.Transparent;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd!");
                Console.WriteLine(ex.ToString());
            }
            
        }


        private void PanelNews_SizeChanged(object sender, EventArgs e)
        {

        }

        private void item_Click(object sender, EventArgs e)
        {

        }
    }
}
