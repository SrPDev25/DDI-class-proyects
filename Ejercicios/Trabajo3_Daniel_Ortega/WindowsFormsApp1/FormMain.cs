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

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        Boolean[] isFine;
        String[] callesList;
        public FormMain()
        {
            InitializeComponent();
            isFine = new bool[] {false,false,false,false,false};
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxCiudad.Items.Add("Burgos");
            panelMenu.Visible=false;
        }

        
        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCiudad.SelectedIndex!=-1)
            {
                fillComboBox();
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

        private void CheckData()
        {
            groupBoxRealizarPedido.Enabled = true;
            foreach (Boolean fine in isFine)
            {
                if (!fine)
                {
                    groupBoxRealizarPedido.Enabled = false;
                    break;
                }
            }
            
            
        }

        

        private void fillComboBox()
        {
            
            String calles = Properties.Resources.calles.ToString();
            callesList = calles.Split(new[] {"/"}, StringSplitOptions.RemoveEmptyEntries);
            foreach (String calle in callesList)
            {
                comboBoxCalle.Items.Add(calle);
            }
        }

        bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        bool IsAllNonDigits(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {

        }

        private void btnVegetal_Click(object sender, EventArgs e)
        {
            panelAddress.Visible=false;
            panelMenu.Visible=true;
            setAddress();
        }

        private void setAddress()
        {
            labelSetAddress.Text = comboBoxCiudad.Items+" ";
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            panelAddress.Visible = true;
            panelMenu.Visible = false;
        }
    }

}
