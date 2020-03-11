using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeNutri_Registros.Models
{
    public class LogModel
    {
        public string nomeExcessao { get; set; }
        public string messageExcessao { get; set; }
        public string stacktraceExcessao { get; set; }
        public DateTime dataExcessao { get; set; }

        public LogModel(string nomeExcessao, string messageExcessao, string stacktraceExcessao, DateTime dataExcessao)
        {
            this.nomeExcessao = nomeExcessao;
            this.messageExcessao = messageExcessao;
            this.stacktraceExcessao = stacktraceExcessao;
            this.dataExcessao = dataExcessao;
        }
    }
}
