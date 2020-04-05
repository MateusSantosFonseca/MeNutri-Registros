using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.Serialization.JsonNet;
using FireSharp.Serialization.ServiceStack;
using MeNutri_Registros.Models;
using Newtonsoft.Json;
using ServiceStack.Text;

namespace MeNutri_Registros.Controllers
{
    public class RegistroController
    {
        public readonly string PATH_FIREBASE = "/";

        IFirebaseClient client;

        public RegistroController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = ConfigurationManager.AppSettings["authSecret"],
                BasePath = ConfigurationManager.AppSettings["basePath"]
            };

            this.client = new FirebaseClient(config);
        }

        public void postRegistro(RegistroModel registro)
        {
            try
            {
                SetResponse response = client.Set(PATH_FIREBASE + registro.Guid, registro);
                MessageBox.Show("O registro foi inserido com sucesso.", "Inserção concluída", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MensagemModel mensagem = new MensagemModel("Erro ao incluir registro", "Não foi possível adicionar o registro, possivelmente devido à problemas de conexão com a internet, tente novamente mais tarde.");
                LogModel log = new LogModel(mensagem.Titulo, e.Message, e.StackTrace, DateTime.Now);
                LogController.logarErro(log);
                MessageBox.Show(mensagem.Corpo, mensagem.Titulo, MessageBoxButtons.OK);
            }
        }

        // Lembrar que o guid do registro alterado deve ser o mesmo do guid do objeto construido pela alteração, ou seja:
        // Na hora de passar o registro para esse método, devo garantir que o guid do registro sendo passado como paramentro
        // seja IGUAL ao guid do registro que será alterado no banco de dados
        public void updateRegistro(RegistroModel registro)
        {
            try
            {
                FirebaseResponse response = client.Update(PATH_FIREBASE + registro.Guid, registro);
                MessageBox.Show("O registro foi editado com sucesso.", "Edição concluída", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MensagemModel mensagem = new MensagemModel("Erro ao editar registro", "Não foi possível editar o registro, possivelmente devido à problemas de conexão com a internet, tente novamente mais tarde.");
                LogModel log = new LogModel(mensagem.Titulo, e.Message, e.StackTrace, DateTime.Now);
                LogController.logarErro(log);
                MessageBox.Show(mensagem.Corpo, mensagem.Titulo, MessageBoxButtons.OK);
            }
        }

        public void deleteRegistro(Guid guid)
        {
            try
            {
                FirebaseResponse response = client.Delete(PATH_FIREBASE + guid);
                MessageBox.Show("O registro foi excluido com sucesso.", "Exclusão concluída", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MensagemModel mensagem = new MensagemModel("Erro ao Excluir registro", "Não foi possível excluir o registro, possivelmente devido à problemas de conexão com a internet, tente novamente mais tarde.");
                LogModel log = new LogModel(mensagem.Titulo, e.Message, e.StackTrace, DateTime.Now);
                LogController.logarErro(log);
                MessageBox.Show(mensagem.Corpo, mensagem.Titulo, MessageBoxButtons.OK);
            }
        }

        public RegistroModel getRegistro(Guid guid)
        {
            try
            {
                FirebaseResponse response = client.Get(PATH_FIREBASE + guid);
                RegistroModel registro = response.ResultAs<RegistroModel>();
                return registro;
            }
            catch (Exception e)
            {
                MensagemModel mensagem = new MensagemModel("Erro ao recuperar registro", "Não foi possível recuperar o registro, possivelmente devido à problemas de conexão com a internet, tente novamente mais tarde.");
                LogModel log = new LogModel(mensagem.Titulo, e.Message, e.StackTrace, DateTime.Now);
                LogController.logarErro(log);
                MessageBox.Show(mensagem.Corpo, mensagem.Titulo, MessageBoxButtons.OK);
            }
            return null;
        }

        public List<RegistroModel> getAllRegistros()
        {
            List<RegistroModel> registros = new List<RegistroModel>();

            try
            {
                FirebaseResponse response = client.Get(PATH_FIREBASE);
                if (!response.Body.Equals("null"))
                {
                    string[] stringArrayJson = formatarStringParaArrayStringJson(response.Body);

                    foreach (string json in stringArrayJson)
                        registros.Add(JsonConvert.DeserializeObject<RegistroModel>(json));
                }
                else
                {
                    MessageBox.Show("Não existem registros cadastrados no sistema.", "Não existem registros cadastrados", MessageBoxButtons.OK);
                    registros = null;
                }
            }
            catch (Exception e)
            {
                MensagemModel mensagem = new MensagemModel("Erro ao recuperar todos registros", "Não foi possível recuperar os registros, possivelmente devido à problemas de conexão com a internet, tente novamente mais tarde.");
                LogModel log = new LogModel(mensagem.Titulo, e.Message, e.StackTrace, DateTime.Now);
                LogController.logarErro(log);
                MessageBox.Show(mensagem.Corpo, mensagem.Titulo, MessageBoxButtons.OK);
                registros = null;
            }

            return registros;
        }

        private string[] formatarStringParaArrayStringJson(string stringJsonRaw)
        {
            string auxiliarJson = string.Empty;
            auxiliarJson = stringJsonRaw.Remove(stringJsonRaw.IndexOf('{'), 1); // Remove primeiro {
            auxiliarJson = auxiliarJson.Remove(auxiliarJson.Length - 2); // Remove os ultimos dois }}

            string[] auxArrayJson = auxiliarJson.Split(new string[] { "}," }, StringSplitOptions.None); // Splita por },

            for (int i = 0; i < auxArrayJson.Length; i++)
                auxArrayJson[i] = (auxArrayJson[i].Substring(auxArrayJson[i].IndexOf(':') + 1)) + '}'; // Remove tudo antes do primeiro ':' no indice
                                                                                                       // e acrescenta } para finalizar o modelo json
            return auxArrayJson;
        }
    }
}
