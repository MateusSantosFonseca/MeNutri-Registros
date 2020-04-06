using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeNutri_Registros.Controllers;
using MeNutri_Registros.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace MeNutri_Registros
{
    public class ExportadorXlsPdf<T>
    {
        public ExportadorXlsPdf()
        {
            //List<Object> listaObjetos
            //if (verificarDisponibilidadeExcel() == true)
            //    exportarParaExcelOuPdf(false);
        }

        public MensagemModel exportarTabelaParaArquivo(List<T> listaGenerica, bool isExcel, string pathArquivo)
        {
            //tirar instanciacao
            MensagemModel mensagem = new MensagemModel();

  

            mensagem.Sucesso = true;
            return mensagem;
        }


        public MensagemModel verificarDisponibilidadeExcel()
        {
            MensagemModel mensagem;
            try
            {
                Excel.Application xlexcel = new Excel.Application();
                xlexcel.Quit();
                releaseObject(xlexcel);
                mensagem = new MensagemModel(true);
            }
            catch (Exception e)
            {
                mensagem = new MensagemModel("Tentativa de abrir excel falhou.", "O excel não está disponível nesta máquina.", false);
                LogModel log = new LogModel(mensagem.Titulo, e.Message, e.StackTrace, DateTime.Now);
                LogController.logarErro(log);
                MessageBox.Show(mensagem.Corpo, mensagem.Titulo, MessageBoxButtons.OK);
            }

            return mensagem;
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception e)
            {
                obj = null;
                MensagemModel mensagem = new MensagemModel("Erro ao utilizar Excel", "Ocorreram erros na utilização no Excel, tente novamente.");
                LogModel log = new LogModel(mensagem.Titulo, e.Message, e.StackTrace, DateTime.Now);
                LogController.logarErro(log);
                MessageBox.Show(mensagem.Corpo, mensagem.Titulo, MessageBoxButtons.OK);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
