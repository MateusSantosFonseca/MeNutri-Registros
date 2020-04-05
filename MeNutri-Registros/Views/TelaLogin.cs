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
using MetroFramework.Forms;

namespace MeNutri_Registros.Views
{
    public partial class TelaLogin : MetroForm
    {
        public TelaLogin()
        {
            InitializeComponent();
            
            this.Icon = Properties.Resources.Menutrinho_Icon;
            this.MaximizeBox = false;
            this.Resizable = false;
        }

        private void checkEnterPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                realizarLogin();
                e.Handled = true;
            }
        }

        private void metroButtonLogar_Click(object sender, EventArgs e)
        {
            realizarLogin();
        }

        private void realizarLogin()
        {
            string loginInserido = this.metroTextBoxUser.Text.ToLower();
            string passwordInserido = this.metroTextBoxSenha.Text;
            LoginController loginController = new LoginController();
            loginController.verificaUsuarioSenha(loginInserido, passwordInserido);

            if (Globals.tipoDeUsuario.Equals("user-comum") || Globals.tipoDeUsuario.Equals("administrador-comum") || Globals.tipoDeUsuario.Equals("administrador-geral"))
            {
                TelaInicial telaInicial = new TelaInicial();
                telaInicial.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha ou usuários incorretos, por favor, tente novamente.", "Login falhou", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.metroTextBoxUser.Text = "";
                this.metroTextBoxSenha.Text = "";
                this.metroTextBoxUser.Focus();
            }
        }
    }
}
