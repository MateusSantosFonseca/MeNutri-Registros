using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeNutri_Registros.Controllers
{
    // Tendo em vista que o sistema, por regra do usuário, não precisa de mais de 3 usuários. Foi pedido que houvessem apenas 3 usuários pré-cadastrados
    // Não havia a necessidade de cadastrar mais. Portanto, as senhas/usuarios são comparadas no próprio código, onde elas estão inseridas (senhas no app config)

    public class LoginController
    {
        public void verificaUsuarioSenha(string usuario, string senha)
        {
            int tipoUsuario = 0;

            switch (usuario)
            {
                case "usuario":
                    if (senha.Equals(ConfigurationManager.AppSettings["senhaUserComum"]))
                        tipoUsuario = 1;
                    break;

                case "admin":
                    if (senha.Equals(ConfigurationManager.AppSettings["senhaAdminComum"]))
                        tipoUsuario = 2;
                    break;

                case "bianca":
                    if (senha.Equals(ConfigurationManager.AppSettings["senhaAdminGeral"]))
                        tipoUsuario = 3;
                    break;

                default:
                    break;
            }

            converteTipoPermissao(tipoUsuario);
        }

        private void converteTipoPermissao(int tipoUsuario)
        {
            switch (tipoUsuario)
            {
                case 1:
                    Globals.tipoDeUsuario = Globals.usuarioComumString;
                    break;
                case 2:
                    Globals.tipoDeUsuario = Globals.adminComumString;
                    break;
                case 3:
                    Globals.tipoDeUsuario = Globals.adminGeralString;
                    break;
                default:
                    Globals.tipoDeUsuario = Globals.naoAutenticadoString;
                    break;
            }
        }

    }
}
