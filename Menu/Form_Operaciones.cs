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
    public partial class Form_Operaciones : Form
    {
        public Form_Operaciones()
        {
            InitializeComponent();
        }

        private void Form_Operaciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float dato1 = float.Parse(textBox1.Text);
                float dato2 = float.Parse(textBox2.Text);

                float suma = dato1 + dato2;
                float resta = dato1 - dato2;
                float multiplicacion = dato1 * dato2;
                float division = dato1 / dato2;

                label5.Text = dato1 + " + " + dato2 + " = " + suma + "\n";
                label5.Text += dato1 + " - " + dato2 + " = " + resta + "\n";
                label5.Text += dato1 + " * " + dato2 + " = " + multiplicacion + "\n";
                label5.Text += dato1 + " / " + dato2 + " = " + division + "\n";
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
