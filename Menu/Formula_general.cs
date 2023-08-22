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
    public partial class Formula_general : Form
    {
        public Formula_general()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);

                double x1 = (-b + Math.Sqrt((b*b) - (4*a*c)))/(2*a);
                double x2 = (-b - Math.Sqrt((b*b) - (4*a*c)))/(2*a);

                label4.Text = "X1 = " + x1;
                label6.Text = "X2 = " + x2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alguno de los datos no es válido");
            }
        }
    }
}
