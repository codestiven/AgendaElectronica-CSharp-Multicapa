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
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OBF3EB5\\SQLEXPRESS01; Initial Catalog=prueva; Integrated Security = true ");
            conn.Open();



            string sql = $"SELECT * FROM Agenda where Id = {textBox1.Text}";


            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();

            SqlDataReader rg = cmm.ExecuteReader();
            rg.Read();
            MessageBox.Show(rg["nombre"].ToString());


            ID.Text = rg["Id"].ToString();
            nombre.Text = rg["Nombre"].ToString();
            apellido.Text = rg["Apellido"].ToString();
            fecha.Text = rg["Fecha_de_nacimiento"].ToString();
            direccion.Text = rg["Dirección"].ToString();
            genero.Text = rg["Genero"].ToString();
            estado.Text = rg["Estado_civil"].ToString();
            movil.Text = rg["Móvil"].ToString();
            telefono.Text = rg["Telefono"].ToString();
            conn.Close();
        }
    }
}
