using System;
using System.Collections.Generic;
using System.Drawing;
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

        public MensagemModel exportarTabelaParaArquivo(List<T> listaGenerica, bool isExcel, string pathArquivo, List<string> headersDoGrid)
        {
            MensagemModel mensagem;

            try
            {
                object valorEmBranco = System.Reflection.Missing.Value; // Para parâmetros com valores não informados
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false;

                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(valorEmBranco);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // O limite para o nome de uma planilha é de 31 caracteres, essa linha atende à esta regra e a nomeia
                xlWorkSheet.Name = "MeNutri Registros - " + DateTime.Now.ToString("dd-MM-yy");

                char auxColunasHeader = '@';
                for (int i = 0 ; i < headersDoGrid.Count; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = headersDoGrid[i];
                    auxColunasHeader++;
                }

                Excel.Range cabecalho = xlWorkSheet.Range[$"A1:{auxColunasHeader}1"];

                var propriedades = typeof(T).GetProperties();
                int countLinha = 2;
                foreach (object obj in listaGenerica)
                {
                    int countColuna = 1;
                    foreach (var prop in propriedades)
                    {
                        if (prop.PropertyType == typeof(Guid))
                            continue;

                        string valor = prop.GetValue(obj, null).ToString();

                        xlWorkSheet.Cells[countLinha, countColuna] = "'" + valor; // o ' serve para todos campos serem tratados como string

                        countColuna++;
                    }
                    countLinha++;
                }

                cabecalho.Font.Color = Color.FromArgb(0, 3, 98);
                cabecalho.Font.Bold = true;
                cabecalho.Interior.Color = Color.FromArgb(211, 211, 211);

                xlWorkSheet.Activate();
                xlWorkSheet.Application.ActiveWindow.SplitRow = 1;
                xlWorkSheet.Application.ActiveWindow.FreezePanes = true;

                xlWorkSheet.Columns.AutoFit();
                xlWorkSheet.Columns.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                cabecalho.Font.Color = Color.FromArgb(0, 3, 98);
                cabecalho.Font.Bold = true;
                cabecalho.Interior.Color = Color.FromArgb(211, 211, 211);

                xlWorkBook.SaveAs(pathArquivo, Excel.XlFileFormat.xlWorkbookNormal, valorEmBranco, valorEmBranco, valorEmBranco, valorEmBranco, Excel.XlSaveAsAccessMode.xlExclusive, valorEmBranco, valorEmBranco, valorEmBranco, valorEmBranco, valorEmBranco);
                xlWorkBook.Close(true, valorEmBranco, valorEmBranco);

                mensagem = new MensagemModel(true);
            }

            catch (Exception e)
            {
                mensagem = new MensagemModel("Erro ao construir o arquivo excel/pdf", "Ocorreu um erro no momento de povoar o conteúdo do arquivo", false);
                LogModel log = new LogModel(mensagem.Titulo, e.Message, e.StackTrace, DateTime.Now);
                LogController.logarErro(log);
                MessageBox.Show(mensagem.Corpo, mensagem.Titulo, MessageBoxButtons.OK);
            }


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
