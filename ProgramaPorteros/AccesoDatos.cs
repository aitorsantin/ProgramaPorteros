using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaPorteros
{
    public partial class AccesoDatos : Form
    {
        public AccesoDatos()
        {
            InitializeComponent();
        }

        private void AccesoDatos_Load(object sender, EventArgs e)
        {

        }

        private void LlenarCombobox()
        {
            cbConexion.Items.Add("");
            cbConexion.SelectedIndex = 0;
        }
    }
}
