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
    public partial class TelaVisualizarTodosRegistros : MetroForm
    {
        public TelaVisualizarTodosRegistros()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Watermelon_icon;
            this.MaximizeBox = false;
            this.Resizable = false;
            this.metroGridVisualizacaoRegistros.Visible = true;
            RegistroController registroController = new RegistroController();
            this.metroGridVisualizacaoRegistros.DataSource = registroController.getAllRegistros();
        }
    }
}
