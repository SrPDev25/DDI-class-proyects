using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                try
                {
                    //StringBuilder query=new StringBuilder();
                    string query = "SELECT IdUsuario, Documento,NombreCompleto,Clave,Estado,Correo from usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });

                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            return lista;
        }

    }
}
