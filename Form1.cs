using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_en_C_sharp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "enter")
            {
                Form ti = new Tienda();
                this.Hide();
                ti.Show();
            }
            else
            {
                MessageBox.Show("INCORRECTO POR FAVOR CORRIJA DE NUEVO");
                TextBox1.Clear();
            }
        }
    }
}
