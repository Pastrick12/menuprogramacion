using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaObjetos
{
    public partial class Form_encuesta : Form
    {
        public Form_encuesta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Procesando Encuesta...", "Procesando...");
            richTextBox1.Text = "Bienvenido " + textBox1.Text + " " +
                textBox2.Text + " " + textBox3.Text + "\n" + "Tu fecha de nacimiento es: " + dateTimePicker1.Text + "\n" + "Tu año de nacimiento es: " + numericUpDown1.Text + "\n" + "Tu comida favorita es: " + comboBox1.Text + "\n" + "Tu película favorita es: " + comboBox2.Text + "\n" + "Te gusta programar: ";

            if (radioButton1.Checked == true)
            {
                richTextBox1.Text += "Mucho";
            }
            if (radioButton2.Checked == true)
            {
                richTextBox1.Text += "Poquito";
            }
            if (radioButton3.Checked == true)
            {
                richTextBox1.Text += "Sí";
            }
            if (radioButton4.Checked == true)
            {
                richTextBox1.Text += "No";
            }

            richTextBox1.Text += "\n" + "¿Cuáles son tus materias favoritas? ";

            if (checkBox1.Checked == true)
            {
                richTextBox1.Text += "\n" + "- Programación Orientada a Objetos";
            }
            if (checkBox2.Checked == true)
            {
                richTextBox1.Text += "\n" + "- Electromagnetismo";
            }
            if (checkBox3.Checked == true)
            {
                richTextBox1.Text += "\n" + "- Inglés";
            }
            if (checkBox4.Checked == true)
            {
                richTextBox1.Text += "\n" + "- Biología";
            }
            if (checkBox5.Checked == true)
            {
                richTextBox1.Text += "\n" + "- Todas";
            }

        }

        private void Form_encuesta_Load(object sender, EventArgs e)
        {
            comboBox2.Text = comboBox2.Items[2].ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 2023;
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Jose";
            textBox2.Text = "Abril";
            textBox3.Text = "García";
            dateTimePicker1.Value = new DateTime(1977, 05, 28);
            numericUpDown1.Value = 1977;
            comboBox1.Text = "Hamburguesa con papas";
            comboBox2.Text = comboBox2.Items[1].ToString();
            radioButton1.Checked = true;
            checkBox1.Checked = true;
            checkBox3.Checked = true;
        }
    }
}
