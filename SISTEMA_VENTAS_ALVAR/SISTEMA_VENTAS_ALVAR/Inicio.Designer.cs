namespace SISTEMA_VENTAS_ALVAR
{
    partial class Inicio
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
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem8 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1046, 45);
            this.menutitulo.TabIndex = 0;
            this.menutitulo.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE VENTAS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem7,
            this.iconMenuItem6,
            this.iconMenuItem5,
            this.iconMenuItem4,
            this.iconMenuItem3,
            this.iconMenuItem8,
            this.iconMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 45);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 84);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoSize = false;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconMenuItem1.Size = new System.Drawing.Size(80, 80);
            this.iconMenuItem1.Text = "Usuario";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem7
            // 
            this.iconMenuItem7.AutoSize = false;
            this.iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.iconMenuItem7.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem7.IconSize = 50;
            this.iconMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem7.Name = "iconMenuItem7";
            this.iconMenuItem7.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconMenuItem7.Size = new System.Drawing.Size(122, 80);
            this.iconMenuItem7.Text = "Admin";
            this.iconMenuItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem6
            // 
            this.iconMenuItem6.AutoSize = false;
            this.iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconMenuItem6.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem6.IconSize = 50;
            this.iconMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem6.Name = "iconMenuItem6";
            this.iconMenuItem6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconMenuItem6.Size = new System.Drawing.Size(80, 80);
            this.iconMenuItem6.Text = "Ventas";
            this.iconMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItem6.Click += new System.EventHandler(this.iconMenuItem6_Click);
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.AutoSize = false;
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            this.iconMenuItem5.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem5.IconSize = 50;
            this.iconMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconMenuItem5.Size = new System.Drawing.Size(80, 80);
            this.iconMenuItem5.Text = "Compras";
            this.iconMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.AutoSize = false;
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.IconSize = 50;
            this.iconMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconMenuItem4.Size = new System.Drawing.Size(80, 80);
            this.iconMenuItem4.Text = "Clientes";
            this.iconMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.AutoSize = false;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 50;
            this.iconMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconMenuItem3.Size = new System.Drawing.Size(80, 80);
            this.iconMenuItem3.Text = "Proveedores";
            this.iconMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem8
            // 
            this.iconMenuItem8.AutoSize = false;
            this.iconMenuItem8.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.iconMenuItem8.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem8.IconSize = 50;
            this.iconMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem8.Name = "iconMenuItem8";
            this.iconMenuItem8.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconMenuItem8.Size = new System.Drawing.Size(80, 80);
            this.iconMenuItem8.Text = "Informes";
            this.iconMenuItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.AutoSize = false;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 50;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconMenuItem2.Size = new System.Drawing.Size(80, 80);
            this.iconMenuItem2.Text = "Acerca de";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 536);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menutitulo;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Menu Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem8;
    }
}

