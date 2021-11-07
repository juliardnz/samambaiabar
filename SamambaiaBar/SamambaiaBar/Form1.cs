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

namespace SamambaiaBar
{
    public partial class FormBar : Form
    {
        public FormBar()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "loungebar";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadBebida cadBebida = new CadBebida();
            cadBebida.ShowDialog();

        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadCliente cadCliente = new CadCliente();
            cadCliente.ShowDialog();
        }
    }
}
