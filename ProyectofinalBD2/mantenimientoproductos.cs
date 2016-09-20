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
    public partial class mantenimientoproductos : Form
    {
        public mantenimientoproductos()
        {
            InitializeComponent();
        }

        private void mantenimientoproductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectofinalDataSet.productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.proyectofinalDataSet.productos);

        }
    }
}
