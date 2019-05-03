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
    public partial class Messsage : UserControl
    {
        public Messsage()
        {
            InitializeComponent();
        }

        private void Messsage_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                bunifuCheckBox1.Checked = true;
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));  
            }
            else
            {
                bunifuCheckBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked == true)
            {
                //bunifuCheckBox1.Checked = true;
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            }
            else
            {
                //bunifuCheckBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }
    }
}
