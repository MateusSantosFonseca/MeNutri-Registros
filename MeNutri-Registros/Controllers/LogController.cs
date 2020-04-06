using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeNutri_Registros.Models;

namespace MeNutri_Registros.Controllers
{
    public class LogController
    {
        // public static readonly string PATH_LOGS = @"\MeNutri-Registros\Logs"; // Para testes
        public static readonly string PATH_LOGS = @"\Logs"; // Para produção
        public static void logarErro(LogModel log)
        {
            // string diretorioAtual = (Path.GetDirectoryName(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName)) + PATH_LOGS; // Para testes
            string diretorioAtual = AppDomain.CurrentDomain.BaseDirectory + PATH_LOGS; // Para produção
            string pathArquivoTextoLog = diretorioAtual + @"\" + log.dataExcessao.ToString("dd-MM-yyyy_hh-mm-ss") + "_" +
                                              UtilityClass.RemoveDiacritics(log.nomeExcessao.Replace(" ", "-"), false) + ".txt";

            try
            {
                // Essa condicao apenas existe em produção
                if (!Directory.Exists(diretorioAtual))
                    Directory.CreateDirectory(diretorioAtual);

                TextWriter tw = new StreamWriter(pathArquivoTextoLog);

                tw.WriteLine("Nome da exceção: " + log.nomeExcessao);
                tw.WriteLine("\nData da exceção: " + log.dataExcessao.ToString("dd/MM/yyyy hh:mm:ss"));
                tw.WriteLine("\nMensagem da exceção: " + log.messageExcessao);
                tw.WriteLine("\nStackTrace da exceção: " + log.stacktraceExcessao);
                tw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("O arquivo de erro não pode ser escrito. \nStackTrace:\n " + e.StackTrace,
                                                "Erro não arquivado", MessageBoxButtons.OK);
            }
        }
    }
}
