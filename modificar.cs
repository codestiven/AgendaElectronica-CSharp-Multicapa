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
    public partial class modificar : Form
    {
        public modificar()
        {
            InitializeComponent();
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
            string num = textBox2.Text;
            string sql = $"UPDATE Agenda SET Nombre= '{nombre}' , Apellido= '{nn}', Fecha_de_nacimiento = '{date}' , Dirección = '{direc}' , Genero = '{gene}' , Estado_civil = '{esta}' , Móvil = '{mo}' , Telefono = '{tel}' where Id =  {num}  ";

            SqlCommand cmm = new SqlCommand(sql, conn);
            cmm.ExecuteNonQuery();
            MessageBox.Show("se modifico los datos de manera esitosa");
            conn.Close();


        }

        private void modificar_Load(object sender, EventArgs e)
        {

        }
    }
}
