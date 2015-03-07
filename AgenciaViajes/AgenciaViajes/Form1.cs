using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes
{
    public partial class Form1 : Form
    {
        string[] destinos = { "Puerto Peñasco", "Puerto Vallarta", "Cancun", "Huatulco" };
        string[][] hoteles = { new string[3], new string[4], new string[6], new string[2] };
        double[][] precioh = { new double[3], new double[4], new double[6], new double[2] };
        ComboBox[] camasarray = new ComboBox[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hoteles[0] = new string[] { "La Rumoroza", "El Centauro", "Holiday Inn" };
            precioh[0] = new double[] { 400, 500, 700 };

            hoteles[1] = new string[] { "Hotel Sonora", "Fiesta Americana", "Hotel Cuernavaca", 
                                         "Hotel la Montolla"};
            precioh[1] = new double[] { 550, 650, 600, 700 };

            hoteles[2] = new string[] {"Hotel Hermanos", "Hotel Panamericano", "Hotel Maria", "Hotel Larrea", 
                                       "Hotel Marfil","Hotel Merlin"};
            precioh[2] = new double[] { 1300, 1500, 1700, 2000, 2300, 2700 };

            hoteles[3] = new string[] { "Hotel Playa Blanca", "Hotel la Arena" };
            precioh[3] = new double[] { 400, 500 };

            foreach (string destino in destinos)
            {
                destinoCb.Items.Add(destino);
            }
        }

        private void destinoCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotelCb.Items.Clear();
            hotelCb.ResetText();
            foreach (string hotel in hoteles[destinoCb.SelectedIndex])
            {
                hotelCb.Items.Add(hotel);
            }
        }

        private void cuartosCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selec = Int32.Parse(
                cuartosCb.SelectedItem.ToString()) - 1;
            for (int i = 0; i < selec; i++)
            {
                if (camasarray[i] == null)
                {
                    camasarray[i] = new ComboBox();
                    camasarray[i].Location = 
                        new Point(196 + i * 65, 272);
                    camasarray[i].Size = new Size(62, 21);
                    groupBox1.Controls.Add(camasarray[i]);
                    for (int j = 1; j < 4; j++)
                    {
                        camasarray[i].Items.Add(j);
                    }
                }
            }
                for (int i = selec; i < camasarray.Length; i++)
                {
                    if (camasarray[i] != null)
                    {
                        camasarray[i].Dispose();
                    }
                }
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            int hoteli = hotelCb.SelectedIndex;
            int destinoi = destinoCb.SelectedIndex;
            double precio = precioh[destinoi][hoteli];
            string hotel = hotelCb.SelectedItem.ToString();
            string destino = destinoCb.SelectedItem.ToString();
            DateTime fechaini = fechas.SelectionStart;
            DateTime fechafin = fechas.SelectionEnd;
            TimeSpan dif = fechafin - fechaini;
            int dias = dif.Days;
      
            int cuartos = Int32.Parse(
                cuartosCb.SelectedItem.ToString());
            int cama1 = Int32.Parse(
                camasCb.SelectedItem.ToString());
            int[] numcamas = new int[cuartos - 1];
            if (cuartos > 1)
            {
                for (int i = 0; i < cuartos - 1; i++)
                {
                    numcamas[i] = Int32.Parse(
                        camasarray[i].SelectedItem.ToString());
                }
            }
            double agregar = 0;
            if (cama1 > 1)
            {
                agregar = (cama1 - 1) * 200;
            }
            for (int i = 0; i < numcamas.Length; i++) {
                if (numcamas[i] > 1)
                {
                    agregar = (numcamas[i] - 1) * 200;
                }
            }
            double total = precio * dias * cuartos + agregar;
            MessageBox.Show("El total a pagar por " + 
                            cuartos + " cuartos, " +
                            dias + " dias " +
                            " es de: " + total);
        }
    }
}
