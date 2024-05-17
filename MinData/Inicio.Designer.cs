namespace MinData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuTitle = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recepciónLotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.menuRecepcionConfig = new FontAwesome.Sharp.IconMenuItem();
            this.facturadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zonasDeAcopioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeMineralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.menuTitle.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitle
            // 
            this.menuTitle.BackColor = System.Drawing.Color.White;
            this.menuTitle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.recepciónLotesToolStripMenuItem});
            this.menuTitle.Location = new System.Drawing.Point(3, 92);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(1588, 52);
            this.menuTitle.TabIndex = 0;
            this.menuTitle.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 48);
            this.toolStripMenuItem1.Text = "Recepción";
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // recepciónLotesToolStripMenuItem
            // 
            this.recepciónLotesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recepciónLotesToolStripMenuItem.Image")));
            this.recepciónLotesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.recepciónLotesToolStripMenuItem.Name = "recepciónLotesToolStripMenuItem";
            this.recepciónLotesToolStripMenuItem.Size = new System.Drawing.Size(127, 61);
            this.recepciónLotesToolStripMenuItem.Text = "Lotes Recibidos";
            this.recepciónLotesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem2,
            this.iconMenuItem4});
            this.menuPrincipal.Location = new System.Drawing.Point(3, 64);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1588, 28);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconMenuItem1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(138, 34);
            this.iconMenuItem1.Text = "Administrador";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem3,
            this.menuRecepcionConfig});
            this.iconMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            this.iconMenuItem2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(112, 34);
            this.iconMenuItem2.Text = "Recepción";
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconMenuItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.BandAid;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(201, 26);
            this.iconMenuItem3.Text = "Registro Mineral";
            // 
            // menuRecepcionConfig
            // 
            this.menuRecepcionConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturadorToolStripMenuItem,
            this.transportistaToolStripMenuItem,
            this.zonasDeAcopioToolStripMenuItem,
            this.tipoDeMineralToolStripMenuItem});
            this.menuRecepcionConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.menuRecepcionConfig.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            this.menuRecepcionConfig.IconColor = System.Drawing.Color.Black;
            this.menuRecepcionConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuRecepcionConfig.Name = "menuRecepcionConfig";
            this.menuRecepcionConfig.Size = new System.Drawing.Size(201, 26);
            this.menuRecepcionConfig.Text = "Configuración";
            // 
            // facturadorToolStripMenuItem
            // 
            this.facturadorToolStripMenuItem.Name = "facturadorToolStripMenuItem";
            this.facturadorToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.facturadorToolStripMenuItem.Text = "Facturador";
            // 
            // transportistaToolStripMenuItem
            // 
            this.transportistaToolStripMenuItem.Name = "transportistaToolStripMenuItem";
            this.transportistaToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.transportistaToolStripMenuItem.Text = "Transportista";
            // 
            // zonasDeAcopioToolStripMenuItem
            // 
            this.zonasDeAcopioToolStripMenuItem.Name = "zonasDeAcopioToolStripMenuItem";
            this.zonasDeAcopioToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.zonasDeAcopioToolStripMenuItem.Text = "Zonas de Acopio";
            // 
            // tipoDeMineralToolStripMenuItem
            // 
            this.tipoDeMineralToolStripMenuItem.Name = "tipoDeMineralToolStripMenuItem";
            this.tipoDeMineralToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.tipoDeMineralToolStripMenuItem.Text = "Tipo de Mineral";
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.iconMenuItem4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(154, 34);
            this.iconMenuItem4.Text = "Almacenaje Lote";
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusPrincipal.Location = new System.Drawing.Point(3, 785);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.Size = new System.Drawing.Size(1588, 22);
            this.statusPrincipal.TabIndex = 2;
            this.statusPrincipal.Text = "statusStrip1";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1594, 810);
            this.Controls.Add(this.statusPrincipal);
            this.Controls.Add(this.menuTitle);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuTitle;
            this.Name = "Inicio";
            this.Text = "SISTEMA DE COMERCIALIZACION - PLANTA MINERA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuTitle.ResumeLayout(false);
            this.menuTitle.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitle;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.StatusStrip statusPrincipal;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem menuRecepcionConfig;
        private System.Windows.Forms.ToolStripMenuItem facturadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zonasDeAcopioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMineralToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem recepciónLotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

