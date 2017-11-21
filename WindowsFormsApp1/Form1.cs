using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 80,80));
        }
        
        private void bEntrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("Server=localhost; database=prueba;Uid='root';pwd=''");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conexion = new MySqlConnection();
            codigo.Connection = conectar;

            codigo.CommandText = ("SELECT * FROM usuarios  WHERE uNombre = '" + txtUsuario.Text + "' AND uPass = '" + txtContra.Text + "'");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.HasRows)
            {
                Formato f = new Formato();
                f.Show();
            }
            else
            {
                MessageBox.Show("error 666");
            }
            conectar.Close();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir alv?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
