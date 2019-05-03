using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmail
{
    public partial class ExpandbleMsg : UserControl
    {
        public ExpandbleMsg()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            while (this.Height < 368)
            {
                this.Height += 5;
                if (panel1.Height > 0)
                {
                    panel1.Height --;
                }
            }
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            while (this.Height > 48)
            {
                this.Height -= 5;
                if (panel1.Height < 48)
                {
                    panel1.Height++;
                }
            }
        }
    }
}
