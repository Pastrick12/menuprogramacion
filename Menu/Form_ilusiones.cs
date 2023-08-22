﻿using System;
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
    public partial class Form_ilusiones : Form
    {
        Pen[] colores = { new Pen(Color.Red), new Pen(Color.Yellow), new Pen(Color.Green), new Pen(Color.Blue), new Pen(Color.Fuchsia), new Pen(Color.Aqua), new Pen(Color.Sienna), new Pen(Color.Brown) };
        public Form_ilusiones()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            e.Graphics.DrawLine(colores[0], 0, 0, w, h);

            e.Graphics.DrawLine(colores[1], 0, h/2, w/2, 0);

            e.Graphics.DrawLine(colores[2], 0, h, w, 0);
            
            e.Graphics.DrawLine(colores[3], 0, h/2, w/2, h);

            e.Graphics.DrawLine(colores[4], w/2, 0, w/2, h);
            
            e.Graphics.DrawLine(colores[5], w/2, 0, w, h/2);

            e.Graphics.DrawLine(colores[6], 0, h/2, w, h/2);

            e.Graphics.DrawLine(colores[7], w/2, h, w, h/2);
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox2.Width;
            int h = pictureBox2.Height;

            for (int i = 0; i < w; i += 10) e.Graphics.DrawLine(colores[0], i, 0, i, h);

        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {

            int w = pictureBox3.Width;

            for (int i = 0; i < w; i += 10) e.Graphics.DrawLine(colores[0], 0, i, w, i);

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {

            int w = pictureBox4.Width;
            int h = pictureBox4.Height;

            for (int i = 0; i < w; i += 10)
            {

                e.Graphics.DrawLine(colores[0], 0, i, w, i);
                e.Graphics.DrawLine(colores[0], i, 0, i, h);

            }

        }
        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox5.Width;

            for (int i = 0; i < w*2; i += 10) e.Graphics.DrawLine(colores[0], 0, i, i, 0);
        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox6.Width;

            for (int i = 0; i < w*2; i += 10) e.Graphics.DrawLine(colores[0], w-i, 0, w, i);
            for (int i = 0; i < w*2; i += 10) e.Graphics.DrawLine(colores[0], w-i, 0, w, i);
            for (int i = 0; i < w*2; i += 10) e.Graphics.DrawLine(colores[0], w-i, 0, w, i);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox7.Width;
            int h = pictureBox7.Height;

            for (int i = 0; i < w; i += 10)
            {
                e.Graphics.DrawLine(colores[0], i, 0, w/2, h/2);
                e.Graphics.DrawLine(colores[0], i, h, w/2, h/2);
            }
            
        }

        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox7.Width;
            int h = pictureBox7.Height;

            for (int i = 0; i < w/2; i += 10)
            {
                e.Graphics.DrawLine(colores[0], i, h/2, w/2, h/2 - i);
                e.Graphics.DrawLine(colores[0], w-i, h/2, w/2, h/2 - i);
                e.Graphics.DrawLine(colores[0], w-i, h/2, w/2, h/2 + i);
                e.Graphics.DrawLine(colores[0], i, h/2, w/2, h/2 + i);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
