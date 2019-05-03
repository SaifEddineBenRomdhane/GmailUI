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
    public partial class Inbox : UserControl
    {
        public Inbox()
        {
            InitializeComponent();
        }

        private void Inbox_Load(object sender, EventArgs e)
        {
            Hindicator.Size = new System.Drawing.Size(71, 3);
            Hindicator.Location = new System.Drawing.Point(46, 48);
            for (int i = 0; i < 9; i++)
            {
                Messsage m = new Messsage();
                flowLayoutPanel1.Controls.Add(m);
            }
        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(flowLayoutPanel1.AutoScrollPosition.X, e.Value);
        }

        private void lblPrimary_Click(object sender, EventArgs e)
        {
            Hindicator.Size = new System.Drawing.Size(71, 3);
            Hindicator.Location = new System.Drawing.Point(46, 48);
            foreach (Messsage control in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Clear();
                control.Dispose();
            }
            for (int i = 0; i < 3; i++)
            {
                Messsage m = new Messsage();
                flowLayoutPanel1.Controls.Add(m);
            }

        }

        private void lblSocial_Click(object sender, EventArgs e)
        {
            Hindicator.Size = new System.Drawing.Size(65, 3);
            Hindicator.Location = new System.Drawing.Point(125, 48);
            foreach (Messsage control in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Clear();
                control.Dispose();
            }
                for (int i = 0; i < 1; i++)
                {
                    Messsage m = new Messsage();
                    flowLayoutPanel1.Controls.Add(m);
                }
        }

        private void lblPromotions_Click(object sender, EventArgs e)
        {
            Hindicator.Size = new System.Drawing.Size(87, 3);
            Hindicator.Location = new System.Drawing.Point(200, 48);
            foreach (Messsage control in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Clear();
                control.Dispose();
            }
                for (int i = 0; i < 8; i++)
                {
                    Messsage m = new Messsage();
                    flowLayoutPanel1.Controls.Add(m);
                }
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked  == true)
            {
                foreach (Messsage c in flowLayoutPanel1.Controls)
                {
                    c.bunifuCheckBox1.Checked = true;
                }
            }
            else
            {
                foreach (Messsage c in flowLayoutPanel1.Controls)
                {
                    c.bunifuCheckBox1.Checked = false;
                }
            }
        }
    }
}
