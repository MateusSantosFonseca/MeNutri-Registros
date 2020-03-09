using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.Serialization.JsonNet;
using FireSharp.Serialization.ServiceStack;
using MeNutri_Registros.Models;
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

        public async void postRegistro(RegistroModel registro)
        {
            PushResponse response = await client.PushAsync(PATH_FIREBASE, registro);
            // RegistroModel result = response.ResultAs<RegistroModel>(); // Contem o dado que foi escrito
        }

        public async void putRegistro()
        {

            // alteração

        }

        public async void deleteRegistro()
        {

            // lembrar de pergunta se tem certeza que deseja cancelar

        }

        public async void getAllRegistros()
        {
            FirebaseResponse response = await client.GetAsync(PATH_FIREBASE);
            string aux = response.Body;
            // string[] values = aux.Split(new string[] { "}," }, StringSplitOptions.None);
            // string[] values2 = aux.Split('}');
            //ver como formatar essa aux pra gerar um array de RegistroModel, pra conseguir iterar e mostrar todos registros
        }
    }
}
