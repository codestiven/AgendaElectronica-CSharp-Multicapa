using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_de_acceso_a_Datos
{
    public partial class eliminar : Form
    {
        public eliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OBF3EB5\\SQLEXPRESS01; Initial Catalog=prueva; Integrated Security = true ");
            conn.Open();



            string sql = $"DELETE FROM Agenda where Id = {textBox1.Text}";


            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();

            SqlDataReader rg = cmm.ExecuteReader();
            rg.Read();
            MessageBox.Show("eliminado con exito");


        }
    }
}
