using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace pryDBSoto
{
    public partial class Form1 : Form
    {

        OleDbConnection conexionBD; //declaro obj oled
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conexionBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Alumnos\\source\\repos\\pryDBSoto\\BD\\2_EL_CLUB.accdb"); //poner tipo de arch
            conexionBD.Open();

            lblResultado.Text = "Conectado a la base";
            lblResultado.BackColor = Color.Pink;
        
        
        }

    }


}

