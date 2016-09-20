using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectofinalBD2
{
    public static class globales
    {
        public static SqlConnection conexion;
        public static Form principal;

        public static void configurar(string servidor, string db, string usuario, string contra)
        {
            try
            {
                conexion = new SqlConnection("Server=" + servidor + ";Database=" + db + ";User Id=" + usuario + ";Password=" + contra + ";");
                conexion.Open();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error en la conexion de la base de datos");
                principal.Close();
            }
        }
    }
}
