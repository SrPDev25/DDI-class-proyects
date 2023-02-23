using System;
using System.Configuration;

namespace examen2eva_daniel_ortega
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
}
