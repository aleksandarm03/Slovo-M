using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crtanje_slova_M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen olovka;
        Point t;
        private void Form1_Load(object sender, EventArgs e)
        {
            olovka = new Pen(Color.Black);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            olovka.Color = colorDialog1.Color;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            t.X = e.X;
            t.Y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int x = (t.X + e.X) / 2;
            int y = (t.Y + e.Y) / 2;
            int a = Math.Abs(t.X - e.X);
            int b = Math.Abs(t.Y - e.Y);
            Graphics g = CreateGraphics();
            g.DrawLine(olovka, x - a / 2, y + b / 2, x - a / 2, y - b / 2);
            g.DrawLine(olovka, x - a / 2, y - b / 2, x, y);
            g.DrawLine(olovka, x, y, x + a / 2, y - b / 2);
            g.DrawLine(olovka, x + a / 2, y - b / 2, x + a / 2, y + b / 2);

        }
    }
}
