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

        public MensagemModel(string titulo, string corpo)
        {
            this.Corpo = corpo;
            this.Titulo = titulo;
        }
    }
}
