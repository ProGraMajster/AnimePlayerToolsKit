using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AnimePlayer.Class;

namespace AnimePlayerToolsKit
{
    public partial class ToolEpisode : Form
    {
        public ToolEpisode()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if(textBoxTitle.Text.Length == 0)
                    {
                        MessageBox.Show("Pole tytułu nie może być puste!");
                        return;
                    }
                    Guid guid = Guid.NewGuid();
                    Episode episode = new Episode();
                    episode.Title = textBoxTitle.Text;
                    episode.TitleOfEpisode = textBoxTitleOfEpisode.Text;
                    episode.NumberEpisode = numericUpDownNumberEpisode.Value.ToString();
                    episode.Type = comboBox1.SelectedItem.ToString();
                    episode.AudioLanguage = textBoxAudio.Text;
                    episode.SubtitleLanguage = textBoxSubtitle.Text;
                    episode.LinkToEpisode = textBoxLinkToEpisode.Text;
                    episode.TranslationCreator = textBoxT.Text;
                    episode.TranslationCreatorAdditionalInformation = richTextBoxAddniotalInformaion.Text;
                    string json = AnimePlayer.Core.SerializationAndDeserialization.SerializationJsonEx(episode,typeof(Episode));
                    File.WriteAllText(folderBrowserDialog1.SelectedPath + "\\" + Replacer.Names(episode.Title) + "--Guid_" + guid.ToString() + ".json",
                        json);
                    labelPath.Text="Zapisano! Scieżka do pliku: \n"+folderBrowserDialog1.SelectedPath+"\\"+Replacer.Names(episode.Title)+"--Guid_"+guid.ToString()+".dat";
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void ToolEpisode_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Episode episode =(Episode)SerializationAndDeserialization.Deserialization(openFileDialog.FileName);
                    if(episode == null)
                    {
                        return;
                    }
                    textBoxTitle.Text = episode.Title;
                    textBoxTitleOfEpisode.Text = episode.TitleOfEpisode;
                    numericUpDownNumberEpisode.Value = int.Parse(episode.NumberEpisode);
                    comboBox1.SelectedItem = episode.Type;
                    textBoxAudio.Text = episode.AudioLanguage;
                    textBoxSubtitle.Text = episode.SubtitleLanguage;
                    textBoxLinkToEpisode.Text = episode.LinkToEpisode;
                    textBoxT.Text = episode.TranslationCreator;
                    richTextBoxAddniotalInformaion.Text = episode.TranslationCreatorAdditionalInformation;
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
