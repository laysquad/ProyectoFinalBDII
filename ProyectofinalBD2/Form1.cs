using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient ;

namespace ProyectofinalBD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            globales.configurar("localhost\\SQLEXPRESS", "Proyectofinal", "sa", "database");
            usuario.Focus();
        }

        private void ingreso()
        {
            //SqlCommand query = new SqlCommand("SELECT rango, nombre, id FROM usuarios WHERE usuario = '"+usuario.Text+"' AND contra = '"+contraseña.Text+"'",globales.conexion) ;
            SqlCommand query = new SqlCommand("SELECT * FROM Proyectofinal.dbo.login('"+usuario.Text+"', '"+contraseña.Text+"')",globales.conexion) ;
            SqlDataReader lector = query.ExecuteReader();
            if (lector.Read())
            {
                DialogResult = DialogResult.OK;
                sesion.idusuario = lector["id"].ToString();
                sesion.nombre = lector["nombre"].ToString();
                sesion.rango = lector["rango"].ToString();
                sesion.nrango = lector["nrango"].ToString();
                sesion.usuario = usuario.Text;
                sesion.permisos.Add("produccion", bool.Parse(lector["produccion"].ToString()));
                sesion.permisos.Add("proveedores", bool.Parse(lector["proveedores"].ToString()));
                sesion.permisos.Add("productos", bool.Parse(lector["productos"].ToString()));
                MessageBox.Show(sesion.nrango);
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }
            lector.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingreso();
        }
    }
}
