using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = Conexion.ExecuteQuery("select * from usuario ORDER BY puntuacion DESC LIMIT 10");
            dataGridView1.DataSource = dt;
        }
    }
}