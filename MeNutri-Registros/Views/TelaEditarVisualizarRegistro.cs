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
using MeNutri_Registros.Models;
using MetroFramework.Forms;

namespace MeNutri_Registros.Views
{
    public partial class TelaEditarVisualizarRegistro : MetroForm
    {
        bool isEdit = false;

        public TelaEditarVisualizarRegistro(bool isEdit, [Optional] RegistroModel guidRegistro)
        {
            InitializeComponent();

            this.isEdit = isEdit;

            if (isEdit)
                this.Text = "Editar Registro";

            this.Icon = Properties.Resources.Menutrinho_Icon;
            this.MaximizeBox = false;
            this.Resizable = false;
        }

        public void metroRadioButtonCliente_CheckedChange(object sender, EventArgs e)
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

        public void metroRadioButtonFuncionario_CheckedChange(object sender, EventArgs e)
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
    }
}
