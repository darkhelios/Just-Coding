using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace EjemploMySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataAdapter consulta;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexion = new MySqlConnection
                    ("server=127.0.0.1; database=Test; Uid=root;pwd=;");
                conexion.Open();
                string select = "SELECT * FROM articulos";
                consulta = new MySqlDataAdapter(select, conexion);
                ds = new DataSet();
                consulta.Fill(ds);
                dataGridView1.DataSource = ds.Tables["articulos"].DefaultView;
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error al establecer conexion con la base de datos " + error.Message);
            }
        }

        private DataSet cargarInfo()
        {
            string select = "SELECT * FROM articulos";
            consulta = new MySqlDataAdapter(select, conexion);
            ds = new DataSet();
            consulta.Fill(ds);
            return ds;
        }

        public int agregar(string articulo, double precio)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion;
            comando.CommandText = 
       "INSERT INTO articulos (articulo, precio) "
       + "VALUES (?articulo, ?precio)";
            comando.Parameters.Add("articulo", 
                MySqlDbType.VarChar, 255).Value = articulo;
            comando.Parameters.Add("precio", 
                MySqlDbType.Decimal, 10).Value = precio;
            int filas = comando.ExecuteNonQuery();
            return filas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string articulo = textBox1.Text;
            double precio = Double.Parse(textBox2.Text);
            int fila = agregar(articulo, precio);
            if (fila > 0)
            {
                dataGridView1.DataSource = cargarInfo().Tables[0]
                    .DefaultView;
                MessageBox.Show("Agregado a la base de datos");
            }
            else
            {
                MessageBox.Show("Error al agregar a la bd");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexion.Close();
        }
    }
}
