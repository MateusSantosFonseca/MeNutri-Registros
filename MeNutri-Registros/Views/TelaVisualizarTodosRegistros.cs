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

namespace MeNutri_Registros.Views
{
    public partial class TelaVisualizarTodosRegistros : MetroForm
    {
        public TelaVisualizarTodosRegistros()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Menutrinho_Icon;
            this.MaximizeBox = false;
            this.Resizable = false;
            this.metroGridVisualizacaoRegistros.Visible = true;

            if (Globals.isAdminGeral())
                this.metroButtonExcluirRegistro.Visible = true;

            ajustaHorariosDatetimes();

            RegistroController registroController = new RegistroController();
            List<RegistroModel> listaRegistros = registroController.getAllRegistros();
            List<RegistroModel> listaRegistrosOrdenada = listaRegistros.OrderByDescending(registro => registro.HorarioCadastroRegistro).ToList();

            this.metroGridVisualizacaoRegistros.DataSource = listaRegistrosOrdenada;

            ajustaDataGrid();
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

            this.metroGridVisualizacaoRegistros.Columns[2].Width = 115;
            this.metroGridVisualizacaoRegistros.Columns[3].Width = 100;
            this.metroGridVisualizacaoRegistros.Columns[4].Width = 190;
            this.metroGridVisualizacaoRegistros.Columns[5].Width = 100;
            this.metroGridVisualizacaoRegistros.Columns[8].Width = 100;
            this.metroGridVisualizacaoRegistros.Columns[9].Width = 210;

            this.metroGridVisualizacaoRegistros.Columns[0].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[1].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[6].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[7].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[10].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[11].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[12].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[13].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[14].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[15].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[16].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[17].Visible = false;
            this.metroGridVisualizacaoRegistros.Columns[18].Visible = false;
        }
    }
}
