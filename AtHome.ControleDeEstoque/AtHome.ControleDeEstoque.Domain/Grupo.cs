using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtHome.ControleDeEstoque.Domain
{
    public class Grupo
    {
        public Grupo() { }

        public Grupo(String descricao)
        {
            this.Descricao = descricao;
        }

        public long Id { get; set; }
        public String Descricao { get; set; }

    }

    public class GrupoCheckedListBoxItem
    {
        public long Tag;
        public string Text;
        public override string ToString() { return Text; }
    }

}
