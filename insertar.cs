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
    public partial class insertar : Form
    {
        public insertar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OBF3EB5\\SQLEXPRESS01; Initial Catalog=prueva; Integrated Security = true ");
            conn.Open();

            string nombre = textBox1.Text;
            string nn = apellido.Text;
            string date = fecha.Text;
            string direc = direccion.Text;
            string gene = genero.Text;
            string esta = estado.Text;
            string mo = movil.Text;
            string tel = telefono.Text;

            string sql = $"insert into Agenda(Nombre,Apellido,Fecha_de_nacimiento,Dirección,Genero,Estado_civil,Móvil,Telefono) values ('{nombre}','{nn}','{date}','{direc}','{gene}','{esta}','{mo}','{tel}')";


            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();
            MessageBox.Show("se agrego los datos de manera esitosa");
            conn.Close();





        }

        private void estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
