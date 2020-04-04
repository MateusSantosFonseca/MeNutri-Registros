using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeNutri_Registros.Controllers;
using MeNutri_Registros.Views;
using MetroFramework.Forms;

namespace MeNutri_Registros
{
    public partial class TelaInicial : MetroForm
    {
        public TelaInicial()
        {
            InitializeComponent();
            this.FormClosing += TelaInicial_FormClosing;
            this.Icon = Properties.Resources.Menutrinho_Icon;
            this.MaximizeBox = false;
            this.Resizable = false;

            if (Globals.isAdminComum() || Globals.isAdminGeral())
                this.pictureBoxAdicionarRegistro.Visible = true;

            if (!Globals.isNaoAutenticado())
                this.pictureBoxBuscarRegistros.Visible = true;
        }

        private void pictureBoxAdicionarRegistro_Click(object sender, EventArgs e)
        {
            TelaAdicaoNovoRegistro telaAdicaoNovoRegistro = new TelaAdicaoNovoRegistro();
            telaAdicaoNovoRegistro.Show();
        }

        private void pictureBoxBuscarRegistros_Click(object sender, EventArgs e)
        {
            TelaVisualizarTodosRegistros telaVisualizarTodosRegistros = new TelaVisualizarTodosRegistros();
            telaVisualizarTodosRegistros.Show();
        }

        private void pictureBoxAdicionarRegistro_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxAdicionarRegistro.Cursor = Cursors.Hand;
        }

        private void pictureBoxBuscarRegistros_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxBuscarRegistros.Cursor = Cursors.Hand;
        }

        private void TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
