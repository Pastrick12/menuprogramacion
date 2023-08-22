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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void práctica1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Triangulo().ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void práctica2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Operaciones().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void práctica3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Formula_general().ShowDialog();
        }

        private void práctica4FibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Fibonacci().ShowDialog();
        }

        private void práctica5IlusionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_ilusiones().ShowDialog();
        }

        private void práctica6Ilusiones2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Ilusiones2().ShowDialog();
        }

        private void práctica7EncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_encuesta().ShowDialog();
        }

        private void práctica8CatálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_catalogo().ShowDialog();
        }
    }
}
