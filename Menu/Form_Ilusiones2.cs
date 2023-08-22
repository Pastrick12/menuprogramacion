using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaObjetos
{
    public partial class Form_Ilusiones2 : Form
    {
        Pen[] colores = { new Pen(Color.Red),
            new Pen(Color.Yellow), new Pen(Color.Green),
            new Pen(Color.Blue), new Pen(Color.Fuchsia),
            new Pen(Color.Aqua), new Pen(Color.Sienna),
            new Pen(Color.Brown) };
        public Form_Ilusiones2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            for (int i = 0; i < w/2; i += 10)
            {
                e.Graphics.DrawLine(colores[0], 0, i, i, h/2);
                e.Graphics.DrawLine(colores[0], i, 0, w/2, i);

                e.Graphics.DrawLine(colores[0], w/2 + i, 0, w/2, h/2 - i);
                e.Graphics.DrawLine(colores[0], w, i, w - i, h/2);

                e.Graphics.DrawLine(colores[0], 0, h/2 + i, w/2 - i, h/2);
                e.Graphics.DrawLine(colores[0], i, h, w/2, h - i);

                e.Graphics.DrawLine(colores[0], w/2, h/2 + i, w/2 + i , h);
                e.Graphics.DrawLine(colores[0], w, h/2 + i, w/2 + i, h/2);
            }
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox2.Width;
            int h = pictureBox2.Height;

            for (int i = 0; i < w; i+= 10)
            e.Graphics.DrawEllipse(colores[4], ((w-i)/2), ((h-i)/2), i, i);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox3.Width;
            int h = pictureBox3.Height;

            for (int i = 0;i < w/2; i += 10)
            {
                e.Graphics.DrawLine(colores[2], w / 2, i, i, h - i);
                e.Graphics.DrawLine(colores[2], w / 2, i, w - i, h - i);
                e.Graphics.DrawLine(colores[2], i, h - i, w - i, h - i);
            }
            
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox4.Width;
            int h = pictureBox4.Height;

            for (int i = 0; i <= w/2 + 10; i += 10)
            {
                e.Graphics.DrawLine(colores[3], i, 0, w/2, i);
                e.Graphics.DrawLine(colores[3], i, h, w/2, h-i);
                e.Graphics.DrawLine(colores[3], w/2 + i, 0, w/2, h/2-i);
                e.Graphics.DrawLine(colores[3], w/2, h-i, w-i, h);
                e.Graphics.DrawLine(colores[3], i, h-i, w/2-i, h/2-i);
                e.Graphics.DrawLine(colores[3], w-i, h-i, w/2+i, h/2-i);
            }
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox5.Width;
            int h = pictureBox5.Height;

            for (int i = 0; i < w; i += 10)
            {
                e.Graphics.DrawLine(colores[2], w / 2, i, i, h - i);
                e.Graphics.DrawLine(colores[2], w / 2, i, w - i, h - i);
                e.Graphics.DrawLine(colores[2], i, h - i, w - i, h - i);
            }
        }
    }
}
