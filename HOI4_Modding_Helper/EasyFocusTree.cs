using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOI4_Modding_Helper
{
    public partial class EasyFocusTree : Form
    {
        public EasyFocusTree()
        {
            InitializeComponent();
            this.Size = new Size(520, 520);
        }

        int offset = -50;

        int MouseX;
        int MouseY;

        int X_offset;
        int Y_offset;

        private void EasyFocusTree_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void EasyFocusTree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && flowLayoutPanel1.Visible == false)
                flowLayoutPanel1.Show();
            else if (flowLayoutPanel1.Visible == true)
                flowLayoutPanel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();

            btn.Height = 50;
            btn.Width = 50;
            btn.Left = offset + 50;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Transparent;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.BackgroundImage = Properties.Resources.goal_unknown;

            offset = offset + 75;

            mm.Controls.Add(btn);
            btn.BringToFront();

            btn.Click += Btn_Click;
            //btn.MouseUp += Btn_MouseUp;
            mm.MouseMove += Btn_MouseMove;
            mm.MouseClick += Btn_Click;

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (enbld == true )
            {
                enbld = false;

                ThrowToGrid();

                this.Refresh();
            }
            else if (sender is Button)
            {
                s = (Button)sender;
                enbld = true;
            }

        }

        private void ThrowToGrid()
        {

            X_offset = Convert.ToInt32(Math.Round(Convert.ToDecimal(MouseX / 75), 0, MidpointRounding.AwayFromZero));
            Y_offset = Convert.ToInt32(Math.Round(Convert.ToDecimal(MouseY  / 75) , 0, MidpointRounding.AwayFromZero));
            //s.Location = new Point( MouseX - s.Width/2 , MouseY - s.Height/2);

            if (X_offset <= 1 && Y_offset <= 1)
            {
                s.Location = new Point(75 * (X_offset + 1) - 25, 75 * (Y_offset + 1) - 25);
            }
            else if (X_offset <= 1)
            {
                s.Location = new Point(75 * (X_offset + 1) - 25, 75 * Y_offset - 25);
            }
            else if (Y_offset <= 1)
            {
                s.Location = new Point(75 * X_offset - 25, 75 * (Y_offset + 1) - 25);
            }
            else
            {
                s.Location = new Point(75 * X_offset - 25, 75 * Y_offset - 25);
            }


            //positioner.Text = "X_offset: " + X_offset.ToString() + Environment.NewLine + "Y_offset: " + Y_offset.ToString() + Environment.NewLine + "Position: " + s.Location.ToString() ;
        }

        Button s;
        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            enbld = false;
        }

        bool enbld = false;
        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (enbld == true)
            {
                s.Location = new Point( e.X + 5 /*- s.Width/2 */, e.Y + 5 /*- s.Height/2*/);
               // positioner.Text = s.Location.ToString();

                MouseX = e.X;
                MouseY = e.Y;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EasyFocusTree_Paint(object sender, PaintEventArgs e)
        {
            //if (enbld != true)
                
        }

        public void PaintSomeSetka(PaintEventArgs e)
        {
            Pen blk = new Pen(Color.Black, 1);
            //MessageBox.Show(Math.Round(Convert.ToDouble(this.Width / 75)).ToString());
            //MessageBox.Show(Math.Round(Convert.ToDouble(this.Height / 75)).ToString());
            for (int i = 1; i <= (Convert.ToDouble((this.Width + this.Height) / 75)); i++)
            {

                e.Graphics.DrawLine(blk, 0, 75 * i, this.Width, 75 * i);
                e.Graphics.DrawLine(blk, 75 * i, 0, 75 * i, this.Height);

                //Thread.Sleep(15);
            }

        }

        private void mm_Paint(object sender, PaintEventArgs e)
        {
            PaintSomeSetka(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();

            if (fd.SelectedPath != "")
            {
                foreach (string f in Directory.GetFiles(fd.SelectedPath))
                {
                    if (f.Any(c => char.IsUpper(c)))
                    {
                        File.Move(f, fd.SelectedPath + f.Substring(fd.SelectedPath.Length, f.Length - fd.SelectedPath.Length).ToLower());
                    }  
                }
                MessageBox.Show("OK");
            }
        }
    }
}
