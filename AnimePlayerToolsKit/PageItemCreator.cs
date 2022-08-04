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
    public partial class PageItemCreator : Form
    {
        public PageItemCreator()
        {
            InitializeComponent();
        }

        public void AddItemToListBox(TextBox textBox, ListBox listBox)
        {
            if (textBox.Text.Length == 0)
            {
                MessageBox.Show("Pole tekstowe nie może być puste!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listBox.Items.Add(textBox.Text);
            textBox.Clear();
        }

        public void RemoveItemListBox(ListBox listBox)
        {
            if (listBox.SelectedIndex == -1 || listBox.Items.Count == 0)
            {
                return;
            }

            listBox.Items.Remove(listBox.SelectedItem);
        }
        public void AddItemToListBox(ComboBox comboBox, ListBox listBox)
        {
            if (comboBox.Items.Count == 0||
                comboBox.SelectedIndex == -1 || 
                comboBox.SelectedItem == null)
            {
                return;
            }

            listBox.Items.Add(comboBox.SelectedItem);
            comboBox.Items.Remove(comboBox.SelectedItem);
        }

        public void RemoveItemListBox(ComboBox comboBox, ListBox listBox)
        {
            if (listBox.SelectedIndex == -1 || listBox.SelectedItem == null)
            {
                return;
            }
            comboBox.Items.Add(listBox.SelectedItem);
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void buttonAddOtherTitle_Click(object sender, EventArgs e)
        {
            AddItemToListBox(textBox_OtherTitle, listBox_OtherTitle);
        }

        private void buttonRemoveOtherTitle_Click(object sender, EventArgs e)
        {
            RemoveItemListBox(listBox_OtherTitle);
        }

        #region Gatunki
        private void buttonSpeciesAdd_Click(object sender, EventArgs e)
        {
            AddItemToListBox(comboBoxSpecies, listBox_Species);
        }

        private void buttonSpeciesRemove_Click(object sender, EventArgs e)
        {
            RemoveItemListBox(comboBoxSpecies, listBox_Species);
        }
        #endregion

        private void button_Add_typesOfCharacters_Click(object sender, EventArgs e)
        {
            AddItemToListBox(comboBox_TypeOfCharacter, listBox_typesOfCharacters);
        }

        private void button_Remove_typesOfCharacters_Click(object sender, EventArgs e)
        {
            RemoveItemListBox(comboBox_TypeOfCharacter, listBox_typesOfCharacters);
        }

        private void buttonPlaceAndTimeAdd_Click(object sender, EventArgs e)
        {
            AddItemToListBox(comboBoxPlaceAndTime, listBox_PlaceAndTime);
        }

        private void buttonPlaceAndTimeRemove_Click(object sender, EventArgs e)
        {
            RemoveItemListBox(comboBoxPlaceAndTime, listBox_PlaceAndTime);
        }

        private void buttonOtherTagsAdd_Click(object sender, EventArgs e)
        {
            AddItemToListBox(comboBoxOtherTags, listBox_OtherTags);
        }

        private void buttonOtherTagsRemove_Click(object sender, EventArgs e)
        {
            RemoveItemListBox(comboBoxOtherTags, listBox_OtherTags);
        }

        private void buttonStudioAdd_Click(object sender, EventArgs e)
        {
            AddItemToListBox(textBoxStudio, listBoxStudios);
        }

        private void buttonStudioRemove_Click(object sender, EventArgs e)
        {
            RemoveItemListBox(listBoxStudios);
        }

        private void PageItemCreator_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                labelProgress.Text = "Przygotowywanie...";
                Application.DoEvents();
                AnimePlayer.Class.PageItemData pageItemData = new AnimePlayer.Class.PageItemData();
                pageItemData.TitleInformation = new AnimePlayer.Class.TitleInformation();
                labelProgress.Text = "Przygotowywanie zakończono";
                Application.DoEvents();
                progressBar1.Show();
                Application.DoEvents();
                labelProgress.Text = "Przetwarzanie... 0%";
                Application.DoEvents();
                pageItemData.S_ID = Replacer.Names(textBoxTitle.Text);
                labelProgress.Text = "Przetwarzanie... 1%";
                Application.DoEvents();
                pageItemData.TitleInformation.Title = textBoxTitle.Text;
                pageItemData.TitleInformation.OtherTitle = GetArryFromListBoxItems(listBox_OtherTitle);
                labelProgress.Text = "Przetwarzanie... 5%";
                Application.DoEvents();
                if (richTextBoxDescription.Text.Length == 0)
                {
                    labelProgress.Text = "Błąd: Opis nie może być pusty";
                    progressBar1.Hide();
                    MessageBox.Show("Błąd: Opis nie możę być pusty");
                    Application.DoEvents();
                    return;
                }
                pageItemData.TitleInformation.Description = richTextBoxDescription.Text;

                pageItemData.TitleInformation.Species = GetArryFromListBoxItems(listBox_Species);
                labelProgress.Text = "Przetwarzanie... 10%";
                Application.DoEvents();
                pageItemData.TitleInformation.TargetGroups = comboBoxTargetGroup.SelectedItem.ToString();

                pageItemData.TitleInformation.TypesOfCharacters = GetArryFromListBoxItems(listBox_typesOfCharacters);
                labelProgress.Text = "Przetwarzanie... 20%";
                Application.DoEvents();

                pageItemData.TitleInformation.PlaceAndTime = GetArryFromListBoxItems(listBox_PlaceAndTime);
                labelProgress.Text = "Przetwarzanie... 30%";
                Application.DoEvents();

                pageItemData.TitleInformation.OtherTags = GetArryFromListBoxItems(listBox_OtherTags);
                labelProgress.Text = "Przetwarzanie... 40%";
                Application.DoEvents();

                pageItemData.TitleInformation.Archetype = comboBoxArchetype.SelectedItem.ToString();

                pageItemData.TitleInformation.Type = comboBoxType.SelectedItem.ToString();

                labelProgress.Text = "Przetwarzanie... 50%";
                Application.DoEvents();
                pageItemData.TitleInformation.Status = comboBoxState.SelectedItem.ToString();

                pageItemData.TitleInformation.DateOfIssue = dateTimePickerStartEmition.Text;

                labelProgress.Text = "Przetwarzanie... 60%";
                Application.DoEvents();
                pageItemData.TitleInformation.EndOfIssue = dateTimePickerEndEmition.Text;

                pageItemData.TitleInformation.NumberOfEpisodes = numericUpDownEpCount.Value.ToString();

                labelProgress.Text = "Przetwarzanie... 70%";
                Application.DoEvents();
                pageItemData.TitleInformation.Studio = GetArryFromListBoxItems(listBoxStudios);

                labelProgress.Text = "Przetwarzanie... 80%";
                Application.DoEvents();
                pageItemData.TitleInformation.EpisodeLength = numericUpDownDlugoscEp.Value.ToString();

                labelProgress.Text = "Przetwarzanie... 90%";
                Application.DoEvents();
                pageItemData.TitleInformation.MPAA = comboBoxMPAA.SelectedItem.ToString();
                labelProgress.Text = "Przetwarzanie... 100%";
                Application.DoEvents();

                if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    labelProgress.Text = "Zapisywanie...";
                    Application.DoEvents();
                    if(comboBoxFileFormat.SelectedItem.ToString() == ".json")
                    {
                        SerializationAndDeserialization.SerializationJson(pageItemData, folderBrowserDialog1.SelectedPath+
                        "\\"+pageItemData.S_ID+".json", typeof(AnimePlayer.Class.PageItemData));

                        labelProgress.Text = "Zapisano! Scieżka do zapisanego pliku:"+folderBrowserDialog1.SelectedPath+
                            "\\"+pageItemData.S_ID+".json";
                    }
                    else
                    {
                        SerializationAndDeserialization.Serialization(pageItemData, folderBrowserDialog1.SelectedPath+
                        "\\"+pageItemData.S_ID+".dat");

                        labelProgress.Text = "Zapisano! Scieżka do zapisanego pliku:"+folderBrowserDialog1.SelectedPath+
                            "\\"+pageItemData.S_ID+".dat";
                    }
                }
                progressBar1.Hide();
            }
            catch(Exception ex)
            {
                labelProgress.Text = "Error:"+ex.Message;
                Console.Error.WriteLine(ex.ToString());
            }
        }

        public string[] GetArryFromListBoxItems(ListBox listBox)
        {
            List<string> strings = new List<string>();
            foreach (var item in listBox.Items)
            {
                strings.Add(item.ToString());
            }
            return strings.ToArray();
        }

        private void buttonEditFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AnimePlayer.Class.PageItemData pageItemData = 
                        (AnimePlayer.Class.PageItemData)SerializationAndDeserialization.Deserialization(openFileDialog.FileName);
                    if(pageItemData == null)
                    {
                        pageItemData = (AnimePlayer.Class.PageItemData)SerializationAndDeserialization.DeserializationJson(
                            openFileDialog.FileName,
                            typeof(AnimePlayer.Class.PageItemData));
                        if(pageItemData == null)
                        {
                            MessageBox.Show("Nie udało się załadować pliku", "Error");
                            return;
                        }
                    }

                    textBoxTitle.Text = pageItemData.TitleInformation.Title;
                    foreach(var item in pageItemData.TitleInformation.OtherTitle)
                    {
                        listBox_OtherTitle.Items.Add(item);
                    }
                    richTextBoxDescription.Text = pageItemData.TitleInformation.Description;
                    foreach(var item in pageItemData.TitleInformation.Species)
                    {
                        listBox_Species.Items.Add(item);
                    }
                    comboBoxTargetGroup.SelectedItem = pageItemData.TitleInformation.TargetGroups;
                    foreach(var item in pageItemData.TitleInformation.TypesOfCharacters)
                    {
                        listBox_typesOfCharacters.Items.Add(item);
                    }
                    foreach(var item in pageItemData.TitleInformation.PlaceAndTime)
                    {
                        listBox_PlaceAndTime.Items.Add(item);
                    }
                    foreach(var item in pageItemData.TitleInformation.OtherTags)
                    {
                        listBox_OtherTags.Items.Add(item);
                    }
                    comboBoxArchetype.SelectedItem = pageItemData.TitleInformation.Archetype;
                    comboBoxMPAA.SelectedItem = pageItemData.TitleInformation.MPAA;
                    comboBoxType.SelectedItem = pageItemData.TitleInformation.Type;
                    comboBoxState.SelectedItem = pageItemData.TitleInformation.Status;
                    dateTimePickerStartEmition.Value = DateTime.Parse(pageItemData.TitleInformation.DateOfIssue);
                    dateTimePickerEndEmition.Value = DateTime.Parse(pageItemData.TitleInformation.EndOfIssue);
                    numericUpDownEpCount.Value = int.Parse(pageItemData.TitleInformation.NumberOfEpisodes);
                    foreach(var item in pageItemData.TitleInformation.Studio)
                    {
                        listBoxStudios.Items.Add(item);
                    }
                    numericUpDownDlugoscEp.Value = int.Parse(pageItemData.TitleInformation.EpisodeLength);
                    textBoxTitle.Text = pageItemData.TitleInformation.Title;
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
