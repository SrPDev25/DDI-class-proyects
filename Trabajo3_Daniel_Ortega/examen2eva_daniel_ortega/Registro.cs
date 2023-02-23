using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen2eva_daniel_ortega
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (!(rbEntrada.Checked || rbSalida.Checked))
            {
                MessageBox.Show("Selecciona un valor, por favor", "Aviso", MessageBoxButtons.OK);
            }
            else
            {
                int numero = 0;
                if (txtNumAlumno.Text.Trim() == "" || int.TryParse(txtNumAlumno.Text, out numero) == false) //Esto comprueba si lo introducido es numérico o no está vacío
                {
                    MessageBox.Show("Introduzca un número válido, o el nombre del alumno a buscar", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    int resulado = registrar();
                    if (resulado == 1)
                    {
                        mensaje = "Registro realizado con éxito";
                    }
                    else
                    {
                        mensaje = "No se ha podido registrar el registro. Comprueba el número de alumno introducido";
                    }
                    labelError.Text = mensaje.ToString();
                }
            }
        }

        private int registrar()
        {
            int rows = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    
                    query.AppendLine("insert into registro(idAlumno, regtipomov)");
                    query.AppendLine("values ((select idalumno from alumno where alunum = convert(int,@numAlumno)), @acceso)");

                    
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numAlumno", txtNumAlumno.Text);
                    cmd.Parameters.AddWithValue("@acceso", rbEntrada.Checked == true ? "1" : "0");
                    rows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de acceso a la base de datos: " + e.Message);
            }
            return rows;  
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    
                    string query = "select alunum from dbo.alumno where alunombre=@nombre";

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                        while (dr.Read())
                        {
                            txtNumAlumno.Text = dr["alunum"].ToString();
                        }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de acceso a la base de datos: ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            String time = DateTime.Now.ToString();
            time = time.Split(' ')[1];
            time = time.Split(':')[0];
            try {
                int hora = Convert.ToInt32(time);

                if (hora==9||hora==16)
                {
                    rbEntrada.Checked = true;
                }
                else
                {
                    rbSalida.Checked = true;
                }
            } catch(Exception ex)
            {

            }
        }
    }
}
