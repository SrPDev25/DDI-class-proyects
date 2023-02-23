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
using System.Windows.Forms.VisualStyles;

namespace examen2eva_daniel_ortega
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
            if (dateFin.Value < dateInicio.Value)
            {
                
                MessageBox.Show("Por favor, introduzca una fecha válida (La fecha de fin no puede ser menor que la de inicio)"//Cuerpo
                    , "¡Alerta!"//Titulo
                    , MessageBoxButtons.OK //Boton
                    , MessageBoxIcon.Warning);//Logo
            }
            else
            {
                
                dgvdata.Rows.Clear();

                //comprobación de que el número de empelado está vacío
                if (txtbusqueda.Text.Trim() == "")
                {
                    listarSinNumero();
                }
                else
                {
                    listar();
                }
                if (dgvdata.RowCount == 0)
                {
                    MessageBox.Show("No se han encontrado valores, o el empleado es inexistente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void listar()
        {
            try
            {
                //Inicia la conexión
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    int id = Convert.ToInt32(txtbusqueda.Text);

                    query.AppendLine("SELECT r.idregistro, a.alunum, a.aluNombre,c.cnombre, ");
                    query.AppendLine("CONVERT(NVARCHAR, r.regfechahora, 103) as fecha, ");
                    query.AppendLine("CONVERT(NVARCHAR, r.regfechahora, 8) as hora, ");
                    query.AppendLine("r.regtipomov AS tipoRegistro from registro r");
                    query.AppendLine("INNER join alumno a on r.idalumno = a.idalumno");//Conexiones 
                    query.AppendLine("INNER join curso c on c.idCurso = a.idCurso");//
                    query.AppendLine("where convert(varchar, regfechahora, 112) between Convert(datetime, @fechainicio, 112) and Convert(datetime, @fechafin, 112)");
                    query.AppendLine(" and a.alunum= "+id+"");
                    query.AppendLine("order by c.idcurso,fecha, a.idalumno, hora");

                    //convertir fechas seleccionadas a formato compatible consulta sql
                    //Formato 112
                    string finicio = dateInicio.Value.ToString("yyyyMMdd");
                    string ffin = dateFin.Value.ToString("yyyyMMdd");
                    

                    //Hay que insertar la query en  (comando SqlCommand)
                    //Se insertan en la query con el @
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@fechainicio", finicio);
                    cmd.Parameters.AddWithValue("@fechafin", ffin);
                    cmd.Parameters.AddWithValue("@idAlumno", id);
                    cmd.CommandType = System.Data.CommandType.Text;

                    //Lector simplemente
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //Siguiente linea
                        while (dr.Read())
                        {
                            //Añade a la tabla un objeto con los datos en el orden de la tabla
                            dgvdata.Rows.Add(new object[]
                            {
                                Convert.ToInt32(dr["idRegistro"]),
                                Convert.ToInt32(dr["alunum"]),
                                dr["alunombre"].ToString(),
                                dr["cnombre"].ToString(),
                                dr["fecha"].ToString(),
                                dr["hora"].ToString(),
                                dr["tipoRegistro"].ToString() == "1" ? "Entrada" : "Salida"
                            });
                        }
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en el acceso a la base de datos:" + e.Message, "Error");
            }
        }

        private void listarSinNumero()
        {
            
            try
            {
                //Inicia la conexión
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT r.idregistro, a.alunum, a.aluNombre,c.cnombre, ");
                    query.AppendLine("CONVERT(NVARCHAR, r.regfechahora, 103) as fecha, ");
                    query.AppendLine("CONVERT(NVARCHAR, r.regfechahora, 8) as hora, ");
                    query.AppendLine("r.regtipomov AS tipoRegistro from registro r");
                    query.AppendLine("INNER join alumno a on r.idalumno = a.idalumno");//Conexiones
                    query.AppendLine("INNER join curso c on c.idCurso = a.idCurso");//
                    //Usar el codigo 112 para comparar ya que tiene formato yyyymmdd
                    //busca los fichajes que se encuentren entre la fecha inicial y la final, los @ se solucionan luego
                    query.AppendLine("where convert(varchar, regfechahora, 112) between Convert(datetime, @fechainicio, 112) and Convert(datetime, @fechafin, 112)");
                    query.AppendLine("order by c.idcurso,fecha, a.idalumno, hora");

                    //convertir fechas seleccionadas a formato compatible consulta sql
                    //Formato 112
                    string finicio = dateInicio.Value.ToString("yyyyMMdd");
                    string ffin = dateFin.Value.ToString("yyyyMMdd");

                    //Hay que insertar la query en  (comando SqlCommand)
                    //Se insertan en la query con el @
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@fechainicio", finicio);
                    cmd.Parameters.AddWithValue("@fechafin", ffin);
                    cmd.CommandType = System.Data.CommandType.Text;

                    //Lector simplemente
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        //Siguiente linea
                        while (dr.Read())
                        {
                            //Añade a la tabla un objeto con los datos en el orden de la tabla
                            dgvdata.Rows.Add(new object[]
                            {
                                Convert.ToInt32(dr["idRegistro"]),
                                Convert.ToInt32(dr["alunum"]),
                                dr["alunombre"].ToString(),
                                dr["cnombre"].ToString(),
                                dr["fecha"].ToString(),
                                dr["hora"].ToString(),
                                dr["tipoRegistro"].ToString() == "1" ? "Entrada" : "Salida"
                            });
                        }
                    }
                }
            }
            catch (Exception e)
            {
                
                MessageBox.Show("Error en el acceso a la base de datos:" + e.Message, "Error");
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            dgvdata.Rows.Clear();
            txtbusqueda.Text = "";
        }
    }
}
