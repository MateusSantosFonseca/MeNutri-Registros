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
using MetroFramework.Forms;
using MetroFramework;

namespace MeNutri_Registros.Views
{
    public partial class TelaAdicaoNovoRegistro : MetroForm
    {
        public TelaAdicaoNovoRegistro()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Watermelon_icon;
            this.MaximizeBox = false;
            this.Resizable = false;
        }

        private void metroButtonAdicionarRegistro_Click(object sender, EventArgs e)
        {
            DialogResult resultadoPergunta = MessageBox.Show("Você confirma os dados para a adição dos registros?", "Confirmação de adição de registro", MessageBoxButtons.YesNo);

            if (resultadoPergunta == DialogResult.Yes)
            {
                RegistroController registroController = new RegistroController();

                RegistroModel novoRegistro = new RegistroModel()
                {
                    nome = !string.IsNullOrWhiteSpace(this.metroTextBoxNome.Text) ? this.metroTextBoxNome.Text : "vazio",
                    sobrenome = !string.IsNullOrWhiteSpace(this.metroTextBoxSobrenome.Text) ? this.metroTextBoxSobrenome.Text : "vazio",
                    CPF = !string.IsNullOrWhiteSpace(this.metroTextBoxCPF.Text) ? this.metroTextBoxCPF.Text : "vazio",
                    RG = !string.IsNullOrWhiteSpace(this.metroTextBoxRG.Text) ? this.metroTextBoxRG.Text : "vazio",
                    telefone = !string.IsNullOrWhiteSpace(this.metroTextBoxTelefone.Text) ? this.metroTextBoxTelefone.Text : "vazio",
                    email = !string.IsNullOrWhiteSpace(this.metroTextBoxEmail.Text) ? this.metroTextBoxEmail.Text : "vazio",
                    CNPJ = !string.IsNullOrWhiteSpace(this.metroTextBoxCNPJ.Text) ? this.metroTextBoxCNPJ.Text : "vazio",
                    CEP = !string.IsNullOrWhiteSpace(this.metroTextBoxCEP.Text) ? this.metroTextBoxCEP.Text : "vazio",
                    estado = !string.IsNullOrWhiteSpace(this.metroComboBoxEstados.Text) ? this.metroComboBoxEstados.Text : "vazio",
                    cidade = !string.IsNullOrWhiteSpace(this.metroTextBoxCidade.Text) ? this.metroTextBoxCidade.Text : "vazio",
                    rua = !string.IsNullOrWhiteSpace(this.metroTextBoxRua.Text) ? this.metroTextBoxRua.Text : "vazio",
                    numero = !string.IsNullOrWhiteSpace(this.metroTextBoxNumero.Text) ? this.metroTextBoxNumero.Text : "vazio",
                    bairro = !string.IsNullOrWhiteSpace(this.metroTextBoxBairro.Text) ? this.metroTextBoxBairro.Text : "vazio",
                    complemento = !string.IsNullOrWhiteSpace(this.metroTextBoxComplemento.Text) ? this.metroTextBoxComplemento.Text : "vazio",
                    outros = !string.IsNullOrWhiteSpace(this.metroTextBoxOutros.Text) ? this.metroTextBoxOutros.Text : "vazio"
                };

                bool haCamposIncorretos = verificarCamposIncorretos();
                if (haCamposIncorretos)
                {
                    MessageBox.Show("Existem campos incorretos.", "Adição não efetuada", MessageBoxButtons.OK);
                }
                else
                {
                    limparTextboxes();
                    registroController.postRegistro(novoRegistro);
                    //Adicionar metro message box
                }
            }
            else
            {
                MessageBox.Show("O registro não foi inserido.", "Adição cancelada", MessageBoxButtons.OK);
            }
        }

        private bool verificarCamposIncorretos()
        {
            // conjunto de condicoes que tornam o form invalido (validacoes e input em branco)
            // se invalido retorna true, se nao, false

            return false;
        }

        private void limparTextboxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(this.Controls);
            this.metroComboBoxEstados.SelectedItem = null;
        }
    }
}
