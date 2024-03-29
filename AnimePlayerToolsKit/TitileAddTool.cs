﻿using System;
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
    public partial class TitileAddTool : Form
    {
        AnimePlayer.Class.PreviewTitleClass previewTitleClass;
        AnimePlayer.Class.PageItemData pageItemData;

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

        private void buttonNextToEp2_Click(object sender, EventArgs e)
        {
            if (textBox_title.Text.Length == 0)
            {
                MessageBox.Show("Wymagane jest podanie tytułu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            previewTitleClass.Title = textBox_title.Text;
            /*foreach(var item in listBoxIconsLinks.Items)
            {
                previewTitleClass.LinkToIcon.Add(item.ToString());
            }*/

            previewTitleClass.S_ID = "PreviewItems/"+previewTitleClass.Title.Replace(' ', '_').Replace(':', '_');
            panelEp2.Show();
            panelEp2.BringToFront();
        }

        private void buttonBackToEp1_Click(object sender, EventArgs e)
        {
            this.Close();
           /* panelEp1.Show();
            panelEp1.BringToFront();*/
        }

        private void buttonSHViewItem_Click(object sender, EventArgs e)
        {
            panelEp1ViewItem.Visible = !panelEp1ViewItem.Visible;
            if (panelEp1ViewItem.Visible)
            {
                try
                {
                    buttonEp1VI.Text = textBox_title.Text;
                    if(textBox_iconlink.Text.Length > 1)
                    {
                        pictureBoxEp1VI.ImageLocation = textBox_iconlink.Text;
                    }
                    else
                    {
                        //if(listBoxIconsLinks.Items.Count > 0)
                        {
                           // pictureBoxEp1VI.ImageLocation = listBoxIconsLinks.Items[0].ToString();
                        }
                    }
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
        public void AddChageListboxAndComboBox(ComboBox comboBox,ListBox listBox )
        {
            if(comboBox.Items.Count == 0 ||
                comboBox.SelectedIndex == -1 ||
                comboBox.SelectedItem == null)
            {
                return;
            }

            listBox.Items.Add(comboBox.SelectedItem);
            comboBox.Items.Remove(comboBox.SelectedItem);
        }

        public void RemoveChageListboxAndComboBox(ComboBox comboBox, ListBox listBox)
        {
            if(listBox.SelectedIndex == -1 || listBox.SelectedItem == null)
            {
                return;
            }
            comboBox.Items.Add(listBox.SelectedItem);
            listBox.Items.Remove(listBox.SelectedItem);
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEndCreator_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddIconLinkToList_Click(object sender, EventArgs e)
        {
            if(textBox_iconlink.Text.Length <= 1)
            {
                MessageBox.Show("Podaj link do ikony", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //listBoxIconsLinks.Items.Add(textBox_iconlink.Text);
                textBox_iconlink.Text = "";
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void buttonRemoveLinkInList_Click(object sender, EventArgs e)
        {
            try
            {
                //if (listBoxIconsLinks.SelectedItem == null)
                {
                    return;
                }
                //listBoxIconsLinks.Items.Remove(listBoxIconsLinks.SelectedItem);
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
               // listBoxRT.Items.Add(textBox2.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                //listBoxRT.Items.Remove(listBoxRT.SelectedItem);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        PageItemData _PageItemData;
        private void buttonEndPID_Click(object sender, EventArgs e)
        {
            try
            {
                /*string sid = AnimePlayer.Core.Replacer.Names(textBoxTit.Text);
                PageItemData data = new PageItemData();
                data.S_ID = sid;
                TitleInformation titleInformation = new TitleInformation();
                titleInformation.Title = textBoxTit.Text;
                List<string> strings = new List<string>();
                for (int i = 0; i < listBox_OtherTitle.Items.Count; i++)
                {
                    strings.Add(listBox_OtherTitle.Items[i].ToString());
                }
                titleInformation.OtherTitle = strings.ToArray();*/
            }
            catch (Exception ex)
            {

            }
        }

        private void button_Add_typesOfCharacters_Click(object sender, EventArgs e)
        {

        }
    }
}
