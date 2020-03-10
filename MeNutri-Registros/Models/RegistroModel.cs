using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MeNutri_Registros.Models
{
    public class RegistroModel
    {
        public Guid guid { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string CNPJ { get; set; }
        public string CEP { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string outros { get; set; }

        public RegistroModel(string nome, string sobrenome, string CPF, string RG, string telefone,
                             string email, string CNPJ, string CEP, string estado, string cidade,
                             string rua, string numero, string bairro, string complemento, string outros)
        {
            this.guid = Guid.NewGuid();
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.CPF = CPF;
            this.RG = RG;
            this.telefone = telefone;
            this.email = email;
            this.CNPJ = CNPJ;
            this.CEP = CEP;
            this.estado = estado;
            this.cidade = cidade;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.outros = outros;
        }

        public RegistroModel()
        {
            this.guid = Guid.NewGuid();
        }
    }
}
