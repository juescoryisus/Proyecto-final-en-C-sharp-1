using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_en_C_sharp_1
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
        }
        private string[] client = new string[11];
        private int[] code = new int[11];
        private string[] product = new string[11];
        private double[] price = new double[11];
        private string[] amoun = new string[11];

        private int i = 0;

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            // Obtener los valores de los TextBox
            int numero1 = int.Parse(lblprice.Text);
            int numero2 = int.Parse(txtcash.Text);

            // Realizar la multiplicación
            int resultado = numero1 * numero2;

            // Agregar el resultado al DataGridView


            client[i] = txtclient.Text;
            code[i] = lblcode.Text;
            product[i] = lblname.Text;
            price[i] = lblprice.Text;
            amoun[i] = txtcash.Text;

            Interaction.MsgBox("Su pedido" + (i) + "registrado");

            if (i == 10)
                Interaction.MsgBox("A llegado al limite de pedidos");
            else
                i = i + 1;


            dgvlist.Rows.Add(txtclient.Text, lblcode.Text, lblname.Text, "$" + lblprice.Text, txtcash.Text, resultado);


            lblcode.Text = "";
            lblname.Text = "";
            lblprice.Text = "";
            txtcash.Text = "";
            lblreturn.Text = "";


            obtenerTotal();
        }

        public void obtenerTotal()
        {
            float costot = 0;
            int contador = 0;
            contador = dgvlist.RowCount;

            for (int i = 0; i <= contador - 1; i++)
                costot += float.Parse(dgvlist.Rows(i).Cells(5).Value.ToString());

            lbltotaltoplay.Text = costot.ToString();
        }



        private void txtcash_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }




        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

    }
}


