using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimePlayerToolsKit
{
    public partial class Tool_EpCreator : Form
    {
        public Tool_EpCreator()
        {
            InitializeComponent();
        }

        public string GetScript()
        {
            string code = null;
            foreach (var s in listBoxEp.Items)
            {
                code += s.ToString();
            }
            return code;
        }

        private void buttonAddEp_Click(object sender, EventArgs e)
        {
            try
            {
                int quality = comboBoxEpQuality.SelectedIndex + 1;
                string script = "EpisodeListed;\n" + comboBoxServiceHost.SelectedItem.ToString() + ";\n" +
                    comboBoxTypeEpTra.SelectedItem.ToString() + ";\n" +
                    textBoxTlumacz.Text + ";\n" + "null;\n" +
                    numericUpDownEpNum.Value.ToString() + ";\n" +
                    "Quality;\n" + quality + ";\n";
                if (quality == 1)
                {
                    script += "360p;\n";
                    script += textBoxEpLink.Text + ";\n";
                }
                else if (quality == 2)
                {
                    script += "480p;\n";
                    script += textBoxEpLink.Text + ";\n";
                    script += "360p;\n";
                    script += textBoxEpLink.Text + ";\n";
                }
                else if (quality == 3)
                {
                    script += "720p;\n";
                    script += textBoxEpLink.Text + ";\n";
                    script += "480p;\n";
                    script += textBoxEpLink.Text + ";\n";
                    script += "360p;\n";
                    script += textBoxEpLink.Text + ";\n";
                }
                else if (quality == 4)
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
                listBoxEp.Items.Add(script);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonRemoveEp_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxEp.Items.Remove(listBoxEp.SelectedItem);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Console.WriteLine(ex.ToString());
            }
        }

        private void Tool_EpCreator_FormClosed(object sender, FormClosedEventArgs e)
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

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                if(save.ShowDialog() == DialogResult.OK)
                {
                    string code = null;
                    foreach(var s in listBoxEp.Items)
                    {
                        code += s.ToString();
                    }
                    File.WriteAllText(save.FileName, code);
                }
                save.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.Close();
                Application.OpenForms[0].Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxEp.Items.Clear();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient();
                mail.To.Add("testq8055@gmail.com");
                mail.From = new MailAddress("mail@domain.com");
                mail.Subject = "EpCreator - Created List Ep";
                mail.IsBodyHtml = true;
                mail.Body = GetScript();
                SmtpServer.Host = "smtpserver";
                SmtpServer.Port = 25;
                SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                try
                {
                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception Message: " + ex.Message);
                    if (ex.InnerException != null)
                        Debug.WriteLine("Exception Inner:   " + ex.InnerException);
                }
            }
            catch(Exception exBtnSend)
            {
                MessageBox.Show("Wystąpił błąd!", "Error");
                Console.WriteLine(exBtnSend.ToString());
            }
        }
    }
}
