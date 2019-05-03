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
    public partial class Draft : UserControl
    {
        public Draft()
        {
            InitializeComponent();
        }

        private void Draft_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                ExpandbleMsg m = new ExpandbleMsg();
                flowLayoutPanel1.Controls.Add(m);
            }
        }
    }
}
