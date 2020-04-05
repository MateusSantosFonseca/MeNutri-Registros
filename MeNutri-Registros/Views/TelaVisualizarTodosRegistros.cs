using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public TelaVisualizarTodosRegistros()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Menutrinho_Icon;
            this.MaximizeBox = false;
            this.Resizable = false;
            this.metroGridVisualizacaoRegistros.Visible = true;

            if (Globals.isAdminGeral())
                this.metroButtonExcluirRegistro.Visible = true;

            this.metroComboBoxOrdenar.SelectedIndex = 0;

            ajustaHorariosDatetimes();

            RegistroController registroController = new RegistroController();
            this.listaRegistros = registroController.getAllRegistros();
            this.listaRegistrosOrdenada = listaRegistros.OrderByDescending(registro => registro.HorarioCadastroRegistro).ToList();
            this.metroGridVisualizacaoRegistros.DataSource = listaRegistrosOrdenada;

            ajustaDataGrid();
        }

        private void atualizaGrid([Optional] List<RegistroModel> listaAlterada, bool apenasReset)
        {
            if(listaAlterada != null && listaAlterada.Count > 0)
            {
                this.metroGridVisualizacaoRegistros.DataSource = listaAlterada;
            } 
            else
            {
                if (!apenasReset)
                {
                    this.metroGridVisualizacaoRegistros.Visible = false;
                    MetroMessageBox.Show(this, "Os filtros aplicados retornaram uma lista vazia. Filtros e tabela resetados.",
                                              "Erro ao iniciar tabela", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.metroGridVisualizacaoRegistros.Visible = true;
                }
                resetaFiltros();
                RegistroController registroController = new RegistroController();
                this.listaRegistros = registroController.getAllRegistros();
                this.listaRegistrosOrdenada = listaRegistros.OrderByDescending(registro => registro.HorarioCadastroRegistro).ToList();
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
                    this.metroGridVisualizacaoRegistros.DataSource = listaOrdenada;
                    break;
                case 2:
                    listaOrdenada = listaRegistros.OrderBy(registro => registro.RazaoSocial).ToList();
                    this.metroGridVisualizacaoRegistros.DataSource = listaOrdenada;
                    break;
                case 3:
                    listaOrdenada = listaRegistros.OrderBy(registro => registro.TipoRegistro).ToList();
                    this.metroGridVisualizacaoRegistros.DataSource = listaOrdenada;
                    break;
                case 4:
                    listaOrdenada = listaRegistros.OrderBy(registro => registro.Estado).ToList();
                    this.metroGridVisualizacaoRegistros.DataSource = listaOrdenada;
                    break;
                default:
                    listaOrdenada = listaRegistros.OrderByDescending(registro => registro.HorarioCadastroRegistro).ToList();
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
            List<RegistroModel> listaFiltrada = new List<RegistroModel>();
            listaFiltrada = (from registro in listaRegistros
                             where registro.Nome.ToLower().Contains(filter) || registro.Sobrenome.ToLower().Contains(filter) ||
                             registro.TipoRegistro.ToString().ToLower().Contains(filter) || registro.Estado.ToLower().Contains(filter)
                             select registro).ToList();

            return listaFiltrada;
        }

        private void metroButtonFiltrarGrid_Click(object sender, EventArgs e)
        {
            string valorFiltro = UtilityClass.RemoveDiacritics(this.metroTextBoxFiltrar.Text.ToLower());
            
            if (string.IsNullOrWhiteSpace(valorFiltro)) 
                atualizaGrid(null, true);

            if (valorFiltro.Contains("potencial"))
                valorFiltro = TipoRegistro.Potencial_cliente.ToString().ToLower();

            List<RegistroModel> listaFiltrada = getAllRegistrosByFilter(valorFiltro);
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
            this.metroDateTimeInicio.Value = DateTime.Now.AddMonths(-3);
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
            this.metroGridVisualizacaoRegistros.Columns[9].HeaderText = "E-mail";

            // ver se tem como pegar o rows[0] e setar o height dele

            this.metroGridVisualizacaoRegistros.Columns[2].Width = 115;
            this.metroGridVisualizacaoRegistros.Columns[3].Width = 100;
            this.metroGridVisualizacaoRegistros.Columns[4].Width = 130;
            this.metroGridVisualizacaoRegistros.Columns[5].Width = 100;
            this.metroGridVisualizacaoRegistros.Columns[8].Width = 100;
            this.metroGridVisualizacaoRegistros.Columns[9].Width = 155;
            this.metroGridVisualizacaoRegistros.Columns[12].Width = 95;

            this.metroGridVisualizacaoRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.metroGridVisualizacaoRegistros.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[2].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);


            this.metroGridVisualizacaoRegistros.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[3].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[4].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[5].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[8].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[9].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.metroGridVisualizacaoRegistros.Columns[12].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold, GraphicsUnit.Pixel);

            this.metroGridVisualizacaoRegistros.Columns[0].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[1].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[6].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[7].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[10].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[11].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[13].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[14].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[15].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[16].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[17].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[18].Visible = false;
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
    }
}
