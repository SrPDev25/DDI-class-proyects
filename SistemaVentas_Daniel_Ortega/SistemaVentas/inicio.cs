using CapaEntidad;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class inicio : Form
    {
        private static Usuario usuarioActual;
        public inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;

            InitializeComponent();
        }

        private void menuUsuarios_Click(object sender, System.EventArgs e)
        {

        }
    }
}
