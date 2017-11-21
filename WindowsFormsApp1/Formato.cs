using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formato : Form
    {
        public Formato()
        {
            InitializeComponent();
            DataGridTextBoxColumn col1 = new DataGridTextBoxColumn();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bPLector_Click(object sender, EventArgs e)
        {
            LectorXML lec = new LectorXML();
            lec.Leer();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
