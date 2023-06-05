using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Crud_juegos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conex = new SqlConnection("Data Source=ERNESTOLAP\\SQLEXPRESS; Initial Catalog=Crud_juegos; Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmañadir objFrnm = new frmañadir();
            objFrnm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmeditar objFrnm = new frmeditar();
            objFrnm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmeliminar objFrnm = new frmeliminar();
            objFrnm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
       
    }
}
