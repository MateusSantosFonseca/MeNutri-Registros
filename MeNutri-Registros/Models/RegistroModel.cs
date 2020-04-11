using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MeNutri_Registros.Models
{
    public enum TipoRegistro
    {
        Potencial_cliente,
        Cliente,
        Funcionario,
    }

    public class RegistroModel
    {
        public Guid Guid { get; set; }
        public DateTime HorarioUltimaEdicao { get; set; }
        public TipoRegistro TipoRegistro { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string RazaoSocial { get; set; }
        public string CargoDiretoria { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public string Instagram { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Outros { get; set; }

        public RegistroModel(TipoRegistro tipoRegistro, DateTime horarioUltimaEdicao, string razaoSocial, string cargoDiretoria,
            string nome, string sobrenome, string CPF, string RG, string telefone, string instagram, string whatsapp, string email,
            string CNPJ, string CEP, string estado, string cidade, string rua, string numero, string bairro, string complemento, string outros)
        {
            this.Guid = Guid.NewGuid();
            this.HorarioUltimaEdicao = horarioUltimaEdicao;
            this.TipoRegistro = tipoRegistro;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.RazaoSocial = razaoSocial;
            this.CargoDiretoria = cargoDiretoria;
            this.CPF = CPF;
            this.RG = RG;
            this.Telefone = telefone;
            this.Instagram = instagram;
            this.Whatsapp = whatsapp;
            this.Email = email;
            this.CNPJ = CNPJ;
            this.CEP = CEP;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Rua = rua;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Complemento = complemento;
            this.Outros = outros;
        }
        public RegistroModel()
        {
            this.Guid = Guid.NewGuid();
        }
    }
}
