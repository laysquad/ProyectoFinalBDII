namespace ProyectofinalBD2
{
    partial class principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuadministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.bmenucreacionproductos = new System.Windows.Forms.ToolStripMenuItem();
            this.bmenuproveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.menuadministracion,
            this.mantenimientos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarProgramaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            this.cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            this.cerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cerrarProgramaToolStripMenuItem.Text = "Cerrar programa";
            // 
            // menuadministracion
            // 
            this.menuadministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmenucreacionproductos,
            this.bmenuproveedores});
            this.menuadministracion.Name = "menuadministracion";
            this.menuadministracion.Size = new System.Drawing.Size(100, 20);
            this.menuadministracion.Text = "Administración";
            // 
            // bmenucreacionproductos
            // 
            this.bmenucreacionproductos.Name = "bmenucreacionproductos";
            this.bmenucreacionproductos.Size = new System.Drawing.Size(205, 22);
            this.bmenucreacionproductos.Text = "Creacion de productos";
            // 
            // bmenuproveedores
            // 
            this.bmenuproveedores.Name = "bmenuproveedores";
            this.bmenuproveedores.Size = new System.Drawing.Size(205, 22);
            this.bmenuproveedores.Text = "Creación de proveedores";
            // 
            // mantenimientos
            // 
            this.mantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.mantenimientos.Name = "mantenimientos";
            this.mantenimientos.Size = new System.Drawing.Size(106, 20);
            this.mantenimientos.Text = "Mantenimientos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 526);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuadministracion;
        private System.Windows.Forms.ToolStripMenuItem bmenucreacionproductos;
        private System.Windows.Forms.ToolStripMenuItem bmenuproveedores;
        private System.Windows.Forms.ToolStripMenuItem mantenimientos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}