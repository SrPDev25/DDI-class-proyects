using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDI_Ejercicio2_Daniel_Ortega
{
    public partial class formReservas : Form
    {
        Dictionary<String,String> usuarios;
        
        public formReservas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] credenciales;
            panelReserva.Visible = false;
            String credencialProv = Properties.Resources.credenciales.ToString();
            credenciales = credencialProv.Split(new[] {";"}, StringSplitOptions.RemoveEmptyEntries);
            usuarios = new Dictionary<String,String>();
            int i=0;
            while (i < credenciales.Length)
            {
                usuarios.Add(credenciales[i], credenciales[i+1]);
                i += 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBoxUser.Text;
            String pass = textBoxPass.Text;
            String passCheck;
            if (usuarios.TryGetValue(user, out passCheck))
            {
                if (passCheck.Equals(pass))
                {
                    buttonSesion.Visible = false;
                }
            }
            else
            {
                ErrorProvider errorUser = new ErrorProvider();
                errorUser.SetError(textBoxUser, "Usuario o contraseña incorrectos");
            }
        }
    }
}
