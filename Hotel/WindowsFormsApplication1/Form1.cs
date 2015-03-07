using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void calcularBtn_Click(object sender, EventArgs e)
        {
            int dias = Int32.Parse(numeroCb.SelectedItem.ToString());
            double precio = Double.Parse(precioTxt.Text);
            double subtotal = dias * precio;
            double descuento = 0;
            double total = 0;

            if (dias > 3 && dias < 5)
            {
                descuento = subtotal * .10;
            }
            else if (dias > 5 && dias < 10)
            {
                descuento = subtotal * .15;
            }
            else if (dias >= 10)
            {
                descuento = subtotal * 0.2;
            }

            total = subtotal - descuento;

            MessageBox.Show("El subtotal es: " + subtotal + "\nEl descuento es: "
                + descuento + "\nEl total es: " + total);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 16; i++)
            {
                numeroCb.Items.Add(i);

            }
        }
    }
}
