using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2eva_daniel_ortega
{
    internal class Alumno
    {
        public int IdAlumno { get; set; }
        public int AlumnNum { get; set; }
        public string nombre { get; set; }
        public int idCurso { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public Boolean estado { get; set; }
        public string fechaCreacion { get; set; }
    }
}
