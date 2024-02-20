using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Empresa
{
    public class Empresas
    {
        public string cNPJ { get; set; }
        public string razao_Social { get; set; }
        public string nome_Fantasia { get; set; }
        public string situacao_Cadastral { get; set; }
        public DateTime data_Inicio { get; set; }
        public string telefone { get; set; }
        public string capital_Social { get; set; }
        public string natureza_Juridica { get; set; }
        public string regime_Tributario { get; set; }
        public string nome_Proprietario { get; set; }
        public string cPF_Proprietario { get; set; }
        public string tipo { get; set; }
        public string porte_Empresa { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string referencia { get; set; }

        public Empresas(string cNPJ, string razao_Social,string nome_Fantasia,string situacao_Cadastral, DateTime data_Inicio,
        string telefone, string capital_Social, string natureza_Juridica, string regime_Tributario, string nome_Proprietario,
        string cPF_Proprietario, string tipo, string porte_Empresa,string estado,string cidade,
        string bairro, string rua, string numero, string referencia )
        {

            this.cNPJ = cNPJ;
            this.razao_Social = razao_Social;
            this.nome_Fantasia = nome_Fantasia;
            this.situacao_Cadastral = situacao_Cadastral;
            this.data_Inicio = data_Inicio;
            this.telefone = telefone;
            this.capital_Social = capital_Social;
            this.natureza_Juridica = natureza_Juridica;
            this.regime_Tributario = regime_Tributario;
            this.nome_Proprietario = nome_Fantasia;
            this.cPF_Proprietario = cPF_Proprietario;
            this.tipo = tipo;
            this.porte_Empresa = porte_Empresa;
            this.estado = estado;
            this.cidade = cidade;
            this.bairro=bairro;
            this.rua = rua;
            this.numero = numero;
            this.referencia = referencia;
    }
        }

    

}
