using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace EjemploBD
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlCommandBuilder comando2;
        SqlDataAdapter consulta;
        DataSet resultado;
        public Form1()
        {
            InitializeComponent();
            try
            {
                string con = ConfigurationManager.
    ConnectionStrings["EjemploBD.Properties.Settings.bdclientes"].
    ToString();
                conexion = new SqlConnection(con);
                conexion.Open();
            }
            catch (Exception e)
            {
            MessageBox.Show("Error al establecer conexion con la bd");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                comando = new SqlCommand("INSERT INTO Clientes "
                    + " (nombre, paterno, materno, telefono, " 
                    + "celular, estado, ciudad) VALUES "
                    + "(@nombre, @paterno, @materno, @telefono,"
                    + "@celular, @estado, @ciudad)", conexion);
                comando.CommandType = CommandType.Text;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = txtnombre.Text;
                comando.Parameters.Add("@paterno", SqlDbType.VarChar, 50).Value = txtpaterno.Text;
                comando.Parameters.Add("@materno", SqlDbType.VarChar, 50).Value = txtmaterno.Text;
                comando.Parameters.Add("@telefono", SqlDbType.NChar, 10).Value = txttelefono.Text;
                comando.Parameters.Add("@celular", SqlDbType.NChar, 10).Value = txtcelular.Text;
                comando.Parameters.Add("@estado", SqlDbType.Int).Value = Convert.ToInt32(cbestado.SelectedValue.ToString());
                comando.Parameters.Add("@ciudad", SqlDbType.Int).Value = Convert.ToInt32(cbciudad.SelectedValue.ToString());
                int numfilas = comando.ExecuteNonQuery();
                if (numfilas > 0)
                {
                    lbResultado.Text = "Agregado a la bd";
                }
                else
                {
                    lbResultado.Text = "Error al insertar en la bd";
                }
            } catch (Exception er) {
                MessageBox.Show("Error al insertar en la bd" + er.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet1.Estado' table. You can move, or remove it, as needed.
            this.estadoTableAdapter.Fill(this.masterDataSet1.Estado);
            // TODO: This line of code loads data into the 'masterDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.masterDataSet.Clientes);
            try
            {
                consulta = new SqlDataAdapter("SELECT * FROM Clientes", conexion);
                resultado = new DataSet();
                consulta.Fill(resultado, "Clientes");
                dataGridView1.DataSource = resultado.Tables[0].DefaultView;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener los datos de la base de datos.");
            }
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*consulta = new SqlDataAdapter("SELECT * FROM Ciudad " 
            + " WHERE estadoid = '" + cbestado.SelectedValue.ToString() 
            + "'", conexion);
            resultado = new DataSet();
            consulta.Fill(resultado);
            cbciudad.DisplayMember = "ciudad";
            cbciudad.ValueMember = "ciudadid";
            cbciudad.DataSource = resultado.Tables[0].DefaultView;*/
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                comando2 = new SqlCommandBuilder(consulta);
                consulta.Update(resultado, "Clientes");
                lbResultado.Text = "Actualizado a la bd";
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al actualizar la información.");
            }
        }
    }
}
