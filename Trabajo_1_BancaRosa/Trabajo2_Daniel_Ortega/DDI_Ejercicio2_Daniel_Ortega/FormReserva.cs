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
        Dictionary<String, String> usuarios;
        String[] horas;
        List<String> happyUsers;
        String currentUser;
        List<Sala> salas;
        List<Comida> comidas;
        List<Comida> bebidas;
        ErrorProvider errorUser;
        Boolean[] horasSala;
        Boolean comidaSeleccionada = false;
        ErrorProvider errorSeleccion;



        public formReservas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] credenciales;
            String credencialProv = Properties.Resources.credenciales.ToString();
            credenciales = credencialProv.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            usuarios = new Dictionary<String, String>();
            happyUsers = new List<string>();
            int i = 0;
            while (i < credenciales.Length)
            {
                usuarios.Add(credenciales[i], credenciales[i + 1]);
                i += 2;
            }

            horas = new String[] {"8:00-9:00", "9:00-10:00", "10:00-11:00", "11:00-12:00", "12:00-13:00",
            "13:00-14:00", "14:00-15:00", "15:00-16:00", "16:00-17:00" };
            cargarComidas();
            cargarSalas();


            panelSala.Visible = false;
            this.Size = new Size(349, 250);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBoxUser.Text;
            String pass = textBoxPass.Text;
            String passCheck;
            if (usuarios.TryGetValue(user, out passCheck))
            {
                if (!happyUsers.Contains(user))
                {
                    if (passCheck.Equals(pass))
                    {
                        panelSesion.Visible = false;
                        panelSala.Visible = true;
                        labelHola.Text = "Hola, " + user;
                        this.Size = new Size(500, 366);
                        currentUser = user;
                        cargarDatosPanel();
                    }
                }
                else
                {
                    errorUser = new ErrorProvider();
                    errorUser.SetError(textBoxUser, "Este usuario ya ha reservado");
                }
            }
            else
            {
                errorUser = new ErrorProvider();
                errorUser.SetError(textBoxUser, "Usuario o contraseña incorrectos");
            }
        }
        private void cargarSalas()
        {
            salas = new List<Sala>();
            salas.Add(new Sala("Sala 1", 8));
            salas.Add(new Sala("Sala 2", 10));
            salas.Add(new Sala("Comedor", 20, new int[] { 5, 6, 7 }));//Ocupa las horas indicadas del comedor

        }

        private void cargarComidas()
        {
            comidas = new List<Comida>();
            bebidas = new List<Comida>();
            comidas.Add(new Comida("Cjuasan", 1));
            comidas.Add(new Comida("Jamón", 1.5));
            comidas.Add(new Comida("Vegetal", 2));
            bebidas.Add(new Comida("Agua", 0.5));
            bebidas.Add(new Comida("Cafe o Leche", 1));
            bebidas.Add(new Comida("Zumo de naranja", 2));
            
        }

        private void cargarDatosPanel()
        {
            comboBoxSalas.Items.Clear();
            comboBoxHoras.Items.Clear();
            comboBoxBebida.Items.Clear();
            comboBoxComida.Items.Clear();
            if (errorSeleccion!=null)
            {
                errorSeleccion.Dispose();
            }
            
            errorSeleccion = new ErrorProvider();
            foreach (Sala i in salas)
            {
                comboBoxSalas.Items.Add(i.GetNombre());
            }
            foreach (Comida comid in comidas)
            {
                comboBoxComida.Items.Add(comid.GetNombre());
            }
            foreach (Comida comid in bebidas)
            {
                comboBoxBebida.Items.Add(comid.GetNombre());
            }
            


        }

        private void cleanReserva()
        {
            textBoxPersonas.Text = "";
            
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = comboBoxSalas.SelectedIndex;

            comboBoxHoras.Items.Clear();
            horasSala = salas.ElementAt(pos).getHoras();
            for (int i = 0; i < horas.Length; i++)
            {
                if (!horasSala[i])
                {
                    comboBoxHoras.Items.Add(horas[i]);
                }
                else
                {
                    comboBoxHoras.Items.Add("Reservada");
                }

            }

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panelSala.Visible = false;
            panelSesion.Visible = true;
            this.Size = new Size(349, 250);
        }

        private void buttonReserva_Click(object sender, EventArgs e)
        {
            Boolean fine = true;
            int personas = Int32.Parse(textBoxPersonas.Text);

            if (comboBoxHoras.SelectedIndex < 0 || comboBoxSalas.SelectedIndex < 0 || horasSala[comboBoxHoras.SelectedIndex])
            {
                fine = false;
            }
            else
            {
                errorSeleccion.SetError(comboBoxHoras, "Seleccione una hora y una sala disponible");
            }

            if (personas == 0 && personas <= salas.ElementAt(comboBoxSalas.SelectedIndex).getAforo())
            {
                fine = false;
            }
            else
            {
                errorSeleccion.SetError(textBoxPersonas, "Indique el número de personas válido");
            }





            if (fine)
            {
                errorSeleccion.Clear();
                salas.ElementAt(comboBoxSalas.SelectedIndex).Reservar(comboBoxHoras.SelectedIndex);
                happyUsers.Add(currentUser);
                panelSala.Visible = false;
                panelSesion.Visible = true;
                this.Size = new Size(349, 250);
            }

        }

        private void comboBoxComida_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (comprobacionComida())
                {
                    errorSeleccion.SetError(comboBoxComida, "Limite de precio pasado");
                }
            
        }

        private void comboBoxBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (comprobacionComida())
                {
                    errorSeleccion.SetError(comboBoxComida, "Limite de precio pasado");
                }
            
        }
        private Boolean comprobacionComida()
        {
            Boolean pasadoLimite = false;
            double comida;
            double bebida;

            if (comboBoxComida.SelectedIndex >= 0)
            {
                comida = comidas.ElementAt(comboBoxComida.SelectedIndex).GetPrecio();
            }
            else
            {
                comida = 0;
            }

            if (comboBoxBebida.SelectedIndex >= 0)
            {
                bebida = comidas.ElementAt(comboBoxBebida.SelectedIndex).GetPrecio();
            }
            else
            {
                bebida = 0;
            }


            if (2.5 < (comida + bebida))
            {
                pasadoLimite = true;
            }

            return pasadoLimite;
        }
    }
}

