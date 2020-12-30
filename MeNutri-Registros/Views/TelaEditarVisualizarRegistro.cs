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
using ViaCep;

namespace MeNutri_Registros.Views
{
    public partial class TelaEditarVisualizarRegistro : MetroForm
    {
        bool isEdit = false;

        Guid guidRegistroSendoAlterado = Guid.Empty;

        public TelaEditarVisualizarRegistro(bool isEdit, RegistroModel registro)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.guidRegistroSendoAlterado = registro.Guid;

            if (isEdit)
            {
                this.Text = "Editar Registro";
                ajustaControlersParaModoEdit();
                verificaTipoRegistroAtualizaControles();
                this.metroButtonEditarRegistro.Visible = true;
                this.metroButtonEditarRegistro.Enabled = true;
            }

            povoarControlerComDadoDoRegistro(registro);

            this.Icon = Properties.Resources.Menutrinho_Icon;
            this.MaximizeBox = false;
            this.Resizable = false;
        }

        public void metroRadioButtonCliente_CheckedChange(object sender, EventArgs e)
        {
            verificaTipoRegistroAtualizaControles();
        }

        public void metroRadioButtonFuncionario_CheckedChange(object sender, EventArgs e)
        {
            verificaTipoRegistroAtualizaControles();
        }

        public void verificaTipoRegistroAtualizaControles()
        {
            if (isEdit)
            {
                if (metroRadioButtonFuncionario.Checked)
                {
                    this.metroTextBoxRazaoSocial.Enabled = false;
                    this.metroTextBoxRazaoSocial.Text = "Não se aplica";

                    this.metroTextBoxCNPJ.Enabled = false;
                    this.metroTextBoxCNPJ.Text = "Não se aplica";

                    this.metroTextBoxCargoDiretoria.Enabled = true;
                    this.metroTextBoxCargoDiretoria.Text = "";
                }
                else
                {
                    this.metroTextBoxRazaoSocial.Enabled = true;
                    this.metroTextBoxRazaoSocial.Text = "";

                    this.metroTextBoxCNPJ.Enabled = true;
                    this.metroTextBoxCNPJ.Text = "";

                    this.metroTextBoxCargoDiretoria.Enabled = false;
                    this.metroTextBoxCargoDiretoria.Text = "Não se aplica";
                }
            }
        }

        public void ajustaControlersParaModoEdit()
        {
            this.metroRadioButtonCliente.Enabled = true;
            this.metroRadioButtonPotencialCliente.Enabled = true;
            this.metroRadioButtonFuncionario.Enabled = true;

            this.metroTextBoxNome.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxNome.UseCustomBackColor = false;
            this.metroTextBoxNome.UseCustomForeColor = false;
            this.metroTextBoxNome.ReadOnly = false;

            this.metroTextBoxSobrenome.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxSobrenome.UseCustomBackColor = false;
            this.metroTextBoxSobrenome.UseCustomForeColor = false;
            this.metroTextBoxSobrenome.ReadOnly = false;

            this.metroTextBoxRazaoSocial.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxRazaoSocial.UseCustomBackColor = false;
            this.metroTextBoxRazaoSocial.UseCustomForeColor = false;
            this.metroTextBoxRazaoSocial.ReadOnly = false;

            this.metroTextBoxCNPJ.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxCNPJ.UseCustomBackColor = false;
            this.metroTextBoxCNPJ.UseCustomForeColor = false;
            this.metroTextBoxCNPJ.ReadOnly = false;

            this.metroTextBoxCargoDiretoria.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxCargoDiretoria.UseCustomBackColor = false;
            this.metroTextBoxCargoDiretoria.UseCustomForeColor = false;
            this.metroTextBoxCargoDiretoria.ReadOnly = false;

            this.metroTextBoxTelefone.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxTelefone.UseCustomBackColor = false;
            this.metroTextBoxTelefone.UseCustomForeColor = false;
            this.metroTextBoxTelefone.ReadOnly = false;

            this.metroTextBoxCPF.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxCPF.UseCustomBackColor = false;
            this.metroTextBoxCPF.UseCustomForeColor = false;
            this.metroTextBoxCPF.ReadOnly = false;

            this.metroTextBoxRG.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxRG.UseCustomBackColor = false;
            this.metroTextBoxRG.UseCustomForeColor = false;
            this.metroTextBoxRG.ReadOnly = false;

            this.metroTextBoxEmail.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxEmail.UseCustomBackColor = false;
            this.metroTextBoxEmail.UseCustomForeColor = false;
            this.metroTextBoxEmail.ReadOnly = false;

            this.metroTextBoxInstagram.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxInstagram.UseCustomBackColor = false;
            this.metroTextBoxInstagram.UseCustomForeColor = false;
            this.metroTextBoxInstagram.ReadOnly = false;

            this.metroTextBoxWhatsapp.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxWhatsapp.UseCustomBackColor = false;
            this.metroTextBoxWhatsapp.UseCustomForeColor = false;
            this.metroTextBoxWhatsapp.ReadOnly = false;

            this.metroTextBoxCEP.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxCEP.UseCustomBackColor = false;
            this.metroTextBoxCEP.UseCustomForeColor = false;
            this.metroTextBoxCEP.ReadOnly = false;

            this.metroComboBoxEstados.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxEstados.UseCustomBackColor = false;
            this.metroComboBoxEstados.UseCustomForeColor = false;
            this.metroComboBoxEstados.Enabled = true;

            this.metroTextBoxCidade.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxCidade.UseCustomBackColor = false;
            this.metroTextBoxCidade.UseCustomForeColor = false;
            this.metroTextBoxCidade.ReadOnly = false;

            this.metroTextBoxRua.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxRua.UseCustomBackColor = false;
            this.metroTextBoxRua.UseCustomForeColor = false;
            this.metroTextBoxRua.ReadOnly = false;

            this.metroTextBoxNumero.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxNumero.UseCustomBackColor = false;
            this.metroTextBoxNumero.UseCustomForeColor = false;
            this.metroTextBoxNumero.ReadOnly = false;

            this.metroTextBoxComplemento.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxComplemento.UseCustomBackColor = false;
            this.metroTextBoxComplemento.UseCustomForeColor = false;
            this.metroTextBoxComplemento.ReadOnly = false;

            this.metroTextBoxBairro.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxBairro.UseCustomBackColor = false;
            this.metroTextBoxBairro.UseCustomForeColor = false;
            this.metroTextBoxBairro.ReadOnly = false;

            this.metroTextBoxOutros.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTextBoxOutros.UseCustomBackColor = false;
            this.metroTextBoxOutros.UseCustomForeColor = false;
            this.metroTextBoxOutros.ReadOnly = false;
        }

        public void povoarControlerComDadoDoRegistro(RegistroModel registro)
        {
            if (registro.TipoRegistro.Equals(TipoRegistro.Cliente))
                this.metroRadioButtonCliente.Checked = true;
            else if (registro.TipoRegistro.Equals(TipoRegistro.Potencial_cliente))
                this.metroRadioButtonPotencialCliente.Checked = true;
            else
                this.metroRadioButtonFuncionario.Checked = true;

            this.metroTextBoxNome.Text = registro.Nome;
            this.metroTextBoxSobrenome.Text = registro.Sobrenome;
            this.metroTextBoxRazaoSocial.Text = registro.RazaoSocial;
            this.metroTextBoxCNPJ.Text = registro.CNPJ;
            this.metroTextBoxCargoDiretoria.Text = registro.CargoDiretoria;
            this.metroTextBoxTelefone.Text = registro.Telefone;
            this.metroTextBoxCPF.Text = registro.CPF;
            this.metroTextBoxRG.Text = registro.RG;
            this.metroTextBoxEmail.Text = registro.Email;
            this.metroTextBoxInstagram.Text = registro.Instagram;
            this.metroTextBoxWhatsapp.Text = registro.Whatsapp;
            this.metroTextBoxCEP.Text = registro.CEP;
            this.metroComboBoxEstados.Text = registro.Estado;
            this.metroTextBoxCidade.Text = registro.Cidade;
            this.metroTextBoxRua.Text = registro.Rua;
            this.metroTextBoxNumero.Text = registro.Numero;
            this.metroTextBoxComplemento.Text = registro.Complemento;
            this.metroTextBoxBairro.Text = registro.Bairro;
            this.metroTextBoxOutros.Text = registro.Outros;
        }
        private void metroTextBoxCEP_Leave(object sender, EventArgs e)
        {
            string cep = UtilityClass.retornaApenasNumeros(this.metroTextBoxCEP.Text);

            if (cep.Length == 8)
            {
                try
                {
                    ViaCepClient viaCepClient = new ViaCepClient();
                    ViaCepResult resultadoPesquisaCEP = viaCepClient.Search(cep);

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
                catch (Exception ex)
                {
                    MensagemModel mensagem = new MensagemModel("Erro ao se conectar na API da ViaCEP", "Ocorreram erros na utilização no Excel, tente novamente.");
                    LogModel log = new LogModel(mensagem.Titulo, ex.Message, ex.StackTrace, DateTime.Now);
                    LogController.logarErro(log);
                    MessageBox.Show(mensagem.Corpo, mensagem.Titulo, MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("O CEP inserido é invalido, um cep deve possuir exatamente 8 números", "CEP inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroButtonEditarRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.metroTextBoxTelefone.Text) || 
                        (UtilityClass.RemoveDiacritics(UtilityClass.retornaApenasNumeros(this.metroTextBoxTelefone.Text), true)).Length < 8)
            {
                MessageBox.Show("O telefone é um campo obrigatório, por favor preencha-o corretamente.", "Alteração não realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultadoPergunta = MessageBox.Show("Você confirma a alteração do registro?", "Confirmação de edição de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultadoPergunta != DialogResult.Yes)
            {
                MessageBox.Show("A confirmação foi recusada e o registro não foi alterado", "Alteração não realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (metroRadioButtonFuncionario.Checked)
            {
                this.metroTextBoxCNPJ.Text = "vazio";
                this.metroTextBoxRazaoSocial.Text = "vazio";
            }
            else
            {
                this.metroTextBoxCargoDiretoria.Text = "vazio";
            }

            TipoRegistro tipoRegistroSelecionado;
            if (this.metroRadioButtonCliente.Checked)
                tipoRegistroSelecionado = TipoRegistro.Cliente;
            else if (this.metroRadioButtonPotencialCliente.Checked)
                tipoRegistroSelecionado = TipoRegistro.Potencial_cliente;
            else
                tipoRegistroSelecionado = TipoRegistro.Funcionario;

            RegistroModel registroAtualizado = new RegistroModel()
            {
                Guid = guidRegistroSendoAlterado,
                TipoRegistro = tipoRegistroSelecionado,
                RazaoSocial = !string.IsNullOrWhiteSpace(this.metroTextBoxRazaoSocial.Text) ? this.metroTextBoxRazaoSocial.Text : "vazio",
                Nome = !string.IsNullOrWhiteSpace(this.metroTextBoxNome.Text) ? this.metroTextBoxNome.Text : "vazio",
                Sobrenome = !string.IsNullOrWhiteSpace(this.metroTextBoxSobrenome.Text) ? this.metroTextBoxSobrenome.Text : "vazio",
                CargoDiretoria = !string.IsNullOrWhiteSpace(this.metroTextBoxCargoDiretoria.Text) ? this.metroTextBoxCargoDiretoria.Text : "vazio",
                CPF = !string.IsNullOrWhiteSpace(this.metroTextBoxCPF.Text) ? UtilityClass.RemoveDiacritics(UtilityClass.retornaApenasNumeros(this.metroTextBoxCPF.Text), true) : "vazio",
                RG = !string.IsNullOrWhiteSpace(this.metroTextBoxRG.Text) ? UtilityClass.RemoveDiacritics(this.metroTextBoxRG.Text, true) : "vazio",
                Telefone = !string.IsNullOrWhiteSpace(this.metroTextBoxTelefone.Text) ? UtilityClass.RemoveDiacritics(UtilityClass.retornaApenasNumeros(this.metroTextBoxTelefone.Text), true) : "vazio",
                Instagram = !string.IsNullOrWhiteSpace(this.metroTextBoxInstagram.Text) ? this.metroTextBoxInstagram.Text : "vazio",
                Whatsapp = !string.IsNullOrWhiteSpace(this.metroTextBoxWhatsapp.Text) ? UtilityClass.RemoveDiacritics(UtilityClass.retornaApenasNumeros(this.metroTextBoxWhatsapp.Text), true) : "vazio",
                Email = !string.IsNullOrWhiteSpace(this.metroTextBoxEmail.Text) ? this.metroTextBoxEmail.Text : "vazio",
                CNPJ = !string.IsNullOrWhiteSpace(this.metroTextBoxCNPJ.Text) ? UtilityClass.RemoveDiacritics(UtilityClass.retornaApenasNumeros(this.metroTextBoxCNPJ.Text), true) : "vazio",
                CEP = !string.IsNullOrWhiteSpace(this.metroTextBoxCEP.Text) ? UtilityClass.RemoveDiacritics(UtilityClass.retornaApenasNumeros(this.metroTextBoxCEP.Text), true) : "vazio",
                Estado = !string.IsNullOrWhiteSpace(this.metroComboBoxEstados.Text) ? this.metroComboBoxEstados.Text : "vazio",
                Cidade = !string.IsNullOrWhiteSpace(this.metroTextBoxCidade.Text) ? this.metroTextBoxCidade.Text : "vazio",
                Rua = !string.IsNullOrWhiteSpace(this.metroTextBoxRua.Text) ? this.metroTextBoxRua.Text : "vazio",
                Numero = !string.IsNullOrWhiteSpace(this.metroTextBoxNumero.Text) ? this.metroTextBoxNumero.Text : "vazio",
                Bairro = !string.IsNullOrWhiteSpace(this.metroTextBoxBairro.Text) ? this.metroTextBoxBairro.Text : "vazio",
                Complemento = !string.IsNullOrWhiteSpace(this.metroTextBoxComplemento.Text) ? this.metroTextBoxComplemento.Text : "vazio",
                Outros = !string.IsNullOrWhiteSpace(this.metroTextBoxOutros.Text) ? this.metroTextBoxOutros.Text : "vazio",
                HorarioUltimaEdicao = DateTime.Now
            };

            RegistroController registroController = new RegistroController();

            limparTextboxes();
            registroController.updateRegistro(registroAtualizado);
            this.Close();
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
