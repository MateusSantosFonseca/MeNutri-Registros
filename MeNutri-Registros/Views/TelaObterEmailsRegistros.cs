using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeNutri_Registros.Models;
using MetroFramework;
using MetroFramework.Forms;

namespace MeNutri_Registros.Views
{
    public partial class TelaObterEmailsRegistros : MetroForm
    {
        List<RegistroModel> registrosRecuperados;

        List<RegistroModel> registrosFiltrados;


        public TelaObterEmailsRegistros(List<RegistroModel> registros)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Menutrinho_Icon;
            this.MaximizeBox = false;
            this.Resizable = false;

            this.metroLabelCopiadoParaClipboard.Text = string.Empty;
            this.metroComboBoxFiltrarEmail.SelectedIndex = 0;
            this.registrosRecuperados = registros;
            this.registrosFiltrados = registros;
        }

        private void metroComboBoxOrdenar_SelectionChangeCommited(object sender, EventArgs e)
        {
            this.registrosFiltrados = null;
            this.metroTextBoxEmailsGerados.Text = string.Empty;
            this.metroLabelCopiadoParaClipboard.Text = string.Empty;

            string ordenarPor = UtilityClass.RemoveDiacritics(this.metroComboBoxFiltrarEmail.Text.ToLower(), true).Replace(" ", "_");

            // switch case utilizado no caso de adição de mais possibilidadades de filtros
            switch (ordenarPor)
            {
                case "todos":
                    registrosFiltrados = registrosRecuperados;
                    break;

                default:
                    registrosFiltrados = (from registro in registrosRecuperados
                                          where registro.TipoRegistro.ToString().ToLower().Equals(ordenarPor)
                                          select registro).ToList();
                    break;

            }
        }

        private void metroButtonGerarEmails_Click(object sender, EventArgs e)
        {
            string emails = string.Empty;
            this.metroLabelCopiadoParaClipboard.Text = string.Empty;

            if (registrosFiltrados == null)
            {
                MetroMessageBox.Show(this, "Não existem registros cadastrados, a string não pode ser gerada", "Não há registros", MessageBoxButtons.OK, MessageBoxIcon.Error, 243);
                return;
            }
            else
            {
                foreach (RegistroModel registro in registrosFiltrados)
                {
                    if (registro.Email != "vazio" && !string.IsNullOrWhiteSpace(registro.Email))
                        emails += registro.Email + ';';
                }

                if (string.IsNullOrEmpty(emails))
                {
                    this.metroTextBoxEmailsGerados.Text = "Embora hajam registros, nenhum deles possuiam e-mail cadastrado.";
                }
                else
                {
                    emails += ConfigurationManager.AppSettings["emailsPadrao"];
                    this.metroTextBoxEmailsGerados.Text = emails;
                }
            }
        }

        private void metroButtonCopiarClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.metroTextBoxEmailsGerados.Text))
            {
                Clipboard.SetText(this.metroTextBoxEmailsGerados.Text);
                this.metroLabelCopiadoParaClipboard.Text = "Copiado para o clipboard!!";
            }
            else
            {
                this.metroLabelCopiadoParaClipboard.Text = "Não existem e-mails para serem copiados!!";
                Clipboard.SetText(" ");
            }
        }
    }
}
