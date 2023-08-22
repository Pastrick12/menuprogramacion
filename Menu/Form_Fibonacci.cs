using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgramacionOrientadaObjetos
{
    public partial class Form_Fibonacci : Form
    {
        public Form_Fibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int limite = Convert.ToInt32(textBox1.Text);
                
                if (limite < 0)
                {
                    MessageBox.Show("Los valores negativos no son válidos en esta serie.");
                }

                int a = 0, b = 1, c = 0;

                richTextBox1.Clear();

                for (; c <= limite;)
                {
                    c = a + b;
                    if (c <= limite)
                        richTextBox1.Text += a+" + " + b + " = " + c + "\n";
                    a = b;
                    b = c;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error", "Errorsito", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
        }
    }
}
