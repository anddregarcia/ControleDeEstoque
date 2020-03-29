using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtHome.ControleDeEstoque.Domain
{
    public class Configuracao
    {

        public Configuracao()
        {

        }

        public Configuracao(bool exigeSenha, String senha, String empresa, String telefone, String cabecalho, String logotipo)
        {
            this.ExigeSenha = exigeSenha;
            this.Senha = senha;
            this.NomeDaEmpresa = empresa;
            this.TelefoneRelatorio = telefone;
            this.CabecalhoRelatorio = cabecalho;
            this.LogoTipo = logotipo;
        }

        public bool ExigeSenha { get; set; }
        public String Senha { get; set; }
        public String NomeDaEmpresa { get; set; }
        public String TelefoneRelatorio { get; set; }
        public String CabecalhoRelatorio { get; set; }
        public String LogoTipo { get; set; }

    }
}
