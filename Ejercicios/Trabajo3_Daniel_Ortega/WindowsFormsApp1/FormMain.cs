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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        Boolean[] isFine;
        String[] callesList;
        double[] precio;
        double[] precioBebidas;
        Visualizar visualizarForm;
        public FormMain()
        {
            InitializeComponent();
            isFine = new bool[] { false, false, false, false, false };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCiudad.Items.Add("Burgos");
            panelMenu.Visible = false;
            
        }


        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCiudad.SelectedIndex != -1)
            {
                fillAddressComboBox();
                isFine[3] = true;

            }
            else
            {
                isFine[3] = false;
                error.SetError(comboBoxCiudad, "Dato obligatorio");
            }
            CheckData();


        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxName, "");
            if (!IsAllNonDigits(textBoxName.Text))
            {
                isFine[0] = false;
                error.SetError(textBoxName, "Nombre no válido");
            }
            else
            {
                isFine[0] = true;

            }
            CheckData();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxNumber, "");
            if (textBoxNumber.Text.Length != 9 || !IsAllDigits(textBoxNumber.Text))
            {
                isFine[1] = false;
                error.SetError(textBoxNumber, "Telefono no válido");
            }
            else
            {
                isFine[1] = true;

            }
            CheckData();
        }

        private void comboBoxCalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            error.SetError(comboBoxCalle, "");
            if (comboBoxCalle.SelectedIndex == -1)
            {
                isFine[4] = false;
                error.SetError(comboBoxCalle, "Dato obligatorio");
            }
            else
            {
                isFine[4] = true;

            }
            CheckData();
        }

        private void textBoxAddressDetails_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxAddressDetails, "");
            if (textBoxAddressDetails.Text.Length == 0)
            {
                isFine[2] = false;
                error.SetError(textBoxAddressDetails, "Dato obligatório");
            }
            else
            {
                isFine[2] = true;
                CheckData();
            }
            CheckData();
        }

        /**
         * Comprueba que todos los datos están bien metidos
         */
        private void CheckData()
        {
            Boolean i = true;
            groupBoxRealizarPedido.Enabled = true;
            foreach (Boolean fine in isFine)
            {
                if (!fine)
                {

                    i = false;
                    break;
                }
            }
            if (groupBoxRealizarPedido.Enabled!=i)
            {
                groupBoxRealizarPedido.Enabled = i;
            }  
        }


        /**
         * LLena los comboBox de direcciones
         */
        private void fillAddressComboBox()
        {

            String calles = Properties.Resources.calles.ToString();
            callesList = calles.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (String calle in callesList)
            {
                comboBoxCalle.Items.Add(calle);
            }
        }

        /**
         * Se comprueba que todos los carácteres son numericos
         */
        bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        /**
         * Se comprueba que ningun caractes es numérico
         */
        bool IsAllNonDigits(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    return false;
            }
            return true;
        }


        private void btnGeneral_Click(object sender, EventArgs e)
        {
            //Se carga el panel introduciendo el menu correspondiente del recurso txt
            chargePanel(Properties.Resources.MenuNoVegano.ToString());
            //Se marcan que precios usa el menú
            precio = new Double[]{4.4d,5.5d,3d};

        }

        private void btnVegetal_Click(object sender, EventArgs e)
        {
            //Se carga el panel introduciendo el menu correspondiente del recurso txt
            chargePanel(Properties.Resources.MenuVegano.ToString());
            //Se marcan que precios usa el menú
            precio = new Double[] { 5.28d, 6.6d, 3.6d };
        }
        private void chargePanel(String menu)
        {
            //Saca la información de las bebidas
            String bebidas = Properties.Resources.bebidas.ToString();
            precioBebidas = new Double[] { 1d, 2d, 2.5d };
            //En el txt se separan primer, segundo y postre con ;
            String[] menus = menu.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            comboBoxPrimerPlato.Items.Clear();//Antes de rellenar el combo se vacía el anterior
            comboBoxPrimerPlato.Items.Add("Ninguno");//Se coloca un opción de ninguno
            comboBoxPrimerPlato.Select(0,0);//Se deja seleccionada la opción de ninguno
            //En el foreach se saca el Array del array antes creado
            foreach (String i in menus[0].Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries))
            {
                comboBoxPrimerPlato.Items.Add(i);
            }
            comboBoxSegundoPlato.Items.Clear();
            comboBoxSegundoPlato.Items.Add("Ninguno");
            comboBoxSegundoPlato.Select(0, 0);
            foreach (String i in menus[1].Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries))
            {
      
                comboBoxSegundoPlato.Items.Add(i);
            }
            comboBoxPostre.Items.Clear();
            comboBoxPostre.Items.Add("Ninguno");
            comboBoxPostre.Select(0, 0);
            foreach (String i in menus[2].Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries))
            {
                comboBoxPostre.Items.Add(i);
            }
            comboBoxBebida.Items.Clear();
            comboBoxBebida.Items.Add("Ninguno");
            comboBoxBebida.Select(0, 0);
            foreach (String i in bebidas.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries))
            {
                comboBoxBebida.Items.Add(i);
            }
            //Cambia un panel por el otro y cambia el tamaño del formulario
            panelAddress.Visible = false;
            panelMenu.Visible = true;
            Size = new Size(539, 419);
            //Añade la direccion
            setAddress();
        }

        /*
         * Indica la dirección indicada en el anterior panel
         */
        private void setAddress()
        {
            labelSetAddress.Text = comboBoxCiudad.Text + ", "+comboBoxCalle.Text+", "+textBoxAddressDetails.Text+"\n" +
                "Cliente: "+textBoxName.Text+", "+textBoxNumber.Text;
        }

        /**
         * Vuelve al panel login
         */
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panelAddress.Visible = true;
            panelMenu.Visible = false;
            Size = new Size(539, 353);
        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            Boolean fine= comboBoxPrimerPlato.SelectedIndex != 0 && comboBoxSegundoPlato.SelectedIndex != 0 && comboBoxBebida.SelectedIndex!=0;
            String primerPlato;
            String segundoPlato;
            String postre;
            String bebida;
            int bebidaSelected = comboBoxBebida.SelectedIndex-1;
            Double total;
            if (fine)
            {
                //Si no hay postre solo es la suma de los dos primeros platos
                if (comboBoxPostre.Text=="Ninguno")
                {
                    primerPlato = comboBoxPrimerPlato.Text + "  " + precio[0] + "€";
                    segundoPlato = comboBoxSegundoPlato.Text + "  " + precio[1] + "€";
                    bebida = comboBoxBebida.Text + " " + precioBebidas[bebidaSelected] + "€";
                    postre = comboBoxPostre.Text;
                    total = +precio[0] + precio[1] + precioBebidas[bebidaSelected];
                }
                //Si hay postre es la suma de los 3 platos
                else
                {
                    primerPlato = comboBoxPrimerPlato.Text + "  " + precio[0] + "€";
                    segundoPlato = comboBoxSegundoPlato.Text + "  " + precio[1] + "€";
                    bebida = comboBoxBebida.Text + " " + precioBebidas[bebidaSelected] + "€";
                    postre = comboBoxPostre.Text +"  "+ precio[2] + "€"  ;
                    total = +precio[0] + precio[1] + precio[2]+ precioBebidas[bebidaSelected];
                }

                if (checkBoxPan.Checked )
                {
                    total += 0.8d;
                }
                //Carga el form
                visualizarForm = new Visualizar(primerPlato, segundoPlato, postre,bebida, checkBoxPan.Checked, total);
                visualizarForm.Show();
            }
            
        }
    }

}
