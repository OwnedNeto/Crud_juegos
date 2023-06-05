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
using System.Data.SqlClient;

namespace Crud_juegos
{
    public partial class frmañadir : Form
    {
        public frmañadir()
        {
            InitializeComponent();
        }
        public static string cadena = ("Data Source=ERNESTOLAP\\SQLEXPRESS; Initial Catalog=Crud_juegos; Integrated Security=True");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Insert into t_juegos (nombre_juego, genero_juego, categoria_Juego) VALUES(@nombre_juego,@genero_Juego,@categoria_juego)";
            conex.Open();
            SqlCommand comando = new SqlCommand(query, conex);
            comando.Parameters.AddWithValue("@nombre_juego", textBox1.Text);
            comando.Parameters.AddWithValue("@genero_juego", textBox2.Text);
            comando.Parameters.AddWithValue("@categoria_juego", textBox3.Text);
            comando.ExecuteNonQuery();
            conex.Close();
            MessageBox.Show("Datos Agregados Correctamente");
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Crud();

        }

        private void frmañadir_Load(object sender, EventArgs e)
        {
            Crud();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
