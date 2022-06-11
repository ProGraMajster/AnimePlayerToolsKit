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
    public partial class Tool_Definitions : Form
    {
        AnimePlayer.Class.Definition definition;

        public Tool_Definitions()
        {
            InitializeComponent();
            textBox3.Tag = Guid.NewGuid();
            textBox3.Text = textBox3.Tag.ToString();
        }

        private void Tool_Definitions_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length <= 0)
                {
                    MessageBox.Show("Pole nazwa nie może być puste!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBox2.Text.Length <= 0)
                {
                    MessageBox.Show("Pole opis nie może być puste!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                definition = new AnimePlayer.Class.Definition();
                definition.Guid = (Guid)textBox3.Tag;
                definition.Name = textBox1.Text;
                definition.Description = textBox2.Text;
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    SerializationAndDeserialization.Serialization(definition,folderBrowserDialog.SelectedPath +
                        "\\"+ textBox1.Text
                        .Replace('/', '_')
                        .Replace('\\', '_')
                        .Replace(':','_')
                        .Replace(';','_')   
                        .Replace(' ','_')+".dat");
                    folderBrowserDialog.Dispose();
                    MessageBox.Show("Zapisano plik");
                    textBox3.Tag = Guid.NewGuid();
                    textBox3.Text = textBox3.Tag.ToString();
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    definition = (AnimePlayer.Class.Definition)SerializationAndDeserialization
                        .Deserialization(openFileDialog.FileName);
                    textBox1.Text = definition.Name;
                    textBox2.Text = definition.Description;
                    textBox3.Text = definition.Guid.ToString();
                    textBox3.Tag = definition.Guid;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wystąpił błąd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Error.WriteLine(ex.ToString());
            }
        }
    }
}
