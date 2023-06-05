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

namespace Crud_juegos
{
    public partial class frmeditar : Form
    {
        public frmeditar()
        {
            InitializeComponent();
        }
        public static string cadena =("Data Source=ERNESTOLAP\\SQLEXPRESS; Initial Catalog=Crud_juegos; Integrated Security=True");
        SqlConnection conex = new SqlConnection(cadena);
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Crud()
        {
            string query = "SELECT * FROM t_juegos";
            conex.Open();
            SqlCommand cmd = new SqlCommand(query, conex);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            conex.Close();
            dgvt.DataSource = dt;
        }

        private void frmeditar_Load(object sender, EventArgs e)
        {
            Crud();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string dato = dgvt.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(dato);
            string query = "UPDATE t_juegos SET nombre_juego = @nombre_juego , genero_juego = @genero_juego, categoria_juego = @categoria_juego Where id_juego = @ID";
            conex.Open();
            SqlCommand comando = new SqlCommand(query, conex);
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@nombre_juego", textBox1.Text);
            comando.Parameters.AddWithValue("@genero_juego", textBox2.Text);
            comando.Parameters.AddWithValue("@categoria_juego", textBox3.Text);
            comando.ExecuteNonQuery();
            conex.Close();
            MessageBox.Show("Editado!!!!!");
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Crud();
        }
        private void dtgjuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvt.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dgvt.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dgvt.CurrentRow.Cells[3].Value.ToString();
        }
        private void dtgjuegos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvt.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dgvt.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dgvt.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
