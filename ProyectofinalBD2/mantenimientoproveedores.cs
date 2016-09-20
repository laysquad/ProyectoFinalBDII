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
    public partial class mantenimientoproveedores : Form
    {
        public mantenimientoproveedores()
        {
            InitializeComponent();
        }

        private void mantenimientoproveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectofinalDataSet.proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.proyectofinalDataSet.proveedores);

        }
    }
}
