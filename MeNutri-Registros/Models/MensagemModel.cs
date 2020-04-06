using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeNutri_Registros.Models
{
    public class MensagemModel
    {
        public string Titulo { get; set; }
        public string Corpo { get; set; }
        public bool Sucesso { get; set; }

        public MensagemModel(string titulo, string corpo)
        {
            this.Corpo = corpo;
            this.Titulo = titulo;
        }

        public MensagemModel(string titulo, string corpo, bool sucesso)
        {
            this.Corpo = corpo;
            this.Titulo = titulo;
            this.Sucesso = sucesso;
        }

        public MensagemModel(bool sucesso)
        {
            this.Corpo = "Não preenchido";
            this.Titulo = "Não preenchido";
            this.Sucesso = sucesso;
        }

        public MensagemModel() { }
    }
}
