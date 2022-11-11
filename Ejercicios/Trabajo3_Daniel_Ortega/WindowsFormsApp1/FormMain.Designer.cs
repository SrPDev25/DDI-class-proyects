namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxRealizarPedido = new System.Windows.Forms.GroupBox();
            this.btnVegetal = new System.Windows.Forms.Button();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.textBoxAddressDetails = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCalle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonVisualizar = new System.Windows.Forms.Button();
            this.buttonRealizarPedido = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelSetAddress = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxSegundoPlato = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxPrimerPlato = new System.Windows.Forms.ComboBox();
            this.comboBoxPostre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxRealizarPedido.SuspendLayout();
            this.panelAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.kebab;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnGeneral
            // 
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnGeneral.Location = new System.Drawing.Point(19, 52);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(106, 29);
            this.btnGeneral.TabIndex = 2;
            this.btnGeneral.Text = "GENERAL";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(177, 111);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCiudad.TabIndex = 4;
            this.comboBoxCiudad.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiudad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kebab Express";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(177, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 100);
            this.panel1.TabIndex = 7;
            // 
            // groupBoxRealizarPedido
            // 
            this.groupBoxRealizarPedido.Controls.Add(this.btnVegetal);
            this.groupBoxRealizarPedido.Controls.Add(this.btnGeneral);
            this.groupBoxRealizarPedido.Enabled = false;
            this.groupBoxRealizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRealizarPedido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxRealizarPedido.Location = new System.Drawing.Point(345, 38);
            this.groupBoxRealizarPedido.Name = "groupBoxRealizarPedido";
            this.groupBoxRealizarPedido.Size = new System.Drawing.Size(142, 143);
            this.groupBoxRealizarPedido.TabIndex = 8;
            this.groupBoxRealizarPedido.TabStop = false;
            this.groupBoxRealizarPedido.Text = "Realizar pedido";
            // 
            // btnVegetal
            // 
            this.btnVegetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVegetal.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnVegetal.Location = new System.Drawing.Point(19, 87);
            this.btnVegetal.Name = "btnVegetal";
            this.btnVegetal.Size = new System.Drawing.Size(106, 29);
            this.btnVegetal.TabIndex = 3;
            this.btnVegetal.Text = "VEG-ANO";
            this.btnVegetal.UseVisualStyleBackColor = true;
            this.btnVegetal.Click += new System.EventHandler(this.btnVegetal_Click);
            // 
            // panelAddress
            // 
            this.panelAddress.Controls.Add(this.textBoxAddressDetails);
            this.panelAddress.Controls.Add(this.label9);
            this.panelAddress.Controls.Add(this.label7);
            this.panelAddress.Controls.Add(this.comboBoxCalle);
            this.panelAddress.Controls.Add(this.label6);
            this.panelAddress.Controls.Add(this.label5);
            this.panelAddress.Controls.Add(this.label4);
            this.panelAddress.Controls.Add(this.label3);
            this.panelAddress.Controls.Add(this.textBoxNumber);
            this.panelAddress.Controls.Add(this.label2);
            this.panelAddress.Controls.Add(this.comboBoxCiudad);
            this.panelAddress.Controls.Add(this.groupBoxRealizarPedido);
            this.panelAddress.Controls.Add(this.textBoxName);
            this.panelAddress.Location = new System.Drawing.Point(0, 106);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(524, 207);
            this.panelAddress.TabIndex = 9;
            // 
            // textBoxAddressDetails
            // 
            this.textBoxAddressDetails.Location = new System.Drawing.Point(177, 165);
            this.textBoxAddressDetails.Name = "textBoxAddressDetails";
            this.textBoxAddressDetails.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddressDetails.TabIndex = 20;
            this.textBoxAddressDetails.TextChanged += new System.EventHandler(this.textBoxAddressDetails_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(26, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Puerta, piso, letra... *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(120, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Calle *";
            // 
            // comboBoxCalle
            // 
            this.comboBoxCalle.FormattingEnabled = true;
            this.comboBoxCalle.Location = new System.Drawing.Point(177, 138);
            this.comboBoxCalle.Name = "comboBoxCalle";
            this.comboBoxCalle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCalle.TabIndex = 15;
            this.comboBoxCalle.SelectedIndexChanged += new System.EventHandler(this.comboBoxCalle_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(107, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ciudad *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(144, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(128, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Datos personales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(95, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefono *";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(177, 65);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 10;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre y apellidos *";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonVolver);
            this.panelMenu.Controls.Add(this.buttonVisualizar);
            this.panelMenu.Controls.Add(this.buttonRealizarPedido);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Location = new System.Drawing.Point(3, 106);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(518, 204);
            this.panelMenu.TabIndex = 21;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(256, 151);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(135, 43);
            this.buttonVolver.TabIndex = 19;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonVisualizar
            // 
            this.buttonVisualizar.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisualizar.Location = new System.Drawing.Point(256, 103);
            this.buttonVisualizar.Name = "buttonVisualizar";
            this.buttonVisualizar.Size = new System.Drawing.Size(135, 45);
            this.buttonVisualizar.TabIndex = 18;
            this.buttonVisualizar.Text = "Visualizar";
            this.buttonVisualizar.UseVisualStyleBackColor = false;
            // 
            // buttonRealizarPedido
            // 
            this.buttonRealizarPedido.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonRealizarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRealizarPedido.Location = new System.Drawing.Point(397, 107);
            this.buttonRealizarPedido.Name = "buttonRealizarPedido";
            this.buttonRealizarPedido.Size = new System.Drawing.Size(111, 84);
            this.buttonRealizarPedido.TabIndex = 17;
            this.buttonRealizarPedido.Text = "Realizar pedido";
            this.buttonRealizarPedido.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tomato;
            this.panel5.Controls.Add(this.labelSetAddress);
            this.panel5.Location = new System.Drawing.Point(256, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 89);
            this.panel5.TabIndex = 16;
            // 
            // labelSetAddress
            // 
            this.labelSetAddress.AutoSize = true;
            this.labelSetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSetAddress.Location = new System.Drawing.Point(16, 10);
            this.labelSetAddress.Name = "labelSetAddress";
            this.labelSetAddress.Size = new System.Drawing.Size(54, 18);
            this.labelSetAddress.TabIndex = 0;
            this.labelSetAddress.Text = "label12";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Controls.Add(this.comboBoxSegundoPlato);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.comboBoxPrimerPlato);
            this.panel4.Controls.Add(this.comboBoxPostre);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(26, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 189);
            this.panel4.TabIndex = 15;
            // 
            // comboBoxSegundoPlato
            // 
            this.comboBoxSegundoPlato.FormattingEnabled = true;
            this.comboBoxSegundoPlato.Location = new System.Drawing.Point(57, 99);
            this.comboBoxSegundoPlato.Name = "comboBoxSegundoPlato";
            this.comboBoxSegundoPlato.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSegundoPlato.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(20, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Postre";
            // 
            // comboBoxPrimerPlato
            // 
            this.comboBoxPrimerPlato.FormattingEnabled = true;
            this.comboBoxPrimerPlato.Location = new System.Drawing.Point(57, 38);
            this.comboBoxPrimerPlato.Name = "comboBoxPrimerPlato";
            this.comboBoxPrimerPlato.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrimerPlato.TabIndex = 1;
            // 
            // comboBoxPostre
            // 
            this.comboBoxPostre.FormattingEnabled = true;
            this.comboBoxPostre.Location = new System.Drawing.Point(57, 156);
            this.comboBoxPostre.Name = "comboBoxPostre";
            this.comboBoxPostre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPostre.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(20, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Primer plato*";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(20, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Extra*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(523, 315);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelAddress);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Kebab Express pedidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxRealizarPedido.ResumeLayout(false);
            this.panelAddress.ResumeLayout(false);
            this.panelAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxRealizarPedido;
        private System.Windows.Forms.Button btnVegetal;
        private System.Windows.Forms.Panel panelAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxAddressDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPrimerPlato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxPostre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxSegundoPlato;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonVisualizar;
        private System.Windows.Forms.Button buttonRealizarPedido;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelSetAddress;
        private System.Windows.Forms.Panel panel4;
    }
}

