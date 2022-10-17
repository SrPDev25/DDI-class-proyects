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
using System.Windows.Forms.VisualStyles;

namespace DDI_Ejercicio2_Daniel_Ortega
{
    public partial class formReservas : System.Windows.Forms.Form
    {
        Dictionary<String,String> usuarios;
        ErrorProvider errorUser;


        public formReservas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] credenciales;
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
                    
                    try
                    {
                        errorUser.Dispose();
                    }
                    catch(NullReferenceException ex)
                    {
                        
                    }
                    this.Visible = false;

                }
            }
            else
            {
                errorUser = new ErrorProvider();
                errorUser.SetError(textBoxUser, "Usuario o contraseña incorrectos");
            }
        }
    }
}
