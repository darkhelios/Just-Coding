using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasteleria
{
    public partial class Form1 : Form
    {

        string[] eventos = { "Boda", "Quinceañera", "Graduacion" };
        string[][] menus = { new string[3], new string[4], new string[3] };
        string[][] decoraciones = { new string[3], new string[4], new string[3] };
        string[][] fotos = { new string[3], new string[4], new string[3] };
        double[][] preciomenu = { new double[3], new double[4], new double[3] };
        double[][] preciodeco = { new double[3], new double[4], new double[3] };
        double[][] preciofoto = { new double[3], new double[4], new double[3] };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Area de Menus
            menus[0] = new string[] { "Barbacoa", "Pechuga", "Ensalada" };
            preciomenu[0] = new double[] { 400, 500, 700 };

            menus[1] = new string[] { "Menudo", "Carne Asada", "Pollo Asado", "Pozole" };
            preciomenu[1] = new double[] { 550, 650, 600, 700 };

            menus[2] = new string[] { "Botanas", "Plato Fuerte", "Ensalada" };
            preciomenu[2] = new double[] { 300, 800, 700 };

            //Area Decoracion
            decoraciones[0] = new string[] { "Blanco", "Turqueza", "Cyan" };
            preciodeco[0] = new double[] { 4000, 5000, 7000 };

            decoraciones[1] = new string[] { "Rojo", "Azul", "Morado", "Verde" };
            preciodeco[1] = new double[] { 5500, 6500, 6000, 7000 };

            decoraciones[2] = new string[] { "Chedron", "Plateado", "Dorado" };
            preciodeco[2] = new double[] { 3000, 8000, 7000 };

            //Area Fotos
            fotos[0] = new string[] { "Paquete 1", "Paquete 2", "Paquete 3" };
            preciofoto[0] = new double[] { 1400, 1500, 1700 };

            fotos[1] = new string[] { "Paquete 1", "Paquete 2", "Paquete 3", "Paquete 4" };
            preciofoto[1] = new double[] { 2550, 2650, 2600, 1700 };

            fotos[2] = new string[] { "Paquete 1", "Paquete 2", "Paquete 3" };
            preciofoto[2] = new double[] { 2500, 2000, 1700 };

            foreach (string evento in eventos)
            {
                cbEvento.Items.Add(evento);
            }

        }

        private void cbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMenu.Items.Clear();
            cbMenu.ResetText();
            cbDecoracion.Items.Clear();
            cbDecoracion.ResetText();
            cbFoto.Items.Clear();
            cbFoto.ResetText();

            foreach (string menu in menus[cbEvento.SelectedIndex])
            {

                cbMenu.Items.Add(menu);

            }

            foreach (string decoracion in decoraciones[cbEvento.SelectedIndex])
            {

                cbDecoracion.Items.Add(decoracion);

            }

            foreach (string foto in fotos[cbEvento.SelectedIndex])
            {

                cbFoto.Items.Add(foto);

            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbEvento.SelectedItem != null &&
                    cbMenu.SelectedItem != null &&
                    cbDecoracion.SelectedItem != null &&
                    cbFoto.SelectedItem != null)
                {
                    if (tbNombre.Text == "")
                    {
                        MessageBox.Show(" Llene todas los campos ");
                    }
                    else {


                    string nombre = tbNombre.Text;
                    string invitados = tbInvitados.Text;
                    double numinv = Double.Parse(tbInvitados.Text);
                    double renta = 13000;
                    double adicional = 1000;
                    double carginv = 2000;
                    int eventoi = cbEvento.SelectedIndex;
                    int menui = cbMenu.SelectedIndex;
                    int decoracioni = cbDecoracion.SelectedIndex;
                    int fotoi = cbFoto.SelectedIndex;
                    double precio1 = preciomenu[eventoi][menui];
                    double precio2 = preciodeco[eventoi][decoracioni];
                    double precio3 = preciofoto[eventoi][fotoi];
                    DateTime fecha = mcCalendario.SelectionEnd;

                    if(fecha.DayOfWeek == DayOfWeek.Monday ||
                        fecha.DayOfWeek == DayOfWeek.Thursday ||
                        fecha.DayOfWeek == DayOfWeek.Tuesday ||
                        fecha.DayOfWeek == DayOfWeek.Wednesday ||
                        fecha.DayOfWeek == DayOfWeek.Friday)
                    {
                        if ( numinv <= 300)
                        {
                            double total = renta + precio1 + precio2 + precio3;
                            MessageBox.Show("Nombre: " + nombre +
                            "\nFecha de Evento: " + fecha +
                            "\n\nNo. de Invitados: " + invitados +
                            "\n\nRenta del Local: " + renta +
                            "\nPrecio de Menu: " + precio1 +
                            "\nPrecio de Decoracion: " + precio2 +
                            "\nPrecio de Fotos: " + precio3 +
                            "\n\nTotal a pagar: " + total);
                        }
                        else
                        {
                            double total = renta + precio1 + precio2 + precio3+ carginv;
                            MessageBox.Show("Nombre: " + nombre +
                            "\nFecha de Evento: " + fecha +
                            "\n\nNo. de Invitados: " + invitados +
                            "\n\nRenta del Local: " + renta +
                            "\nPrecio de Menu: " + precio1 +
                            "\nPrecio de Decoracion: " + precio2 +
                            "\nPrecio de Fotos: " + precio3 +
                            "\nCargo por exceso de invitados: " +carginv+
                            "\n\nTotal a pagar: " + total);
                        }
                        
                    }
                    else
                    {
                        if (numinv <= 300)
                        {
                            
                            double total = renta + precio1 + precio2 + precio3+ adicional;
                            MessageBox.Show("Nombre: " + nombre +
                            "\nFecha de Evento: " + fecha +
                            "\n\nNo. de Invitados: " + invitados +
                            "\n\nRenta del Local: " + renta +
                            "\nPrecio de Menu: " + precio1 +
                            "\nPrecio de Decoracion: " + precio2 +
                            "\nPrecio de Fotos: " + precio3 +
                            "\n\nAdicional por Fin de Semana: " + adicional +
                            "\n\nTotal a pagar: " + total);
                        }
                        else
                        {
                            double total = renta + precio1 + precio2 + precio3 + carginv+ adicional;
                            MessageBox.Show("Nombre: " + nombre +
                            "\nFecha de Evento: " + fecha +
                            "\n\nNo. de Invitados: " + invitados +
                            "\n\nRenta del Local: " + renta +
                            "\nPrecio de Menu: " + precio1 +
                            "\nPrecio de Decoracion: " + precio2 +
                            "\nPrecio de Fotos: " + precio3 +
                            "\nCargo por exceso de invitados: " + carginv +
                            "\n\nAdicional por Fin de Semana: " + adicional +
                            "\n\nTotal a pagar: " + total);
                        }

                    }

                    }
                }
                else
                {
                    MessageBox.Show(" Llene todas los campos ");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(" Llene todas los campos ");

            }

        }

    }

}
