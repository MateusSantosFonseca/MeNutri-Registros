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
using MetroFramework.Forms;
using MetroFramework;
using System.Text.RegularExpressions;
using ViaCEP;

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
                    RazaoSocial = !string.IsNullOrWhiteSpace(this.metroTextBoxRazaoSocial.Text) ? this.metroTextBoxRazaoSocial.Text : "vazio",
                    Nome = !string.IsNullOrWhiteSpace(this.metroTextBoxNome.Text) ? this.metroTextBoxNome.Text : "vazio",
                    Sobrenome = !string.IsNullOrWhiteSpace(this.metroTextBoxSobrenome.Text) ? this.metroTextBoxSobrenome.Text : "vazio",
                    CPF = !string.IsNullOrWhiteSpace(this.metroTextBoxCPF.Text) ? UtilityClass.retornaApenasNumeros(this.metroTextBoxCPF.Text) : "vazio",
                    RG = !string.IsNullOrWhiteSpace(this.metroTextBoxRG.Text) ? this.metroTextBoxRG.Text : "vazio",
                    Telefone = !string.IsNullOrWhiteSpace(this.metroTextBoxTelefone.Text) ? UtilityClass.retornaApenasNumeros(this.metroTextBoxTelefone.Text) : "vazio",
                    Email = !string.IsNullOrWhiteSpace(this.metroTextBoxEmail.Text) ? this.metroTextBoxEmail.Text : "vazio",
                    CNPJ = !string.IsNullOrWhiteSpace(this.metroTextBoxCNPJ.Text) ? UtilityClass.retornaApenasNumeros(this.metroTextBoxCNPJ.Text) : "vazio",
                    CEP = !string.IsNullOrWhiteSpace(this.metroTextBoxCEP.Text) ? UtilityClass.retornaApenasNumeros(this.metroTextBoxCEP.Text) : "vazio",
                    Estado = !string.IsNullOrWhiteSpace(this.metroComboBoxEstados.Text) ? this.metroComboBoxEstados.Text : "vazio",
                    Cidade = !string.IsNullOrWhiteSpace(this.metroTextBoxCidade.Text) ? this.metroTextBoxCidade.Text : "vazio",
                    Rua = !string.IsNullOrWhiteSpace(this.metroTextBoxRua.Text) ? this.metroTextBoxRua.Text : "vazio",
                    Numero = !string.IsNullOrWhiteSpace(this.metroTextBoxNumero.Text) ? this.metroTextBoxNumero.Text : "vazio",
                    Bairro = !string.IsNullOrWhiteSpace(this.metroTextBoxBairro.Text) ? this.metroTextBoxBairro.Text : "vazio",
                    Complemento = !string.IsNullOrWhiteSpace(this.metroTextBoxComplemento.Text) ? this.metroTextBoxComplemento.Text : "vazio",
                    Outros = !string.IsNullOrWhiteSpace(this.metroTextBoxOutros.Text) ? this.metroTextBoxOutros.Text : "vazio"
                };

                if (this.metroRadioButtonCliente.Checked)
                    novoRegistro.TipoRegistro = TipoRegistro.Cliente;
                else if (this.metroRadioButtonPotencialCliente.Checked)
                    novoRegistro.TipoRegistro = TipoRegistro.Potencial_cliente;
                else
                    novoRegistro.TipoRegistro = TipoRegistro.Funcionario;

                bool haCamposIncorretos = verificarCamposIncorretos();
                if (haCamposIncorretos)
                {
                    MessageBox.Show("Existem campos com preenchimento incorreto ou não preenchido.\n\nOs campos: \"Nome\", \"Sobrenome\" e \"Telefone\" são obrigatórios e devem ser preenchidos corretamente.\n\nVerifique estes campos ou corrija os campos mal preenchidos e tente novamente!",
                                                "Adição não efetuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    limparTextboxes();
                    registroController.postRegistro(novoRegistro);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("O registro não foi inserido.", "Adição cancelada", MessageBoxButtons.OK);
            }
        }

        private bool verificarCamposIncorretos()
        {
            Regex regexEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (this.metroTextBoxNome.Text.Length < 2 || this.metroTextBoxSobrenome.Text.Length < 2 ||
                                UtilityClass.retornaApenasNumeros(this.metroTextBoxTelefone.Text).Length < 8 ||
                                (!regexEmail.IsMatch(this.metroTextBoxEmail.Text) && metroTextBoxEmail.Text.Length > 0))
                return true;

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

        private void metroTextBoxCEP_Leave(object sender, EventArgs e)
        {
            string cep = UtilityClass.retornaApenasNumeros(this.metroTextBoxCEP.Text);

            if (cep.Length == 8)
            {
                try
                {
                    ViaCEPResult resultadoPesquisaCEP = ViaCEPClient.Search(cep);

                    if (string.IsNullOrWhiteSpace(resultadoPesquisaCEP.StateInitials))
                    {
                        MessageBox.Show("Não foi possível validar o CEP e preencher automaticamente os campos. Você pode enviar este CEP " +
                                                  "e preencher os campos manualmente, mas é recomendado verificar se o CEP inserido é valido.",
                                                  "CEP não encontrado na base de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        this.metroTextBoxCEP.Text = cep;
                        this.metroComboBoxEstados.SelectedItem = UtilityClass.getNomeUFbyIniciais(resultadoPesquisaCEP.StateInitials);
                        this.metroTextBoxBairro.Text = resultadoPesquisaCEP.Neighborhood;
                        this.metroTextBoxCidade.Text = resultadoPesquisaCEP.City;
                        this.metroTextBoxRua.Text = resultadoPesquisaCEP.Street;
                    }
                }
                catch (Exception exception)
                {
                    LogModel log = new LogModel("Erro ao se conectar na API da ViaCEP", exception.Message, exception.StackTrace, DateTime.Now);
                    LogController.logarErro(log);
                }
            }
            else
            {
                MessageBox.Show("O CEP inserido é invalido, um cep deve possuir exatamente 8 números", "CEP inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ajustarLayoutControles_FuncionarioCheckedChange(object sender, EventArgs args)
        {
            if (metroRadioButtonFuncionario.Checked)
            {
                metroLabelNomeEmpresa.Visible = false;
                metroTextBoxRazaoSocial.Visible = false;
                metroTextBoxSobrenome.Size = new Size(448, 23);

                // Necessário para o controle não bugar:
                metroTextBoxSobrenome.Visible = false; 
                metroTextBoxSobrenome.Visible = true;
            }
            else
            {
                metroLabelNomeEmpresa.Visible = true;
                metroTextBoxRazaoSocial.Visible = true;
                metroLabelNomeEmpresa.Size = new Size(84, 19);
                metroTextBoxRazaoSocial.Size = new Size(154, 23);
                metroTextBoxSobrenome.Size = new Size(179, 23);

                // Necessário para o controle não bugar:
                metroTextBoxSobrenome.Visible = false;
                metroTextBoxSobrenome.Visible = true;
            }



        }
    }
}
