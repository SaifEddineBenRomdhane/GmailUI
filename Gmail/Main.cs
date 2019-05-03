using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmail
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //generates contact list
            for (int i = 0; i < 7; i++)
            {
                Contact c = new Contact();
                flowLayoutPanel2.Controls.Add(c);
            }
            //set the first button to selected
            bunifuFlatButton1.selected = true;
            //set the font on selected event
            bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //set the top & height to get the indicator in the same size as th button
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;
            //set fontColor on button.selected event
            bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));

            inbox1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //set the top & height to get the indicator in the same size as th button
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;
            //set fontColor on button.selected event
            bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            starred1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //set the top & height to get the indicator in the same size as th button
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;
            //set fontColor on button.selected event
            bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            snoozed1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //set the top & height to get the indicator in the same size as th button
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;
            //set fontColor on button.selected event
            bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            important1.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //set the top & height to get the indicator in the same size as th button
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;
            //set fontColor on button.selected event
            bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            sent1.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //set the top & height to get the indicator in the same size as th button
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;
            //set fontColor on button.selected event
            bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(85)))));
            draft1.BringToFront();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            // Enable the default scrollbars first
            // then get the value(s) required.
            flowLayoutPanel2.AutoScroll = true;

            // Set the vertical scroll maximum value to be at-par with the flowlayout.
            bunifuVScrollBar1.Maximum = flowLayoutPanel2.VerticalScroll.Maximum;//- 450;

            //You can even change the thumb length.
            bunifuVScrollBar1.ThumbLength = 70;
            // Now disable the default scrollbars.
            flowLayoutPanel2.AutoScroll = false;

            // Enable the default scrollbars first
            // then get the value(s) required.
            inbox1.flowLayoutPanel1.AutoScroll = true;

            // Set the vertical scroll maximum value to be at-par with the flowlayout.
            inbox1.bunifuVScrollBar1.Maximum = inbox1.flowLayoutPanel1.VerticalScroll.Maximum;//- 450;

            //You can even change the thumb length.
            inbox1.bunifuVScrollBar1.ThumbLength = 70;
            // Now disable the default scrollbars.
            inbox1.flowLayoutPanel1.AutoScroll = false;
        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            flowLayoutPanel2.AutoScrollPosition = new Point(flowLayoutPanel2.AutoScrollPosition.X, e.Value);
        }
    }
}
