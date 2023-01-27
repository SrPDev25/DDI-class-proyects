

using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objd_usuario=new CD_Usuario();//DEFINIMOS NUESTRO OBJETO
        public List<Usuario> Listar()
        {
            return objd_usuario.Listar();
        }
    }
}
