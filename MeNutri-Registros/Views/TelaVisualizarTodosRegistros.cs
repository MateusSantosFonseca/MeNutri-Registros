using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeNutri_Registros.Controllers;
using MeNutri_Registros.Models;
using MetroFramework;
using MetroFramework.Forms;

namespace MeNutri_Registros.Views
{
    public partial class TelaVisualizarTodosRegistros : MetroForm
    {
        List<RegistroModel> listaRegistros;
        List<RegistroModel> listaRegistrosOrdenada;
        List<RegistroModel> listaAtual; // Lista que dinamicamente troca seus valores de acordo com filtros e ordenacoes

        public TelaVisualizarTodosRegistros(List<RegistroModel> lista)
        {
            RegistroController registroController = new RegistroController();
            this.listaRegistros = lista;

            if (listaRegistros != null && listaRegistros.Count > 0)
            {
                InitializeComponent();

                this.Icon = Properties.Resources.Menutrinho_Icon;
                this.MaximizeBox = false;
                this.Resizable = false;
                this.metroGridVisualizacaoRegistros.Visible = true;
                this.metroComboBoxOrdenar.SelectedIndex = 0;

                ajustaHorariosDatetimes();

                this.listaRegistrosOrdenada = listaRegistros.OrderByDescending(registro => registro.HorarioCadastroRegistro).ToList();
                listaAtual = listaRegistrosOrdenada;
                this.metroGridVisualizacaoRegistros.DataSource = listaRegistrosOrdenada;

                controlaDisponibilidadeControles();
                ajustaDataGrid();
            }

        }

        private void atualizaGrid([Optional] List<RegistroModel> listaAlterada, bool apenasReset)
        {
            if (listaAlterada != null && listaAlterada.Count > 0)
            {
                this.metroGridVisualizacaoRegistros.DataSource = listaAlterada;
            }
            else
            {
                if (!apenasReset)
                    mostraMensagemEscondeGrid("Os filtros aplicados retornaram uma lista vazia. Filtros e tabela resetados.", "Erro ao iniciar tabela");

                resetaFiltros();
                RegistroController registroController = new RegistroController();
                this.listaRegistros = registroController.getAllRegistros();
                this.listaRegistrosOrdenada = listaRegistros.OrderByDescending(registro => registro.HorarioCadastroRegistro).ToList();
                listaAtual = listaRegistrosOrdenada;
                this.metroGridVisualizacaoRegistros.DataSource = listaRegistrosOrdenada;
            }
        }

        private void metroButtonPesquisarRegistros_Click(object sender, EventArgs e)
        {
            DateTime dataInicioPeriodo = metroDateTimeInicio.Value;
            dataInicioPeriodo = new DateTime(dataInicioPeriodo.Year, dataInicioPeriodo.Month, dataInicioPeriodo.Day, 0, 0, 0);
            DateTime dataTerminoPeriodo = metroDateTimeTermino.Value;
            dataTerminoPeriodo = new DateTime(dataTerminoPeriodo.Year, dataTerminoPeriodo.Month, dataTerminoPeriodo.Day, 23, 59, 59);

            List<RegistroModel> listaRegistrosFiltradosDatetime = (from registro in listaRegistros
                                                                   where registro.HorarioCadastroRegistro >= dataInicioPeriodo
                                                                         && registro.HorarioCadastroRegistro <= dataTerminoPeriodo
                                                                   select registro).ToList();
            listaRegistros = listaRegistrosFiltradosDatetime;
            listaAtual = listaRegistrosFiltradosDatetime;
            atualizaGrid(listaRegistrosFiltradosDatetime, false);
        }

        private void metroComboBoxOrdenar_SelectionChangeCommited(object sender, EventArgs e)
        {
            List<RegistroModel> listaOrdenada;
            // 0 - Data criacao, 1 - Nome, 2 - Razão social, 3 - Tipo registro, 4 - Estado
            int ordenarPor = metroComboBoxOrdenar.SelectedIndex;

            switch (ordenarPor)
            {
                case 1:
                    listaOrdenada = listaRegistros.OrderBy(registro => registro.Nome).ToList();
                    listaAtual = listaOrdenada;
                    this.metroGridVisualizacaoRegistros.DataSource = listaOrdenada;
                    break;
                case 2:
                    listaOrdenada = listaRegistros.OrderBy(registro => registro.RazaoSocial).ToList();
                    listaAtual = listaOrdenada;
                    this.metroGridVisualizacaoRegistros.DataSource = listaOrdenada;
                    break;
                case 3:
                    listaOrdenada = listaRegistros.OrderBy(registro => registro.TipoRegistro).ToList();
                    listaAtual = listaOrdenada;
                    this.metroGridVisualizacaoRegistros.DataSource = listaOrdenada;
                    break;
                case 4:
                    listaOrdenada = listaRegistros.OrderBy(registro => registro.Estado).ToList();
                    listaAtual = listaOrdenada;
                    this.metroGridVisualizacaoRegistros.DataSource = listaOrdenada;
                    break;
                default:
                    listaOrdenada = listaRegistros.OrderByDescending(registro => registro.HorarioCadastroRegistro).ToList();
                    listaAtual = listaOrdenada;
                    this.metroGridVisualizacaoRegistros.DataSource = listaOrdenada;
                    break;
            }
        }
        private void resetaFiltros()
        {
            metroTextBoxFiltrar.Text = "";
            ajustaHorariosDatetimes();
            metroComboBoxOrdenar.SelectedIndex = 0;
        }

        private List<RegistroModel> getAllRegistrosByFilter(string filter)
        {
            filter = UtilityClass.RemoveDiacritics(filter, true).ToLower();

            List<RegistroModel> listaFiltrada = new List<RegistroModel>();
            listaFiltrada = (from registro in listaRegistros
                             where registro.Nome.ToLower().Contains(filter) || registro.Sobrenome.ToLower().Contains(filter) ||
                             registro.TipoRegistro.ToString().ToLower().Equals(filter) || registro.Estado.ToLower().Contains(filter)
                             || registro.Telefone.ToString().ToLower().Contains(filter) || registro.CPF.Contains(filter)
                             || registro.RazaoSocial.ToLower().Contains(filter)
                             select registro).ToList();
            return listaFiltrada;
        }

        private void metroButtonFiltrarGrid_Click(object sender, EventArgs e)
        {
            string valorFiltro = UtilityClass.RemoveDiacritics(this.metroTextBoxFiltrar.Text.ToLower(), true);

            if (string.IsNullOrWhiteSpace(valorFiltro))
                atualizaGrid(null, true);

            if (valorFiltro.Contains("potencial"))
                valorFiltro = TipoRegistro.Potencial_cliente.ToString().ToLower();

            List<RegistroModel> listaFiltrada = getAllRegistrosByFilter(valorFiltro);
            listaAtual = listaFiltrada;
            atualizaGrid(listaFiltrada, false);
        }
        private void ajustaHorariosDatetimes()
        {
            this.metroDateTimeInicio.Format = DateTimePickerFormat.Custom;
            this.metroDateTimeInicio.CustomFormat = "d 'de' MMMM 'de' yyyy";
            this.metroDateTimeTermino.Format = DateTimePickerFormat.Custom;
            this.metroDateTimeTermino.CustomFormat = "d 'de' MMMM 'de' yyyy";

            this.metroDateTimeInicio.MaxDate = DateTime.Now;
            this.metroDateTimeTermino.MaxDate = DateTime.Now;
            this.metroDateTimeInicio.MinDate = new DateTime(2020, 01, 01);
            this.metroDateTimeInicio.Value = DateTime.Now.AddDays(-7);
            this.metroDateTimeTermino.MinDate = metroDateTimeInicio.Value;
        }
        private void metroDateTimeInicio_ValueChanged(object sender, EventArgs e)
        {
            metroDateTimeTermino.MinDate = metroDateTimeInicio.Value;
        }

        private void metroDateTimeTermino_ValueChanged(object sender, EventArgs e)
        {
            metroDateTimeInicio.MaxDate = metroDateTimeTermino.Value;
        }

        private void ajustaDataGrid()
        {
            this.metroGridVisualizacaoRegistros.Columns[2].HeaderText = "Tipo de registro";
            this.metroGridVisualizacaoRegistros.Columns[5].HeaderText = "Razão social";
            this.metroGridVisualizacaoRegistros.Columns[12].HeaderText = "E-mail";

            // ver se tem como pegar o rows[0] e setar o height dele

            this.metroGridVisualizacaoRegistros.Columns[2].Width = 115;
            this.metroGridVisualizacaoRegistros.Columns[3].Width = 100;
            this.metroGridVisualizacaoRegistros.Columns[4].Width = 130;
            this.metroGridVisualizacaoRegistros.Columns[5].Width = 100;
            this.metroGridVisualizacaoRegistros.Columns[9].Width = 100;
            this.metroGridVisualizacaoRegistros.Columns[12].Width = 155;
            this.metroGridVisualizacaoRegistros.Columns[15].Width = 105;

            this.metroGridVisualizacaoRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.metroGridVisualizacaoRegistros.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[2].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[3].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[4].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[5].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[9].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[12].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[15].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[0].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[1].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[6].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[7].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[8].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[10].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[11].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[13].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[14].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[16].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[17].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[18].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[19].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[20].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[21].Visible = false;
        }

        private void metroButtonResetarFiltrosEGrid_Click(object sender, EventArgs e)
        {
            atualizaGrid(null, true);
        }

        private void pictureBoxExportarExcel_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxExportarExcel.Cursor = Cursors.Hand;
        }

        private void pictureBoxExportarPDF_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxExportarPDF.Cursor = Cursors.Hand;
        }

        private void pictureBoxExportarExcel_Click(object sender, EventArgs e)
        {
            exportarParaArquivo(true);
        }

        private void pictureBoxExportarPDF_Click(object sender, EventArgs e)
        {
            exportarParaArquivo(false);
        }

        private void exportarParaArquivo(bool isExcel)
        {
            ExportadorXlsPdf<RegistroModel> exportadorXlsPdf = new ExportadorXlsPdf<RegistroModel>();
            MensagemModel mensagem;

            if (listaRegistros.Count == 0)
            {
                mostraMensagemEscondeGrid("A tabela está vazia, não há registros para serem exportados!.", "Erro ao exportar registros");
                return;
            }

            mensagem = exportadorXlsPdf.verificarDisponibilidadeExcel();
            if (!mensagem.Sucesso)
            {
                mostraMensagemEscondeGrid("O Excel não está disponível neste computador.", "Erro ao iniciar excel");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            if (isExcel)
            {
                sfd.Filter = "Excel |*.xls";
                sfd.Title = "Salvar registros em arquivo EXCEL";
            }
            else
            {
                sfd.Filter = "PDF |*.pdf";
                sfd.Title = "Salvar registros em arquivo PDF";
            }

            sfd.AddExtension = true;

            string dataAtual = DateTime.Now.ToString("dd-MM-yy_hh-mm-ss");

            sfd.FileName = "MeNutri_TabelaRegistros_" + dataAtual;

            string nomeDaPlanilha = "MeNutri Registros - " + DateTime.Now.ToString("dd-MM-yy");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                mensagem = exportadorXlsPdf.exportarTabelaParaArquivo(listaAtual, isExcel, sfd.FileName, headersDoGrid(), nomeDaPlanilha);

                if (mensagem.Sucesso)
                {
                    this.metroGridVisualizacaoRegistros.Visible = false;
                    MetroMessageBox.Show(this, "A tabela foi exportada com sucesso", "Tabela exportada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.metroGridVisualizacaoRegistros.Visible = true;

                    if (MessageBox.Show(this, "Deseja abrir o arquivo gerado?", "Ver arquivo exportado.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (File.Exists(sfd.FileName))
                            System.Diagnostics.Process.Start(sfd.FileName);
                    }
                }
                else
                {
                    mostraMensagemEscondeGrid(mensagem.Corpo, mensagem.Titulo);
                }
            }
            else
            {
                MessageBox.Show(this, "A exportação foi cancelada.", "Operação não concluida", MessageBoxButtons.OK);
            }
        }

        public List<string> headersDoGrid()
        {
            List<string> listaHeaders = new List<string>();
            listaHeaders.Add("Horário de cadastro");
            listaHeaders.Add("Tipo de registro");
            listaHeaders.Add("Nome");
            listaHeaders.Add("Sobrenome");
            listaHeaders.Add("Razão Social");
            listaHeaders.Add("Cargo e Diretoria");
            listaHeaders.Add("CPF");
            listaHeaders.Add("RG");
            listaHeaders.Add("Telefone");
            listaHeaders.Add("Instagram");
            listaHeaders.Add("Whatsapp");
            listaHeaders.Add("E-mail");
            listaHeaders.Add("CNPJ");
            listaHeaders.Add("CEP");
            listaHeaders.Add("Estado");
            listaHeaders.Add("Cidade");
            listaHeaders.Add("Rua");
            listaHeaders.Add("Número");
            listaHeaders.Add("Bairro");
            listaHeaders.Add("Complemento");
            listaHeaders.Add("Outros");

            return listaHeaders;
        }

        public void mostraMensagemEscondeGrid(string mensagem, string titulo)
        {
            this.metroGridVisualizacaoRegistros.Visible = false;
            MetroMessageBox.Show(this, mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.metroGridVisualizacaoRegistros.Visible = true;
        }

        public void controlaDisponibilidadeControles()
        {
            if (Globals.isAdminGeral())
            {
                this.metroButtonExcluirRegistro.Enabled = true;
                this.metroButtonExcluirRegistro.Visible = true;
            }

            if (Globals.isAdminComum() || Globals.isAdminGeral())
                this.metroButtonEditarRegistro.Enabled = true;

            this.metroButtonPesquisarRegistros.Enabled = true;
            this.metroButtonVisualizarRegistro.Enabled = true;
            this.metroButtonFiltrarGrid.Enabled = true;
            pictureBoxExportarExcel.Enabled = true;
            pictureBoxExportarPDF.Enabled = true;
        }

        private void metroButtonEditarRegistro_Click(object sender, EventArgs e)
        {
            RegistroModel registroSelecionado = this.metroGridVisualizacaoRegistros.SelectedRows[0].DataBoundItem as RegistroModel;
            TelaEditarVisualizarRegistro telaEditarVisualizarRegistro = new TelaEditarVisualizarRegistro(true, registroSelecionado);
            telaEditarVisualizarRegistro.Show();
        }

        private void metroButtonVisualizarRegistro_Click(object sender, EventArgs e)
        {
            TelaEditarVisualizarRegistro telaEditarVisualizarRegistro = new TelaEditarVisualizarRegistro(false);
            telaEditarVisualizarRegistro.Show();
        }
    }
}
