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
    public partial class ToolCreatorRelatedTitle : Form
    {
        public ToolCreatorRelatedTitle()
        {
            InitializeComponent();
        }

        private void ToolCreatorRelatedTitle_FormClosing(object sender, FormClosingEventArgs e)
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
