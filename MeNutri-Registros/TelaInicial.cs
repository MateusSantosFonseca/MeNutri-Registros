﻿using System;
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

            if (Globals.isAdminGeral())
            {
                this.pictureBoxDeletarTodosRegistros.Visible = true;
                this.pictureBoxDeletarTodosRegistros.Enabled = true;
            }

            if (Globals.isAdminComum() || Globals.isAdminGeral())
            {
                this.pictureBoxAdicionarRegistro.Visible = true;
                this.pictureBoxAdicionarRegistro.Enabled = true;
                this.pictureBoxBuscarStringEmail.Visible = true;
                this.pictureBoxBuscarStringEmail.Enabled = true;
            }

            if (!Globals.isNaoAutenticado())
            {
                this.pictureBoxBuscarRegistros.Visible = true;
                this.pictureBoxBuscarRegistros.Enabled = true;
            }
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
            if (listaRegistros != null && listaRegistros.Count > 0)
            {
                TelaVisualizarTodosRegistros telaVisualizarTodosRegistros = new TelaVisualizarTodosRegistros(listaRegistros);
                telaVisualizarTodosRegistros.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Não existem registros cadastrados, a funcionalidade não pôde ser aberta", "Não há registros", MessageBoxButtons.OK, MessageBoxIcon.Error, 243);
            }
        }

        private void pictureBoxBuscarStringEmail_Click(object sender, EventArgs e)
        {
            RegistroController registroController = new RegistroController();
            List<RegistroModel> listaRegistros = registroController.getAllRegistros();
            if (listaRegistros != null && listaRegistros.Count > 0)
            {
                TelaObterEmailsRegistros telaObterEmailsRegistros = new TelaObterEmailsRegistros(listaRegistros);
                telaObterEmailsRegistros.Show();
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

        private void pictureBoxBuscarStringEmail_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxBuscarStringEmail.Cursor = Cursors.Hand;
        }

        private void pictureBoxDeletarTodosRegistros_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxDeletarTodosRegistros.Cursor = Cursors.Hand;
        }

        private void TelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxDeletarTodosRegistros_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Esta funcionalidade está desabilitada, para utilizá-la, contacte o " +
                                "desenvolvedor do sistema.", "Funcionalidade desabilitada", MessageBoxButtons.OK, MessageBoxIcon.Warning, 243);

            //DialogResult resultadoPergunta = MessageBox.Show("Você confirma que deseja deletar todos os registros do sistema? " +
            //                "Atenção, estas deleções não poderão ser revertidas, os dados serão perdidos.",
            //                "Confirmação de exclusão de TODOS os registros", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (resultadoPergunta == DialogResult.Yes)
            //{
            //    MessageBox.Show("Todos os registros foram deletados, o banco de dados foi resetado.", "Todos registros deletados", MessageBoxButtons.OK);
            //    RegistroController registroController = new RegistroController();
            //    registroController.deleteTodosRegistros();
            //}
            //else
            //{
            //    MessageBox.Show("A deleção de todos registros foi cancelada, nenhum registro foi excluído.", "Exclusão de registros cancelada", MessageBoxButtons.OK);
            //}
        }

        
    }
}
