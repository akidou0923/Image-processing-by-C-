using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Folder
{
    public partial class 饱和度 : Form
    {
        public 饱和度()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void trackBarH_Scroll(object sender, EventArgs e)
        {
            textBox_H.Text = trackBarH.Value.ToString();
        }

        private void trackBarS_Scroll(object sender, EventArgs e)
        {
            textBox_S.Text = trackBarS.Value.ToString();
        }

        private void trackBarI_Scroll(object sender, EventArgs e)
        {
            textBox_I.Text = trackBarI.Value.ToString();
        }
    }
}
