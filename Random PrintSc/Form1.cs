using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Random_PrintSc
{
    public partial class Form1 : Form
    {
        bool mousedown;
        private Point offset;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] letters = "qwertyuopasdfghjklizxcvbnm12345567890".ToCharArray();
            Random r = new Random();
            string randomString = "";
            for (int i = 0; i < 6; i++)
            {
                randomString += letters[r.Next(0, 35)].ToString();
            }
            Process.Start("https://prnt.sc/" + randomString);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(label3.ForeColor == Color.Crimson)
            {
                label3.ForeColor = Color.Black;
                label3.Text = "Luna ❤️ veinz";
            }
            else
            {
                label3.ForeColor = Color.Crimson;
                label3.Text = "veinz ❤️ Luna";
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
