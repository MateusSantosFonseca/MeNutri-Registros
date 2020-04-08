using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MeNutri_Registros
{
    public static class UtilityClass
    {
        public static string RemoveDiacritics(string text, bool removerTraco)
        {
            text = text.Replace(".", "");

            if (removerTraco)
                text = text.Replace("-", "");

            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public static string retornaApenasNumeros(string baseString)
        {
            return Regex.Replace(baseString, "[^0-9.]", "").Trim();
        }

        public static string substituiCaracteresEspeciaisPorEspaco(string texto)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            return rgx.Replace(texto, " ");
        }
        public static string getNomeUFbyIniciais(string iniciaisEstado)
        {
            switch (iniciaisEstado)
            {
                case "MG":
                    return "Minas Gerais";
                case "SP":
                    return "São Paulo";
                case "RJ":
                    return "Rio de Janeiro";
                case "ES":
                    return "Espirito Santo";
                case "AC":
                    return "Acre";
                case "AL":
                    return "Alagoas";
                case "AM":
                    return "Amazonas";
                case "AP":
                    return "Amapá";
                case "BA":
                    return "Bahia";
                case "CE":
                    return "Ceará";
                case "DF":
                    return "Distrito Federal";
                case "GO":
                    return "Goiás";
                case "MT":
                    return "Mato Grosso";
                case "MS":
                    return "Mato Grosso do Sul";
                case "PA":
                    return "Pará";
                case "PB":
                    return "Paraíba";
                case "PE":
                    return "Pernambuco";
                case "PI":
                    return "Piauí";
                case "PR":
                    return "Paraná";
                case "RN":
                    return "Rio Grande do Norte";
                case "RR":
                    return "Roraima";
                case "RO":
                    return "Rondônia";
                case "RS":
                    return "Rio Grande do Sul";
                case "SC":
                    return "Santa Catarina";
                case "SE":
                    return "Sergipe";
                case "TO":
                    return "Tocantins";
                case "MA":
                    return "Maranhão";
                default:
                    return "Estado não encontrado";
            }
        }
    }
}
