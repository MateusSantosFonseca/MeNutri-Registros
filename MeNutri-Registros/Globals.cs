using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeNutri_Registros
{
    public static class Globals
    {
        public const string usuarioComumString = "user-comum";

        public const string adminComumString = "administrador-comum";

        public const string adminGeralString = "administrador-geral";

        public const string naoAutenticadoString = "nao-autenticado";

        public static string tipoDeUsuario = string.Empty;

        public static bool isUserComum()
        {
            return tipoDeUsuario.Equals(usuarioComumString) ? true : false;
        }

        public static bool isAdminComum()
        {
            return tipoDeUsuario.Equals(adminComumString) ? true : false;
        }
        public static bool isAdminGeral()
        {
            return tipoDeUsuario.Equals(adminGeralString) ? true : false;
        }
        public static bool isNaoAutenticado()
        {
            return tipoDeUsuario.Equals(naoAutenticadoString) || String.IsNullOrWhiteSpace(tipoDeUsuario) ? true : false;
        }
    }
}
