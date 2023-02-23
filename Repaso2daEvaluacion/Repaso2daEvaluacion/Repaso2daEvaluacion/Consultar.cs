using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Repaso2daEvaluacion
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            //Ambos son dateTimePickers
            //Inicializa hambas fechas en la de hoy
            dateInicio.Value = DateTime.Now;
            dateFin.Value = dateInicio.Value;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            //control de fecha fin mayor que fecha inicio
            if(dateFin.Value < dateInicio.Value)
            {
                //Errorsito
                MessageBox.Show("Por favor, introduzca una fecha válida (La fecha de fin no puede ser menor que la de inicio)"//Cuerpo
                    , "¡Alerta!"//Titulo
                    , MessageBoxButtons.OK //Boton
                    , MessageBoxIcon.Warning);//Logo
            }
            else
            {
                //DataGrid es la tabla
                //vaciar datagrid por si tuviese datos anteriores
                dgvdata.Rows.Clear();

                //comprobación de que el número de empelado está vacío
                if(txtbusqueda.Text.Trim() == "")
                {
                    listarSinNumero();
                }
                else
                {
                    listar();
                }
                if(dgvdata.RowCount == 0)
                {
                    MessageBox.Show("No se han encontrado valores, o el empleado es inexistente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
                //Si no hay datos en la tabla no imprime nada
                if (dgvdata.Rows.Count < 1)
                {
                    MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Un objeto que interactua como los datos de una tabla
                    DataTable dt = new DataTable();

                    //Tipo de objeto DataGridViewColumn en todas las columnas de la tabla
                    foreach (DataGridViewColumn columna in dgvdata.Columns)
                    {
                        //Si la información de la tabla esxiste y es visible
                        if (columna.HeaderText != "" && columna.Visible)
                            //Guarda la columna en dt
                            //Coge el nombre de la columna y el tipo
                            dt.Columns.Add(columna.HeaderText, typeof(string));
                    }

                    //Coge linea por linea la información de cada linea
                    //Supongo que tiene que ir despues de fijar las columnas
                    foreach (DataGridViewRow row in dgvdata.Rows)
                    {
                        //Si "existe" la linea coge sus datos
                        if (row.Visible)
                            dt.Rows.Add(new object[] {
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString()
                        });
                    }
                    //El filtro
                    string finicio = dateInicio.Value.ToString("yyyyMMdd");
                    string ffin = dateFin.Value.ToString("yyyyMMdd");
                    
                    //Clase para que se guarde el documento?
                    SaveFileDialog savefile = new SaveFileDialog();
                    //Nombre del archivo XML
                    savefile.FileName = string.Format("InformeFichaje_{0}.xlsx", finicio + "-a-" + ffin);
                    //Formato del archivo
                    savefile.Filter = "Excel Files | *.xlsx";

                    //Que si da ok a descargar, descarga
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {

                        try
                        {
                            XLWorkbook wb = new XLWorkbook();
                            //Mete la tabla en la hoja, con nombre de página Informe
                            var hoja = wb.Worksheets.Add(dt, "Informe");
                            //Ajusta el tamaño de las celdas
                            hoja.ColumnsUsed().AdjustToContents();
                            //Guarda
                            wb.SaveAs(savefile.FileName);
                            //Mensajito
                            MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch
                        {
                            MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }

                }
        }
        /**
         * Obtiene todos
         */
        public void listarSinNumero()
        {
            List<Fichaje> lista = new List<Fichaje>();
            try
            {
                //Inicia la conexión
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT IdFichaje, empnum, empNombre, serNombre, ");//Select de datos de fichaje
                    query.AppendLine("CONVERT(NVARCHAR, ficfechahora, 103) as fecha, ");//De alguna manera obtiene la fecha de la fecha
                    query.AppendLine("CONVERT(NVARCHAR, ficfechahora, 8) as hora, ");//De alguna manera obtiene la hora de la fecha
                    query.AppendLine("fictipomov AS tipo from fichaje");//La ultima consulta + la tabla fichaje
                    query.AppendLine("INNER join personal on fichaje.IdEmpleado = personal.IdEmpleado");//Conexiones
                    query.AppendLine("INNER join servicio on personal.idServicio = servicio.idservicio");//
                    //Usar el codigo 112 para comparar ya que tiene formato yyyymmdd
                    //busca los fichajes que se encuentren entre la fecha inicial y la final, los @ se solucionan luego
                    query.AppendLine("where convert(varchar, ficfechahora, 112) between Convert(datetime, @fechainicio, 112) and Convert(datetime, @fechafin, 112)");
                    //Detalles
                    query.AppendLine("order by fecha, empnum, hora");

                    //convertir fechas seleccionadas a formato compatible consulta sql
                    //Formato 112
                    string finicio = dateInicio.Value.ToString("yyyyMMdd");
                    string ffin = dateFin.Value.ToString("yyyyMMdd");

                    //Hay que insertar la query en un cmd (comando SqlCommand)
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
                                Convert.ToInt32(dr["idFichaje"]),
                                Convert.ToInt32(dr["empnum"]),
                                dr["sernombre"].ToString(),
                                dr["empNombre"].ToString(),
                                dr["fecha"].ToString(),
                                dr["hora"].ToString(),
                                dr["tipo"].ToString() == "1" ? "Entrada" : "Salida"
                            });
                        }
                    }
                }
            }
            catch(Exception e)
            {
                lista = new List<Fichaje>();
                MessageBox.Show("Error en el acceso a la base de datos:" + e.Message, "Error");
            }
        }

        public void listar()
        {
            List<Fichaje> lista = new List<Fichaje>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT IdFichaje, empnum, empNombre, serNombre, ");
                    query.AppendLine("CONVERT(NVARCHAR, ficfechahora, 103) as fecha, ");
                    query.AppendLine("CONVERT(NVARCHAR, ficfechahora, 8) as hora, ");
                    query.AppendLine("fictipomov AS tipo from fichaje");
                    query.AppendLine("INNER join personal on fichaje.IdEmpleado = personal.IdEmpleado");
                    query.AppendLine("INNER join servicio on personal.idServicio = servicio.idservicio");
                    query.AppendLine("where convert(varchar, ficfechahora, 112) between Convert(datetime, @fechainicio, 112) and Convert(datetime, @fechafin, 112)");
                    query.AppendLine("and empnum = @numEmpleado");//Lo mismo pero mira que el numero coincida
                    query.AppendLine("order by fecha, empnum, hora");

                    //convertir fechas seleccionadas a formato compatible consulta sql
                    string finicio = dateInicio.Value.ToString("yyyyMMdd");
                    string ffin = dateFin.Value.ToString("yyyyMMdd");
                    int numEmpleado = Convert.ToInt32(txtbusqueda.Text);

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@fechainicio", finicio);
                    cmd.Parameters.AddWithValue("@fechafin", ffin);
                    cmd.Parameters.AddWithValue("@numEmpleado", numEmpleado);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgvdata.Rows.Add(new object[]
                            {
                                Convert.ToInt32(dr["idFichaje"]),
                                Convert.ToInt32(dr["empnum"]),
                                dr["sernombre"].ToString(),
                                dr["empNombre"].ToString(),
                                dr["fecha"].ToString(),
                                dr["hora"].ToString(),
                                dr["tipo"].ToString() == "1" ? "Entrada" : "Salida"
                            });
                        }
                    }
                }
            }
            catch (Exception e)
            {
                lista = new List<Fichaje>();
                MessageBox.Show("Error en el acceso a la base de datos:" + e.Message, "Error");
            }
        }

        public void limpiar()
        {
            dgvdata.Rows.Clear();
            txtbusqueda.Text = "";
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
