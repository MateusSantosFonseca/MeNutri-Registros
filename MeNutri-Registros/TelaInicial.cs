﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MeNutri_Registros
{
    public partial class TelaInicial : MetroForm
    {
        public TelaInicial()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Watermelon_icon;
        }

        private void pictureBoxAdicionarRegistro_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxAdicionarRegistro.Cursor = Cursors.Hand;
        }

        private void pictureBoxBuscarRegistros_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxBuscarRegistros.Cursor = Cursors.Hand;
        }

        private void pictureBoxAdicionarRegistro_Click(object sender, EventArgs e)
        {
            // Adicionar logica
        }

        private void pictureBoxBuscarRegistros_Click(object sender, EventArgs e)
        {
            // Adicionar logica
        }
    }
}