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
    public partial class TitileAddTool : Form
    {
        public TitileAddTool()
        {
            InitializeComponent();
            panelEp1.Show();
            panelEp1.BringToFront();
        }

        private void TitileAddTool_FormClosed(object sender, FormClosedEventArgs e)
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

        private void buttonBackToStarterform_Click(object sender, EventArgs e)
        {
            try
            {
                Application.OpenForms[0].Show();
                Hide();
                Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonEp1ShowMoreSetting_Click(object sender, EventArgs e)
        {
            
            panelEp1MoreSetting.Visible = !panelEp1MoreSetting.Visible;
        }

        private void buttonEndEp1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_title.Text.Length == 0)
                {
                    MessageBox.Show("Nie podano tytułu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = textBox_title.Text;
                string ico = "null;";
                if (textBox_iconlink.Text.Length == 0)
                {
                    ico = "null;";
                }
                else
                {
                    ico = textBox_iconlink.Text + ";";
                }

                string link = "null;";
                if (textBox_sitelink.Text.Length == 0)
                {
                    link = "null;";
                }
                else
                {
                    link = textBox_sitelink.Text + ";";
                }

                string conId = "null;";
                if (textBox_contentId.Text.Length == 0)
                {
                    conId = "null;";
                }
                else
                {
                    conId = textBox_contentId.Text + ";";
                }


                string code = null;
                code += "Name;\n" + name + ";\nIcon;\n" + ico + "\nLink;\n" + link + "\nContentId;\n" + conId + "\n";


                string path = null;
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath;
                }
                folderBrowserDialog.Dispose();
                if (path == null)
                {
                    path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }
                File.WriteAllText(path + "\\" + name + "_item.txt", code);
                MessageBox.Show("Utworzono plik! Scieżka do niego: " + path+ "\\"+name+"_item.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonNextToEp2_Click(object sender, EventArgs e)
        {
            if (textBox_title.Text.Length == 0)
            {
                MessageBox.Show("Wymagane jest podanie tytułu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            panelEp2.Show();
            panelEp2.BringToFront();
        }

        private void buttonBackToEp1_Click(object sender, EventArgs e)
        {
            panelEp1.Show();
            panelEp1.BringToFront();
        }

        private void buttonSHViewItem_Click(object sender, EventArgs e)
        {
            panelEp1ViewItem.Visible = !panelEp1ViewItem.Visible;
            if (panelEp1ViewItem.Visible)
            {
                try
                {
                    buttonEp1VI.Text = textBox_title.Text;
                    pictureBoxEp1VI.ImageLocation = textBox_iconlink.Text;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        }

        private void buttonAddOtherTitle_Click(object sender, EventArgs e)
        {
            if(textBox_OtherTitle.Text.Length == 0)
            {
                MessageBox.Show("Pole tekstowe nie może być puste!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listBox_OtherTitle.Items.Add(textBox_OtherTitle.Text);
            textBox_OtherTitle.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox_OtherTitle.SelectedIndex == -1 || listBox_OtherTitle.Items.Count == 0)
            {
                return;
            }

            listBox_OtherTitle.Items.Remove(listBox_OtherTitle.SelectedItem);
        }

        private void buttonAddSpecies_Click(object sender, EventArgs e)
        {
            if(comboBox_Speacies.Items.Count == 0|| comboBox_Speacies.SelectedIndex == -1 || comboBox_Speacies.SelectedItem == null)
            {
                return ;
            }

            listBox_Species.Items.Add(comboBox_Speacies.SelectedItem);
            comboBox_Speacies.Items.Remove(comboBox_Speacies.SelectedItem);
        }

        private void buttonRemoveSpecies_Click(object sender, EventArgs e)
        {
            if(listBox_Species.SelectedIndex == -1 || listBox_Species.SelectedItem == null)
            {
                return;
            }
            comboBox_Speacies.Items.Add(listBox_Species.SelectedItem);
            listBox_Species.Items.Remove(listBox_Species.SelectedItem);
        }

        private void buttonNextToEp3_Click(object sender, EventArgs e)
        {
            panelEp3.Show();
            panelEp3.BringToFront();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBackToEp2_Click(object sender, EventArgs e)
        {
            panelEp2.Show();
            panelEp2.BringToFront();
        }

        private void buttonAddEp_Click(object sender, EventArgs e)
        {
            int quality = comboBoxEpQuality.SelectedIndex + 1;
            string script = "EpisodeListed;\n" + comboBoxServiceHost.SelectedItem.ToString() + ";\n" +
                comboBoxTypeEpTra.SelectedItem.ToString() + ";\n" +
                textBoxTlumacz.Text + ";\n" + "null;\n" +
                numericUpDownEpNum.Value.ToString() + ";\n" +
                quality + ";\n";
            if(quality == 1)
            {
                script += "360p;\n";
                script += textBoxEpLink.Text + ";\n";
            }
            else if ( quality == 2)
            {
                script += "480p;\n";
                script += textBoxEpLink.Text + ";\n";
                script += "360p;\n";
                script += textBoxEpLink.Text + ";\n";
            }
            else if ( quality == 3)
            {
                script += "720p;\n";
                script += textBoxEpLink.Text + ";\n";
                script += "480p;\n";
                script += textBoxEpLink.Text + ";\n";
                script += "360p;\n";
                script += textBoxEpLink.Text + ";\n";
            }
            else if ( quality == 4)
            {
                script += "1080p;\n";
                script += textBoxEpLink.Text + ";\n";
                script += "720p;\n";
                script += textBoxEpLink.Text + ";\n";
                script += "480p;\n";
                script += textBoxEpLink.Text + ";\n";
                script += "360p;\n";
                script += textBoxEpLink.Text + ";\n";
            }
        }
    }
}
