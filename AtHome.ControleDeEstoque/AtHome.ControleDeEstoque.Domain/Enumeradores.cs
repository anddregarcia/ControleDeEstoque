using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtHome.ControleDeEstoque.Domain
{
    public class Enumeradores
    {
        public enum TipoComparador
        {
            Nenhum = 0,
            Maior_que = 1,
            Menor_que = 2
        }

        public enum TipoOperacao
        {
            Somar = 0,
            Subtrair = 1,
            Substituir = 2,
            Novo = 3,
            Excluir = 4
        }
    }
}
