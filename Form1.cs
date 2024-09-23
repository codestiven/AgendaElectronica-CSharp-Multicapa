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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pruevaDataSet.Agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.pruevaDataSet.Agenda);
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OBF3EB5\\SQLEXPRESS01; Initial Catalog=prueva; Integrated Security = true ");
            conn.Open();
            


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            insertar abrir = new insertar();
            abrir.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.agendaTableAdapter.FillBy(this.pruevaDataSet.Agenda);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.agendaTableAdapter.FillBy1(this.pruevaDataSet.Agenda);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscar abrir = new buscar();
            abrir.ShowDialog();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            eliminar abrir = new eliminar();
            abrir.ShowDialog();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            modificar abrir = new modificar();
            abrir.ShowDialog();
        }
    }
}
