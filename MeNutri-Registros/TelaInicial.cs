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
using MeNutri_Registros.Models;
using MeNutri_Registros.Views;
using MetroFramework;
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
            this.metroLabelCreatedBy.Text = "© Mateus Fonseca - " + DateTime.Now.ToString("yyyy");

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
            RegistroController registroController = new RegistroController();
            List<RegistroModel> listaRegistros = registroController.getAllRegistros();
            if(listaRegistros != null && listaRegistros.Count > 0)
            {
                TelaVisualizarTodosRegistros telaVisualizarTodosRegistros = new TelaVisualizarTodosRegistros(listaRegistros);
                telaVisualizarTodosRegistros.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Não existem registros cadastrados, a funcionalidade não pôde ser aberta", "Não há registros", MessageBoxButtons.OK, MessageBoxIcon.Error, 243);
            }
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
