using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectofinalBD2
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            globales.principal = this;
            Form1 login = new Form1();
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            if (!sesion.permisos["productos"]) { bmenucreacionproductos.Visible = false;}
            if (!sesion.permisos["proveedores"]) { bmenuproveedores.Visible = false; }
            if (sesion.rango != "1") { mantenimientos.Visible = false; }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoproductos ventana = new mantenimientoproductos();
            ventana.ShowDialog();
        }
    }
}