﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_winforms_catalogo
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMain to = new frmMain();
            to.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           /* 
              if(MessageBox.Show("Esta seguro que desea eliminar el articulo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int resultado = ConexionSqlAgregar.eliminar()
            }
           */
        }
    }
}
