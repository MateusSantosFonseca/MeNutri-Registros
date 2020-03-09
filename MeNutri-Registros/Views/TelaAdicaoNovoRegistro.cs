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
    public partial class TelaAdicaoNovoRegistro : MetroForm
    {
        public TelaAdicaoNovoRegistro()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Watermelon_icon;
        }

        private void metroButtonAdicionarRegistro_Click(object sender, EventArgs e)
        {
            //RegistroController registroController = new RegistroController();

            //RegistroModel registroParaTeste = new RegistroModel("TesteNome", "TesteSobrenome", "TesteCpf", "TesteRG", "TesteTelefone", "TesteEmail", "TesteCNPJ", "TesteCEP", "TesteEstado,",
            //    "TesteCidade", "TesteRua", "TesteNumero", "TesteBairro", "TesteComplemento", "TesteOutros");

            //registroController.postRegistro(registroParaTeste);
            //registroController.getAllRegistros();
        }
    }
}
